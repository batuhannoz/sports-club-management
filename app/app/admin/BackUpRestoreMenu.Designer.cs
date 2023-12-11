namespace app.admin
{
    partial class BackUpRestoreMenu
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
            btn_Table = new Button();
            btn_DB = new Button();
            SuspendLayout();
            // 
            // btn_Table
            // 
            btn_Table.Location = new Point(66, 47);
            btn_Table.Name = "btn_Table";
            btn_Table.Size = new Size(94, 45);
            btn_Table.TabIndex = 0;
            btn_Table.Text = "Table";
            btn_Table.UseVisualStyleBackColor = true;
            btn_Table.Click += btn_Table_Click;
            // 
            // btn_DB
            // 
            btn_DB.Location = new Point(206, 47);
            btn_DB.Name = "btn_DB";
            btn_DB.Size = new Size(94, 45);
            btn_DB.TabIndex = 1;
            btn_DB.Text = "DB";
            btn_DB.UseVisualStyleBackColor = true;
            btn_DB.Click += btn_DB_Click;
            // 
            // BackUpRestoreMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 139);
            Controls.Add(btn_DB);
            Controls.Add(btn_Table);
            Name = "BackUpRestoreMenu";
            Text = "BackUpRestoreMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Table;
        private Button btn_DB;
    }
}