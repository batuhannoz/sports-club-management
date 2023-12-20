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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Form myForm = new Profile();
            myForm.Show();
            this.Hide();
        }

        private void btn_health_Click(object sender, EventArgs e)
        {
            Form myForm = new HealthStatus();
            myForm.Show();
            this.Hide();
        }

        private void btn_MyPlan_Click(object sender, EventArgs e)
        {
            Form myForm = new ActivePlan();
            myForm.Show();
            this.Hide();
        }

        private void btn_Plans_Click(object sender, EventArgs e)
        {
            Form myForm = new Plans();
            myForm.Show();
            this.Hide();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            lbl_Name.Text = $"Merhaba {Store.user.Name}";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Store.conn.Close();
            Form myForm = new Entry();
            myForm.Show();
            this.Hide();
        }
    }
}
