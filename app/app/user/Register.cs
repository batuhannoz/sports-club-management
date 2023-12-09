﻿using app.user;
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

namespace app
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txtbox_Name.Text != "" &&
                txtbox_Surname.Text != "" &&
                dtPicker_dob.Value <= DateTime.Now &&
                txtbox_Surname.Text != "" &&
                txtbox_PhoneNumber.Text != "" &&
                txtbox_Email.Text != "" && 
                txtbox_Password.Text != "" &&
                txtbox_Password.Text == txtbox_PasswordCheck.Text
                )
            {
                Store.Connect("sa", "Password1!");
                Store.InsertUser(
                    txtbox_Name.Text,
                    txtbox_Surname.Text,
                    dtPicker_dob.Value,
                    txtbox_PhoneNumber.Text,
                    txtbox_Email.Text,
                    txtbox_Password.Text
                     );
                Store.UserLogin(txtbox_Email.Text, txtbox_Password.Text);
                Form myForm = new UserMenu();
                myForm.Show();
                this.Hide();
            } else
            {
                label_RegisterError.Text = "Bilgileri tekrar kontrol ediniz";
                return;
            }
        }
    }
}
