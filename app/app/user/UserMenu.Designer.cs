namespace app.user
{
    partial class UserMenu
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
            btn_Profile = new Button();
            btn_Plans = new Button();
            btn_health = new Button();
            btn_MyPlan = new Button();
            lbl_Name = new Label();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // btn_Profile
            // 
            btn_Profile.Location = new Point(59, 106);
            btn_Profile.Name = "btn_Profile";
            btn_Profile.Size = new Size(116, 47);
            btn_Profile.TabIndex = 0;
            btn_Profile.Text = "Kullanıcı Bilgilerim";
            btn_Profile.UseVisualStyleBackColor = true;
            btn_Profile.Click += btn_Profile_Click;
            // 
            // btn_Plans
            // 
            btn_Plans.Location = new Point(198, 173);
            btn_Plans.Name = "btn_Plans";
            btn_Plans.Size = new Size(116, 47);
            btn_Plans.TabIndex = 1;
            btn_Plans.Text = "Planları Görüntüle";
            btn_Plans.UseVisualStyleBackColor = true;
            btn_Plans.Click += btn_Plans_Click;
            // 
            // btn_health
            // 
            btn_health.Location = new Point(198, 106);
            btn_health.Name = "btn_health";
            btn_health.Size = new Size(116, 47);
            btn_health.TabIndex = 2;
            btn_health.Text = "Sağlık Bilgilerim";
            btn_health.UseVisualStyleBackColor = true;
            btn_health.Click += btn_health_Click;
            // 
            // btn_MyPlan
            // 
            btn_MyPlan.Location = new Point(59, 173);
            btn_MyPlan.Name = "btn_MyPlan";
            btn_MyPlan.Size = new Size(116, 47);
            btn_MyPlan.TabIndex = 3;
            btn_MyPlan.Text = "Planımı Görüntüle";
            btn_MyPlan.UseVisualStyleBackColor = true;
            btn_MyPlan.Click += btn_MyPlan_Click;
            // 
            // lbl_Name
            // 
            lbl_Name.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_Name.Location = new Point(12, 38);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(351, 52);
            lbl_Name.TabIndex = 4;
            lbl_Name.Text = "label1";
            lbl_Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(12, 12);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(75, 23);
            btn_Exit.TabIndex = 19;
            btn_Exit.Text = "Geri";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 232);
            Controls.Add(btn_Exit);
            Controls.Add(lbl_Name);
            Controls.Add(btn_MyPlan);
            Controls.Add(btn_health);
            Controls.Add(btn_Plans);
            Controls.Add(btn_Profile);
            Name = "UserMenu";
            Text = "UserMenu";
            Load += UserMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Profile;
        private Button btn_Plans;
        private Button btn_health;
        private Button btn_MyPlan;
        private Label lbl_Name;
        private Button btn_Exit;
    }
}