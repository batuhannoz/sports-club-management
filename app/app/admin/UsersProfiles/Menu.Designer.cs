namespace app.admin.UsersProfiles
{
    partial class Menu
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
            btn_Users = new Button();
            btn_Profiles = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 43;
            button3.Text = "Ana Menü";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btn_Users
            // 
            btn_Users.Location = new Point(57, 53);
            btn_Users.Name = "btn_Users";
            btn_Users.Size = new Size(102, 45);
            btn_Users.TabIndex = 44;
            btn_Users.Text = "Users";
            btn_Users.UseVisualStyleBackColor = true;
            btn_Users.Click += btn_Users_Click;
            // 
            // btn_Profiles
            // 
            btn_Profiles.Location = new Point(201, 53);
            btn_Profiles.Name = "btn_Profiles";
            btn_Profiles.Size = new Size(102, 45);
            btn_Profiles.TabIndex = 45;
            btn_Profiles.Text = "Profiles && Permissions";
            btn_Profiles.UseVisualStyleBackColor = true;
            btn_Profiles.Click += btn_Profiles_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 140);
            Controls.Add(btn_Profiles);
            Controls.Add(btn_Users);
            Controls.Add(button3);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button btn_Users;
        private Button btn_Profiles;
    }
}