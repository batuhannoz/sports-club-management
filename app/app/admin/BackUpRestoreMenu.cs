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
    public partial class BackUpRestoreMenu : Form
    {
        public BackUpRestoreMenu()
        {
            InitializeComponent();
        }

        private void btn_Table_Click(object sender, EventArgs e)
        {
            Form myForm = new BackUpRestoreTable();
            myForm.Show();
            this.Hide();
        }

        private void btn_DB_Click(object sender, EventArgs e)
        {
            Form myForm = new BackUpRestoreDB();
            myForm.Show();
            this.Hide();
        }
    }
}
