using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.admin.UsersProfiles
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form myForm = new AdminMenu();
            myForm.Show();
            this.Hide();
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            Form myForm = new Users();
            myForm.Show();
            this.Hide();
        }
    }
}
