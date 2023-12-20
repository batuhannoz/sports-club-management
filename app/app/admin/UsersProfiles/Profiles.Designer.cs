namespace app.admin.UsersProfiles
{
    partial class Profiles
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
            button3 = new Button();
            dgv_Profiles = new DataGridView();
            chk_ViewPlans = new CheckBox();
            txtbox_ProfileName = new TextBox();
            chk_SubscribePlan = new CheckBox();
            chk_Pay = new CheckBox();
            chk_UnsubscribePlan = new CheckBox();
            chk_UpdateAddress = new CheckBox();
            chk_UpdateProfile = new CheckBox();
            chk_UpdateHealthStatus = new CheckBox();
            chk_ViewTimetable = new CheckBox();
            btn_Update = new Button();
            btn_Delete = new Button();
            btn_Insert = new Button();
            lbl_ProfileMessage = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Profiles).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 45;
            button3.Text = "Ana Menü";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dgv_Profiles
            // 
            dgv_Profiles.AllowUserToAddRows = false;
            dgv_Profiles.AllowUserToDeleteRows = false;
            dgv_Profiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Profiles.Location = new Point(372, 12);
            dgv_Profiles.MultiSelect = false;
            dgv_Profiles.Name = "dgv_Profiles";
            dgv_Profiles.Size = new Size(340, 436);
            dgv_Profiles.TabIndex = 46;
            dgv_Profiles.SelectionChanged += dgv_Profiles_SelectionChanged;
            // 
            // chk_ViewPlans
            // 
            chk_ViewPlans.AutoSize = true;
            chk_ViewPlans.Location = new Point(48, 109);
            chk_ViewPlans.Name = "chk_ViewPlans";
            chk_ViewPlans.Size = new Size(82, 19);
            chk_ViewPlans.TabIndex = 47;
            chk_ViewPlans.Text = "View Plans";
            chk_ViewPlans.UseVisualStyleBackColor = true;
            // 
            // txtbox_ProfileName
            // 
            txtbox_ProfileName.Location = new Point(158, 57);
            txtbox_ProfileName.Name = "txtbox_ProfileName";
            txtbox_ProfileName.Size = new Size(129, 23);
            txtbox_ProfileName.TabIndex = 48;
            // 
            // chk_SubscribePlan
            // 
            chk_SubscribePlan.AutoSize = true;
            chk_SubscribePlan.Location = new Point(48, 146);
            chk_SubscribePlan.Name = "chk_SubscribePlan";
            chk_SubscribePlan.Size = new Size(103, 19);
            chk_SubscribePlan.TabIndex = 49;
            chk_SubscribePlan.Text = "Subscribe Plan";
            chk_SubscribePlan.UseVisualStyleBackColor = true;
            // 
            // chk_Pay
            // 
            chk_Pay.AutoSize = true;
            chk_Pay.Location = new Point(48, 220);
            chk_Pay.Name = "chk_Pay";
            chk_Pay.Size = new Size(45, 19);
            chk_Pay.TabIndex = 51;
            chk_Pay.Text = "Pay";
            chk_Pay.UseVisualStyleBackColor = true;
            // 
            // chk_UnsubscribePlan
            // 
            chk_UnsubscribePlan.AutoSize = true;
            chk_UnsubscribePlan.Location = new Point(48, 183);
            chk_UnsubscribePlan.Name = "chk_UnsubscribePlan";
            chk_UnsubscribePlan.Size = new Size(117, 19);
            chk_UnsubscribePlan.TabIndex = 50;
            chk_UnsubscribePlan.Text = "Unsubscribe Plan";
            chk_UnsubscribePlan.UseVisualStyleBackColor = true;
            // 
            // chk_UpdateAddress
            // 
            chk_UpdateAddress.AutoSize = true;
            chk_UpdateAddress.Location = new Point(206, 220);
            chk_UpdateAddress.Name = "chk_UpdateAddress";
            chk_UpdateAddress.Size = new Size(109, 19);
            chk_UpdateAddress.TabIndex = 55;
            chk_UpdateAddress.Text = "Update Address";
            chk_UpdateAddress.UseVisualStyleBackColor = true;
            // 
            // chk_UpdateProfile
            // 
            chk_UpdateProfile.AutoSize = true;
            chk_UpdateProfile.Location = new Point(206, 183);
            chk_UpdateProfile.Name = "chk_UpdateProfile";
            chk_UpdateProfile.Size = new Size(101, 19);
            chk_UpdateProfile.TabIndex = 54;
            chk_UpdateProfile.Text = "Update Profile";
            chk_UpdateProfile.UseVisualStyleBackColor = true;
            // 
            // chk_UpdateHealthStatus
            // 
            chk_UpdateHealthStatus.AutoSize = true;
            chk_UpdateHealthStatus.Location = new Point(206, 146);
            chk_UpdateHealthStatus.Name = "chk_UpdateHealthStatus";
            chk_UpdateHealthStatus.Size = new Size(137, 19);
            chk_UpdateHealthStatus.TabIndex = 53;
            chk_UpdateHealthStatus.Text = "Update Health Status";
            chk_UpdateHealthStatus.UseVisualStyleBackColor = true;
            // 
            // chk_ViewTimetable
            // 
            chk_ViewTimetable.AutoSize = true;
            chk_ViewTimetable.Location = new Point(206, 109);
            chk_ViewTimetable.Name = "chk_ViewTimetable";
            chk_ViewTimetable.RightToLeft = RightToLeft.No;
            chk_ViewTimetable.Size = new Size(106, 19);
            chk_ViewTimetable.TabIndex = 52;
            chk_ViewTimetable.Text = "View Timetable";
            chk_ViewTimetable.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(130, 286);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(100, 34);
            btn_Update.TabIndex = 56;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(130, 326);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(100, 34);
            btn_Delete.TabIndex = 57;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(130, 366);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(100, 34);
            btn_Insert.TabIndex = 58;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // lbl_ProfileMessage
            // 
            lbl_ProfileMessage.Location = new Point(34, 258);
            lbl_ProfileMessage.Name = "lbl_ProfileMessage";
            lbl_ProfileMessage.Size = new Size(295, 15);
            lbl_ProfileMessage.TabIndex = 73;
            lbl_ProfileMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 60);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 74;
            label1.Text = "Profile Name :";
            // 
            // Profiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 460);
            Controls.Add(label1);
            Controls.Add(lbl_ProfileMessage);
            Controls.Add(btn_Insert);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(chk_UpdateAddress);
            Controls.Add(chk_UpdateProfile);
            Controls.Add(chk_UpdateHealthStatus);
            Controls.Add(chk_ViewTimetable);
            Controls.Add(chk_Pay);
            Controls.Add(chk_UnsubscribePlan);
            Controls.Add(chk_SubscribePlan);
            Controls.Add(txtbox_ProfileName);
            Controls.Add(chk_ViewPlans);
            Controls.Add(dgv_Profiles);
            Controls.Add(button3);
            Name = "Profiles";
            Text = "Profiles";
            Load += Profiles_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Profiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private DataGridView dgv_Profiles;
        private CheckBox chk_ViewPlans;
        private TextBox txtbox_ProfileName;
        private CheckBox chk_SubscribePlan;
        private CheckBox chk_Pay;
        private CheckBox chk_UnsubscribePlan;
        private CheckBox chk_UpdateAddress;
        private CheckBox chk_UpdateProfile;
        private CheckBox chk_UpdateHealthStatus;
        private CheckBox chk_ViewTimetable;
        private Button btn_Update;
        private Button btn_Delete;
        private Button btn_Insert;
        private Label lbl_ProfileMessage;
        private Label label1;
    }
}