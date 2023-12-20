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

namespace app.admin.PlansTimeTables
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                int planID = Store.CreateNewPlan(new PlanInfo
                {
                    Name = textBox_PlanName.Text,
                    Description = textBox_PlanDesc.Text,
                    Price = Convert.ToDecimal(textBox_PlanPrice.Text),
                    Type = textBox_PlanType.Text,
                    Status = textBox_PlanStatus.Text,
                });

                for (int dayOfWeek = 0; dayOfWeek <= 6; dayOfWeek++)
                {
                    TimetableInfo tt = new TimetableInfo();

                    tt.PlanId = planID;
                    tt.WeekDay = Convert.ToByte(dayOfWeek);

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

                    Store.CreateNewTimetable(tt);
                }

            }
            catch (Exception ex)
            {
                lbl_msg.Text = ex.Message;
            }
            lbl_msg.Text = "Created";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form myForm = new AdminMenu();
            myForm.Show();
            this.Hide();
        }
    }
}
