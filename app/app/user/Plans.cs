using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace app.user
{

    public partial class Plans : Form
    {
        int selectedPlanId = 0;
        public Plans()
        {
            InitializeComponent();
        }

        private void Plans_Load(object sender, EventArgs e)
        {
            dgv_Plans.DataSource = Store.GetActivePlans();

            dgv_Plans.Columns["name"].HeaderText = "Plan İsmi";
            dgv_Plans.Columns["description"].HeaderText = "Açıklama";
            dgv_Plans.Columns["price"].HeaderText = "Ücret";
            dgv_Plans.Columns["type"].HeaderText = "Grup Tipi";

            dgv_Plans.Columns["status"].Visible = false;
            dgv_Plans.Columns["id"].Visible = false;
        }

        private void dgv_Plans_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Plans.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_Plans.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_Plans.Rows[selectedrowindex];

                lbl_PlanName.Text = Convert.ToString(selectedRow.Cells["name"].Value);
                lbl_PlanDesc.Text = Convert.ToString(selectedRow.Cells["description"].Value);
                lbl_PlanPrice.Text = Convert.ToString(selectedRow.Cells["price"].Value);
                lbl_PlanType.Text = Convert.ToString(selectedRow.Cells["type"].Value) == "individual" ? "Tek Kişilik" : "Grup";

                selectedPlanId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                List<TimetableInfo> timetable; timetable = Store.GetWeeklyTimetableByPlanId(selectedPlanId);
                timetable = timetable.OrderBy(entry => entry.WeekDay).ToList();

                for (int dayOfWeek = 0; dayOfWeek <= 6; dayOfWeek++)
                {
                    // Kullanılacak günün başlangıç ve bitiş saatlerini al
                    string startTime = $"{timetable[dayOfWeek].StartTime}";
                    string endTime = $"{timetable[dayOfWeek].EndTime}";

                    // Günün adını al (0: Pazartesi, 1: Salı, ..., 6: Pazar)
                    string dayName = Enum.GetName(typeof(DayOfWeek), dayOfWeek);

                    // Label'ları güncelle
                    Controls.Find($"lbl_{dayName}Start", true)[0].Text = startTime;
                    Controls.Find($"lbl_{dayName}End", true)[0].Text = endTime;
                }
            }
        }
        private void btn_Subscribe_Click(object sender, EventArgs e)
        {
            if (selectedPlanId != 0)
            {
                Store.StartNewSubscription(Store.user.Id, selectedPlanId);
            }
            Form myForm = new ActivePlan();
            myForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form myForm = new UserMenu();
            myForm.Show();
            this.Hide();
        }
    }
}
