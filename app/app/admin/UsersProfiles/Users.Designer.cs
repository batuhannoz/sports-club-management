namespace app.admin.UsersProfiles
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_Users = new DataGridView();
            button3 = new Button();
            textBox_Search = new TextBox();
            btn_Search = new Button();
            cbox_Profiles = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Users).BeginInit();
            SuspendLayout();
            // 
            // dgv_Users
            // 
            dgv_Users.AllowUserToAddRows = false;
            dgv_Users.AllowUserToDeleteRows = false;
            dgv_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Users.Location = new Point(12, 41);
            dgv_Users.MultiSelect = false;
            dgv_Users.Name = "dgv_Users";
            dgv_Users.ReadOnly = true;
            dgv_Users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Users.Size = new Size(823, 779);
            dgv_Users.TabIndex = 0;
            dgv_Users.SelectionChanged += dgv_Users_SelectionChanged;
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 44;
            button3.Text = "Ana Menü";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox_Search
            // 
            textBox_Search.Location = new Point(280, 12);
            textBox_Search.Name = "textBox_Search";
            textBox_Search.Size = new Size(219, 23);
            textBox_Search.TabIndex = 45;
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(505, 12);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(75, 23);
            btn_Search.TabIndex = 46;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // cbox_Profiles
            // 
            cbox_Profiles.FormattingEnabled = true;
            cbox_Profiles.Location = new Point(1002, 342);
            cbox_Profiles.Name = "cbox_Profiles";
            cbox_Profiles.Size = new Size(121, 23);
            cbox_Profiles.TabIndex = 47;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 832);
            Controls.Add(cbox_Profiles);
            Controls.Add(btn_Search);
            Controls.Add(textBox_Search);
            Controls.Add(button3);
            Controls.Add(dgv_Users);
            Name = "Users";
            Text = "Users";
            ((System.ComponentModel.ISupportInitialize)dgv_Users).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Users;
        private Button button3;
        private TextBox textBox_Search;
        private Button btn_Search;
        private ComboBox cbox_Profiles;
    }
}