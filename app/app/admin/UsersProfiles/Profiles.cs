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
    public partial class Profiles : Form
    {
        Profile profile = new Profile();
        Permissions permissions = new Permissions(); 
        public Profiles()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form myForm = new AdminMenu();
            myForm.Show();
            this.Hide();
        }

        private void Profiles_Load(object sender, EventArgs e)
        {
            dgv_Profiles.DataSource = Store.GetAllProfiles();
        }

        private void dgv_Profiles_SelectionChanged(object sender, EventArgs e)
        {
            UpdateProfile();
        }

        private void UpdateProfile()
        {
            if (dgv_Profiles.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_Profiles.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_Profiles.Rows[selectedrowindex];

                profile.Id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                profile.Name = Convert.ToString(selectedRow.Cells["name"].Value);
                profile.PermissionId = Convert.ToInt32(selectedRow.Cells["permissions_id"].Value);

                txtbox_ProfileName.Text = Convert.ToString(selectedRow.Cells["name"].Value);

                permissions = Store.GetPermissionsById(profile.PermissionId);
                chk_ViewPlans.Checked = permissions.ViewPlans;
                chk_SubscribePlan.Checked = permissions.SubscribePlan;
                chk_UnsubscribePlan.Checked = permissions.UnsubscribePlan;
                chk_Pay.Checked = permissions.Pay;
                chk_ViewTimetable.Checked = permissions.ViewTimetable;
                chk_UpdateHealthStatus.Checked = permissions.UpdateHealthStatus;
                chk_UpdateProfile.Checked = permissions.UpdateProfile;
                chk_UpdateAddress.Checked = permissions.UpdateAddress;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                Store.UpdateProfileAndPermissions(
                    profile.Id,
                    txtbox_ProfileName.Text,
                    chk_ViewPlans.Checked,
                    chk_SubscribePlan.Checked,
                    chk_UnsubscribePlan.Checked,
                    chk_Pay.Checked,
                    chk_ViewTimetable.Checked,
                    chk_UpdateHealthStatus.Checked,
                    chk_UpdateProfile.Checked,
                    chk_UpdateAddress.Checked
                );
            }
            catch (Exception ex)
            {
                lbl_ProfileMessage.Text = ex.Message;
            }
            lbl_ProfileMessage.Text = "Güncelleme Başarılı";
            dgv_Profiles.DataSource = Store.GetAllProfiles();
            UpdateProfile();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Store.DeleteProfileAndPermissions(profile.Id);
            }
            catch (Exception ex)
            {
                lbl_ProfileMessage.Text = ex.Message;
            }
            lbl_ProfileMessage.Text = "Silme Başarılı";
            dgv_Profiles.DataSource = Store.GetAllProfiles();
            UpdateProfile();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                Store.InsertProfileAndPermissions(
                    new Permissions 
                    { 
                        ViewPlans = chk_ViewPlans.Checked,
                        SubscribePlan = chk_SubscribePlan.Checked,
                        UnsubscribePlan = chk_UnsubscribePlan.Checked,
                        Pay = chk_Pay.Checked,
                        ViewTimetable = chk_ViewTimetable.Checked,
                        UpdateAddress = chk_UpdateAddress.Checked,
                        UpdateHealthStatus = chk_UpdateHealthStatus.Checked,
                        UpdateProfile = chk_UpdateProfile.Checked,
                    },
                    new Profile
                    {
                        Name = txtbox_ProfileName.Text,
                    }
                );
            }
            catch (Exception ex)
            {
                lbl_ProfileMessage.Text = ex.Message;
            }
            lbl_ProfileMessage.Text = "Ekleme Başarılı";
            dgv_Profiles.DataSource = Store.GetAllProfiles();
            UpdateProfile();
        }
    }
}
