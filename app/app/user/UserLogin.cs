using app.admin;
using Microsoft.Data.SqlClient;
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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txtBox_Email.Text != "" && txtBox_Password.Text != "")
            {
                try
                {
                    Store.Connect("sa", "Password1!");
                    bool isLoggedIn = Store.UserLogin(txtBox_Email.Text, txtBox_Password.Text);
                    Store.permissions = Store.GetPermissionsByProfileId(Store.user.ProfileId);

                    if (isLoggedIn)
                    {
                        Form myForm = new UserMenu();
                        myForm.Show();
                        this.Hide();
                    } 
                    else
                    {
                        label_Err.Text = "E-mail veya Şifre yanlış";
                        return;
                    }
                }
                catch (Exception ex)
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

        }
    }
}
