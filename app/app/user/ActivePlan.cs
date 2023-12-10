using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.user
{
    public partial class ActivePlan : Form
    {
        public ActivePlan()
        {
            InitializeComponent();
        }

        private void ActivePlan_Load(object sender, EventArgs e)
        {
            try
            {
                SubscriptionInfo subInfo =  Store.GetSubscriptionInfoByUserId(Store.user.Id);
                lbl_NextPayDate.Text = $"{subInfo.NextPayDate}";
                lbl_PlanStartDate.Text = $"{subInfo.StartDate}";
                Store.GetPlanById(subInfo.PlanId);

            }
            catch (Exception ex) 
            {
                // TODO no active subscription
                return;
            }
        }
    }
}
