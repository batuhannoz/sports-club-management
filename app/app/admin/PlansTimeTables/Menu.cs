using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.admin.PlansTimeTables
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Form myForm = new Update();
            myForm.Show();
            this.Hide();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Form myForm = new Create();
            myForm.Show();
            this.Hide();
        }
    }
}
