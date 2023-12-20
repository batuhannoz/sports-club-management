using DocumentFormat.OpenXml.Spreadsheet;
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

namespace app.admin.UsersProfiles
{
    public partial class Users : Form
    {
        User user = new User();
        Address address = new Address();

        public Users()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form myForm = new AdminMenu();
            myForm.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgv_Users.DataSource = Store.SearchUsers(textBox_Search.Text);
        }

        private void dgv_Users_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Users.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_Users.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_Users.Rows[selectedrowindex];

                user.Id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                user.Name = Convert.ToString(selectedRow.Cells["name"].Value);
                user.Surname = Convert.ToString(selectedRow.Cells["surname"].Value);
                user.DateOfBirth = Convert.ToDateTime(selectedRow.Cells["date_of_birth"].Value);
                user.PhoneNumber = Convert.ToString(selectedRow.Cells["phone_number"].Value);
                user.Email = Convert.ToString(selectedRow.Cells["email"].Value);
                user.Password = Convert.ToString(selectedRow.Cells["password"].Value);
                user.ProfileId = Convert.ToInt32(selectedRow.Cells["profile_id"].Value);

                txtbox_Name.Text = user.Name;
                txtbox_Surname.Text = user.Surname;
                dtPicker_dob.Value = user.DateOfBirth;
                txtbox_PhoneNumber.Text = user.PhoneNumber;
                txtbox_Email.Text = user.Email;
                txtbox_Password.Text = user.Password;
                cbox_Profiles.SelectedValue = user.ProfileId;

                address = Store.GetLatestAddressByUserId(user.Id);
                txtbox_City.Text = address.City;
                txtbox_District.Text = address.District;
                txtbox_Neighborhood.Text = address.Neighborhood;
                txtbox_Street.Text = address.Street;
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            DataTable profiles = Store.GetProfilesWithID();
            cbox_Profiles.DataSource = profiles;
            cbox_Profiles.DisplayMember = "name";
            cbox_Profiles.ValueMember = "id";
        }

        private void btn_UpdateUser_Click(object sender, EventArgs e)
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
                        Convert.ToInt32(cbox_Profiles.SelectedValue)
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

        private void btn_UpdateAddress_Click(object sender, EventArgs e)
        {
            if (txtbox_City.Text != "" &&
                txtbox_District.Text != "" &&
                txtbox_Neighborhood.Text != "" &&
                txtbox_Street.Text != "")
            {
                try
                {
                    Store.InsertNewAddress(
                        user.Id,
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

        private void btn_InsertUser_Click(object sender, EventArgs e)
        {
            if (
                txtbox_Name.Text != "" &&
                txtbox_Surname.Text != "" &&
                dtPicker_dob.Value <= DateTime.Now &&
                txtbox_Surname.Text != "" &&
                txtbox_PhoneNumber.Text != "" &&
                txtbox_Email.Text != "" &&
                txtbox_Password.Text != "" &&
                txtbox_City.Text != "" &&
                txtbox_District.Text != "" &&
                txtbox_Neighborhood.Text != "" &&
                txtbox_Street.Text != ""
                ) 
            {
                try
                {
                    int id = Store.InsertNewUser(
                        txtbox_Name.Text,
                        txtbox_Surname.Text,
                        dtPicker_dob.Value,
                        txtbox_PhoneNumber.Text,
                        txtbox_Email.Text,
                        txtbox_Password.Text,
                        Convert.ToInt32(cbox_Profiles.SelectedValue)
                    );
                    Store.InsertNewAddress(
                        id,
                        txtbox_City.Text,
                        txtbox_District.Text,
                        txtbox_Neighborhood.Text,
                        txtbox_Street.Text
                    );
                }
                catch (Exception ex)
                {
                    lbl_InsertError.Text = ex.Message;
                }
            }
            else
            {
                lbl_InsertError.Text = "Bilgileri tekrar kontrol ediniz";
                return;
            }
        }
    }
}
