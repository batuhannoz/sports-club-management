using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace app.user
{
    public partial class HealthStatus : Form
    {
        private DataTable dataTable;
        public HealthStatus()
        {
            InitializeComponent();
        }

        private void HealthStatus_Load(object sender, EventArgs e)
        {
            UpdateHealthView();

            if (!Store.permissions.UpdateHealthStatus)
            {
                button2.Hide();
            }
        }

        private void UpdateHealthView()
        {
            dataTable = Store.GetHealthRecords(Store.user.Id);
            dgv_HealthRecords.DataSource = dataTable;

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

        private void button3_Click(object sender, EventArgs e)
        {
            Form myForm = new UserMenu();
            myForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcıya bir SaveFileDialog gösterin.
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Excel Dosyasını Kaydet";
                saveFileDialog.FileName = "ExcelDosyaAdi";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Kullanıcının seçtiği dosya adını ve konumunu alın.
                    string filePath = saveFileDialog.FileName;

                    // DataTable'ı Excel dosyasına kaydetmek için metodu çağırın.
                    SaveDataTableToExcel(dataTable, filePath);

                    MessageBox.Show("Excel dosyası oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SaveDataTableToExcel(DataTable dataTable, string filePath)
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                // DataTable'daki veriyi Excel sayfasına ekleyin.
                workbook.Worksheets.Add(dataTable, "Sheet1");

                // Excel dosyasını belirtilen konuma kaydedin.
                workbook.SaveAs(filePath);
            }
        }
    }
}
