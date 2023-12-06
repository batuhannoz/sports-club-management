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
            SuspendLayout();
            // 
            // btn_Profile
            // 
            btn_Profile.Location = new Point(155, 59);
            btn_Profile.Name = "btn_Profile";
            btn_Profile.Size = new Size(116, 47);
            btn_Profile.TabIndex = 0;
            btn_Profile.Text = "Kullanıcı Bilgilerim";
            btn_Profile.UseVisualStyleBackColor = true;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 274);
            Controls.Add(btn_Profile);
            Name = "UserMenu";
            Text = "UserMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Profile;
    }
}