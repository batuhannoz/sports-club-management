using Microsoft.Data.SqlClient;
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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txtBox_Username.Text != "" && txtBox_Password.Text != "")
            {
                try
                {
                    Store.Connect(txtBox_Username.Text, txtBox_Password.Text);
                }
                catch (SqlException ex)
                {
                    label_Err.Text = ex.Message;
                    return;
                }
            }
            else
            {
                label_Err.Text = "Kullanıcı adı veya şifre alanı boş bırakılamaz";
                return;
            }
            Form myForm = new AdminMenu();
            myForm.Show();
            this.Hide();
        }
    }
}
