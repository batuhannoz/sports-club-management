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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbox_Name.Text != "" &&
                txtbox_Surname.Text != "" &&
                dtPicker_dob.Value <= DateTime.Now &&
                txtbox_Surname.Text != "" &&
                txtbox_PhoneNumber.Text != "" &&
                txtbox_Email.Text != "" &&
                txtbox_Password.Text != ""
                )
            {
                Store.UpdateUser(
                    Store.user.Id
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
            }
            else
            {
                label_UserError.Text = "Bilgileri tekrar kontrol ediniz";
                return;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
