using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Form myForm = new Login();
            myForm.Show();
            this.Hide();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Form myForm = new Register();
            myForm.Show();
            this.Hide();
        }
    }
}
