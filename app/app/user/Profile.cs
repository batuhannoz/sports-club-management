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
                try
                {
                    Store.UpdateUser(
                        Store.user.Id,
                        txtbox_Name.Text,
                        txtbox_Surname.Text,
                        dtPicker_dob.Value,
                        txtbox_PhoneNumber.Text,
                        txtbox_Email.Text,
                        txtbox_Password.Text,
                        Store.user.ProfileId
                    );
                }
                catch (Exception ex) 
                {
                    label_UserError.Text = ex.Message;
                }             
            }
            else
            {
                label_UserError.Text = "Bilgileri tekrar kontrol ediniz";
                return;
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            txtbox_Name.Text = Store.user.Name;
            txtbox_Surname.Text = Store.user.Surname;
            dtPicker_dob.Value = Store.user.DateOfBirth;
            txtbox_PhoneNumber.Text = Store.user.PhoneNumber;
            txtbox_Email.Text = Store.user.Email;
            txtbox_Password.Text = Store.user.Password;

            Address address = Store.GetLatestAddressByUserId(Store.user.Id);
            txtbox_City.Text = address.City;
            txtbox_District.Text = address.District;
            txtbox_Neighborhood.Text = address.Neighborhood;
            txtbox_Street.Text = address.Street;

            if (!Store.permissions.UpdateProfile)
            {
                button1.Hide();
            }

            if (!Store.permissions.UpdateAddress)
            {
                button2.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtbox_City.Text != "" &&
                txtbox_District.Text != "" &&
                txtbox_Neighborhood.Text != "" &&
                txtbox_Street.Text != ""
                )
            {
                try
                {
                    Store.InsertNewAddress(
                        Store.user.Id,
                        txtbox_City.Text,
                        txtbox_District.Text,
                        txtbox_Neighborhood.Text,
                        txtbox_Street.Text
                    );
                }
                catch (Exception ex)
                {
                    label_UserError.Text = ex.Message;
                }
            }
            else
            {
                label_AddressError.Text = "Bilgileri tekrar kontrol ediniz";
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form myForm = new UserMenu();
            myForm.Show();
            this.Hide();
        }
    }
}
