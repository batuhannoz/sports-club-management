namespace app.user
{
    partial class UserLogin
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
            txtBox_Email = new TextBox();
            SuspendLayout();
            // 
            // label_Err
            // 
            label_Err.ImageAlign = ContentAlignment.BottomRight;
            label_Err.Location = new Point(13, 110);
            label_Err.Name = "label_Err";
            label_Err.Size = new Size(325, 15);
            label_Err.TabIndex = 17;
            label_Err.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(137, 137);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(84, 32);
            btn_Login.TabIndex = 16;
            btn_Login.Text = "Giriş Yap";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 74);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 15;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 33);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 14;
            label1.Text = "E-mail :";
            // 
            // txtBox_Password
            // 
            txtBox_Password.Location = new Point(121, 71);
            txtBox_Password.Name = "txtBox_Password";
            txtBox_Password.Size = new Size(160, 23);
            txtBox_Password.TabIndex = 13;
            // 
            // txtBox_Email
            // 
            txtBox_Email.Location = new Point(121, 30);
            txtBox_Email.Name = "txtBox_Email";
            txtBox_Email.Size = new Size(160, 23);
            txtBox_Email.TabIndex = 12;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 187);
            Controls.Add(label_Err);
            Controls.Add(btn_Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBox_Password);
            Controls.Add(txtBox_Email);
            Name = "UserLogin";
            Text = "UserLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Err;
        private Button btn_Login;
        private Label label2;
        private Label label1;
        private TextBox txtBox_Password;
        private TextBox txtBox_Email;
    }
}