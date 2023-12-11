namespace app.admin
{
    partial class BackUpRestoreDB
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
            btn_Restore = new Button();
            btn_BackUp = new Button();
            SuspendLayout();
            // 
            // btn_Restore
            // 
            btn_Restore.Location = new Point(184, 45);
            btn_Restore.Name = "btn_Restore";
            btn_Restore.Size = new Size(107, 50);
            btn_Restore.TabIndex = 0;
            btn_Restore.Text = "Restore";
            btn_Restore.UseVisualStyleBackColor = true;
            btn_Restore.Click += btn_Restore_Click;
            // 
            // btn_BackUp
            // 
            btn_BackUp.Location = new Point(59, 45);
            btn_BackUp.Name = "btn_BackUp";
            btn_BackUp.Size = new Size(107, 50);
            btn_BackUp.TabIndex = 1;
            btn_BackUp.Text = "Back Up";
            btn_BackUp.UseVisualStyleBackColor = true;
            btn_BackUp.Click += btn_BackUp_Click;
            // 
            // BackUpRestoreDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 135);
            Controls.Add(btn_BackUp);
            Controls.Add(btn_Restore);
            Name = "BackUpRestoreDB";
            Text = "BackUpRestoreDB";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Restore;
        private Button btn_BackUp;
    }
}