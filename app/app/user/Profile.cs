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
            label_UserError.Text = "Güncellendi";
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            try
            {
                User user = Store.GetUserById(Store.user.Id);
                txtbox_Name.Text = user.Name;
                txtbox_Surname.Text = user.Surname;
                dtPicker_dob.Value = user.DateOfBirth;
                txtbox_PhoneNumber.Text = user.PhoneNumber;
                txtbox_Email.Text = user.Email;
                txtbox_Password.Text = user.Password;

                Address address = Store.GetLatestAddressByUserId(Store.user.Id);
                txtbox_City.Text = address.City;
                txtbox_District.Text = address.District;
                txtbox_Neighborhood.Text = address.Neighborhood;
                txtbox_Street.Text = address.Street;
            } 
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);  
            }

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
            label_AddressError.Text = "Güncellendi";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form myForm = new UserMenu();
            myForm.Show();
            this.Hide();
        }
    }
}
