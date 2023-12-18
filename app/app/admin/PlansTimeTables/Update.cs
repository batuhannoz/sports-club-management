using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace app.admin.PlansTimeTables
{
    public partial class Update : Form
    {
        PlanInfo plan;
        List<TimetableInfo> timetables;
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form myForm = new AdminMenu();
            myForm.Show();
            this.Hide();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            dgv_Plans.DataSource = Store.GetPlanData();

            dgv_Plans.Columns["name"].HeaderText = "Plan İsmi";
            dgv_Plans.Columns["description"].HeaderText = "Açıklama";
            dgv_Plans.Columns["price"].HeaderText = "Ücret";
            dgv_Plans.Columns["type"].HeaderText = "Grup Tipi";
            dgv_Plans.Columns["status"].HeaderText = "Plan Durumu";
            dgv_Plans.Columns["id"].HeaderText = "id";
        }

        private void dgv_Plans_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Plans.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_Plans.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_Plans.Rows[selectedrowindex];

                plan.Name = Convert.ToString(selectedRow.Cells["name"].Value);
                plan.Description = Convert.ToString(selectedRow.Cells["description"].Value);
                plan.Price = Convert.ToInt32(selectedRow.Cells["price"].Value);
                plan.Status = Convert.ToString(selectedRow.Cells["status"].Value);
                plan.Id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                plan.Type = Convert.ToString(selectedRow.Cells["type"].Value);

                textBox_PlanName.Text = Convert.ToString(selectedRow.Cells["name"].Value);
                textBox_PlanDesc.Text = Convert.ToString(selectedRow.Cells["description"].Value);
                textBox_PlanPrice.Text = Convert.ToString(selectedRow.Cells["price"].Value);
                textBox_PlanType.Text = Convert.ToString(selectedRow.Cells["type"].Value);
                textBox_PlanStatus.Text = Convert.ToString(selectedRow.Cells["status"].Value);


                timetables = Store.GetWeeklyTimetableByPlanId(plan.Id);
                timetables = timetables.OrderBy(entry => entry.WeekDay).ToList();

                for (int dayOfWeek = 0; dayOfWeek <= 6; dayOfWeek++)
                {
                    // Kullanılacak günün başlangıç ve bitiş saatlerini al
                    string startTime = $"{timetables[dayOfWeek].StartTime}";
                    string endTime = $"{timetables[dayOfWeek].EndTime}";

                    // Günün adını al (0: Pazartesi, 1: Salı, ..., 6: Pazar)
                    string dayName = Enum.GetName(typeof(DayOfWeek), dayOfWeek);

                    // DateTimePicker kontrolünü adından bul ve güncelle
                    if (Controls[$"dtp_{dayName}Start"] is DateTimePicker startDateTimePicker)
                    {
                        startDateTimePicker.Value = DateTime.Parse(startTime);
                    }

                    if (Controls[$"dtp_{dayName}End"] is DateTimePicker endDateTimePicker)
                    {
                        endDateTimePicker.Value = DateTime.Parse(endTime);
                    }
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                Store.UpdatePlanById(new PlanInfo {
                    Id = plan.Id,
                    Name = textBox_PlanName.Text,
                    Description = textBox_PlanDesc.Text,
                    Price = Convert.ToDecimal(textBox_PlanPrice.Text),
                    Type = textBox_PlanType.Text,
                    Status = textBox_PlanStatus.Text,
                });
                for (int dayOfWeek = 0; dayOfWeek <= 6; dayOfWeek++)
                {
                    TimetableInfo tt = new TimetableInfo();

                    tt.PlanId = Convert.ToInt32(timetables[dayOfWeek].PlanId);
                    tt.Id = timetables[dayOfWeek].Id;
                    tt.WeekDay = timetables[dayOfWeek].WeekDay;

                    // Günün adını al (0: Pazartesi, 1: Salı, ..., 6: Pazar)
                    string dayName = Enum.GetName(typeof(DayOfWeek), dayOfWeek);

                    // DateTimePicker kontrolünü adından bul ve güncelle
                    if (Controls[$"dtp_{dayName}Start"] is DateTimePicker startDateTimePicker)
                    {                        
                        tt.StartTime = startDateTimePicker.Value.TimeOfDay;
                    }

                    if (Controls[$"dtp_{dayName}End"] is DateTimePicker endDateTimePicker)
                    {
                        tt.EndTime = endDateTimePicker.Value.TimeOfDay;
                    }

                    Debug.WriteLine($"{tt.Id}, {tt.PlanId}, {tt.StartTime}, {tt.EndTime}");
                    Store.UpdateTimetableById(tt);
                }
                
            }
            catch (Exception ex)
            {
                lbl_msg.Text = ex.Message;
            }
            dgv_Plans.DataSource = Store.GetPlanData();
        }
    }
}
