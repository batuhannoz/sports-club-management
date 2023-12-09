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
    public partial class HealthStatus : Form
    {
        public HealthStatus()
        {
            InitializeComponent();
        }

        private void HealthStatus_Load(object sender, EventArgs e)
        {
            UpdateHealthView();
        }

        private void UpdateHealthView()
        {
            dgv_HealthRecords.DataSource = Store.GetHealthRecords(Store.user.Id);

            dgv_HealthRecords.Columns["weight"].HeaderText = "Kilo";
            dgv_HealthRecords.Columns["height"].HeaderText = "Boy";
            dgv_HealthRecords.Columns["measurement_day"].HeaderText = "Ölçüm Günü ve Saati";

            // Hide other columns if necessary
            dgv_HealthRecords.Columns["id"].Visible = false; // Assuming 'id' is a column in the DataTable
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num_Height.Value != 0 && num_Weight.Value != 0)
            {
                Store.InsertHealthStatus(Store.user.Id, Convert.ToInt32(num_Weight.Value), Convert.ToInt32(num_Height.Value));
                UpdateHealthView();
            } 
            else
            {
                label_Error.Text = "Girilen Bilgileri Kontrol Ediniz";
            }
        }
    }
}
