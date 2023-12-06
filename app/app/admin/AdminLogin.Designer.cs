namespace app.admin
{
    partial class AdminLogin
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
            label_Err = new Label();
            btn_Login = new Button();
            label2 = new Label();
            label1 = new Label();
            txtBox_Password = new TextBox();
            txtBox_Username = new TextBox();
            SuspendLayout();
            // 
            // label_Err
            // 
            label_Err.ImageAlign = ContentAlignment.BottomRight;
            label_Err.Location = new Point(12, 109);
            label_Err.Name = "label_Err";
            label_Err.Size = new Size(325, 15);
            label_Err.TabIndex = 11;
            label_Err.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(136, 136);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(84, 32);
            btn_Login.TabIndex = 10;
            btn_Login.Text = "Giriş Yap";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 66);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 9;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 25);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 8;
            label1.Text = "Kullanıcı Adı :";
            // 
            // txtBox_Password
            // 
            txtBox_Password.Location = new Point(152, 63);
            txtBox_Password.Name = "txtBox_Password";
            txtBox_Password.Size = new Size(132, 23);
            txtBox_Password.TabIndex = 7;
            // 
            // txtBox_Username
            // 
            txtBox_Username.Location = new Point(152, 22);
            txtBox_Username.Name = "txtBox_Username";
            txtBox_Username.Size = new Size(132, 23);
            txtBox_Username.TabIndex = 6;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 185);
            Controls.Add(label_Err);
            Controls.Add(btn_Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBox_Password);
            Controls.Add(txtBox_Username);
            Name = "AdminLogin";
            Text = "AdminLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Err;
        private Button btn_Login;
        private Label label2;
        private Label label1;
        private TextBox txtBox_Password;
        private TextBox txtBox_Username;
    }
}