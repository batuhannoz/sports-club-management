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

namespace app.user
{
    public partial class ActivePlan : Form
    {
        PlanInfo planInfo;
        SubscriptionInfo subInfo;
        List<TimetableInfo> timetable;
        public ActivePlan()
        {
            InitializeComponent();
        }

        private void ActivePlan_Load(object sender, EventArgs e)
        {
            if (!Store.permissions.UnsubscribePlan)
            {
                btn_Unsubscribe.Hide();
            }

            if (!Store.permissions.Pay)
            {
                btn_Pay.Hide();
            }

            try
            {
                subInfo = Store.GetSubscriptionInfoByUserId(Store.user.Id);
                lbl_NextPayDate.Text = $"{subInfo.NextPayDate}";
                lbl_PlanStartDate.Text = $"{subInfo.StartDate}";

                planInfo = Store.GetPlanById(subInfo.PlanId);
                lbl_PlanName.Text = $"{planInfo.Name}";
                lbl_PlanDescription.Text = $"{planInfo.Description}";
                lbl_PlanPrice.Text = $"{planInfo.Price}";
                lbl_PlanType.Text = $"{planInfo.Type}";

                if (Store.permissions.ViewTimetable)
                {
                    timetable = Store.GetWeeklyTimetableByPlanId(subInfo.PlanId);
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
            catch (Exception ex)
            {
                string message = "Aktif Aboneliğiniz Bulunmamaktadır";
                string title = "Hata";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    this.Close();
                    Form myForm = new UserMenu();
                    myForm.Show();
                    this.Hide();
                }
                else
                {
                    this.Close();
                    Form myForm = new UserMenu();
                    myForm.Show();
                    this.Hide();
                }
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form myForm = new UserMenu();
            myForm.Show();
            this.Hide();
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if ((subInfo.NextPayDate - DateTime.Now).TotalDays < 3)
            {
                subInfo = Store.GetSubscriptionInfoByUserId(Store.user.Id);
                lbl_NextPayDate.Text = $"{subInfo.NextPayDate}";
                lbl_PlanStartDate.Text = $"{subInfo.StartDate}";
            }
            else
            {
                string message = "Abonelikler Son 3 gün yenilenebilir, Yenilemek için çok erken.";
                string title = "Hata";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            } 
        }

        private void btn_Unsubscribe_Click(object sender, EventArgs e)
        {
            Store.UnsubscribeUser(Store.user.Id);
            Form myForm = new ActivePlan();
            myForm.Show();
            this.Close();
        }
    }
}
