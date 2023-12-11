using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.admin
{
    public partial class BackUpRestoreDB : Form
    {
        public BackUpRestoreDB()
        {
            InitializeComponent();
        }

        private void btn_BackUp_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Backup Files|*.bak";
                saveFileDialog.Title = "Veritabanı Yedeğini Al";
                saveFileDialog.FileName = "BackupFileName";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    Store.BackupDatabase(filePath);
                    MessageBox.Show("Veritabanı yedeği alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Backup Files|*.bak";
                openFileDialog.Title = "Veritabanı Yedeğinden Geri Yükle";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    Store.RestoreDatabase(filePath);
                    MessageBox.Show("Veritabanı yedeği geri yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
