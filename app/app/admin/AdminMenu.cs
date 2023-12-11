using app.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.admin
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btn_UsersProfiles_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_BackUpRestore_Click(object sender, EventArgs e)
        {
            Form myForm = new BackUpRestoreMenu();
            myForm.Show();
            this.Hide();
        }

        private void btn_Plan_Click(object sender, EventArgs e)
        {

        }
    }
}
