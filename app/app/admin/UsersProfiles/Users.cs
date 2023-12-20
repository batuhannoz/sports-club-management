using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class Users : Form
    {
        User user;
        Address address;

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

                address = Store.GetLatestAddressByUserId(user.Id);

                DataTable profiles = Store.GetProfilesWithID();
                
                cbox_Profiles.DataSource = profiles;
                cbox_Profiles.DisplayMember = "name";
                cbox_Profiles.ValueMember = "id";

                // TODO text boxes 
            }
        }
    }
}
