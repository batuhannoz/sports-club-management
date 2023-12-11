namespace app.admin
{
    partial class AdminMenu
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
            btn_UsersProfiles = new Button();
            btn_BackUpRestore = new Button();
            btn_Plan = new Button();
            SuspendLayout();
            // 
            // btn_UsersProfiles
            // 
            btn_UsersProfiles.Location = new Point(307, 84);
            btn_UsersProfiles.Name = "btn_UsersProfiles";
            btn_UsersProfiles.RightToLeft = RightToLeft.No;
            btn_UsersProfiles.Size = new Size(115, 44);
            btn_UsersProfiles.TabIndex = 0;
            btn_UsersProfiles.Text = "Users && Profiles";
            btn_UsersProfiles.UseVisualStyleBackColor = true;
            btn_UsersProfiles.Click += btn_UsersProfiles_Click;
            // 
            // btn_BackUpRestore
            // 
            btn_BackUpRestore.Location = new Point(161, 84);
            btn_BackUpRestore.Name = "btn_BackUpRestore";
            btn_BackUpRestore.Size = new Size(115, 44);
            btn_BackUpRestore.TabIndex = 1;
            btn_BackUpRestore.Text = "Back Up && Restore";
            btn_BackUpRestore.UseVisualStyleBackColor = true;
            btn_BackUpRestore.Click += btn_BackUpRestore_Click;
            // 
            // btn_Plan
            // 
            btn_Plan.Location = new Point(14, 84);
            btn_Plan.Name = "btn_Plan";
            btn_Plan.Size = new Size(115, 44);
            btn_Plan.TabIndex = 2;
            btn_Plan.Text = "Plans && Time Tables";
            btn_Plan.UseVisualStyleBackColor = true;
            btn_Plan.Click += btn_Plan_Click;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 212);
            Controls.Add(btn_Plan);
            Controls.Add(btn_BackUpRestore);
            Controls.Add(btn_UsersProfiles);
            Name = "AdminMenu";
            Text = "AdminMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_UsersProfiles;
        private Button btn_BackUpRestore;
        private Button btn_Plan;
    }
}