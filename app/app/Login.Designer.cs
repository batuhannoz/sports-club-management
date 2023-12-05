namespace app
{
    partial class Login
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
            txtBox_Username = new TextBox();
            txtBox_Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_Login = new Button();
            SuspendLayout();
            // 
            // txtBox_Username
            // 
            txtBox_Username.Location = new Point(153, 58);
            txtBox_Username.Name = "txtBox_Username";
            txtBox_Username.Size = new Size(132, 23);
            txtBox_Username.TabIndex = 0;
            // 
            // txtBox_Password
            // 
            txtBox_Password.Location = new Point(153, 99);
            txtBox_Password.Name = "txtBox_Password";
            txtBox_Password.Size = new Size(132, 23);
            txtBox_Password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 61);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 102);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre :";
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(139, 143);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(84, 32);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Giriş Yap";
            btn_Login.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 236);
            Controls.Add(btn_Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBox_Password);
            Controls.Add(txtBox_Username);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox_Username;
        private TextBox txtBox_Password;
        private Label label1;
        private Label label2;
        private Button btn_Login;
    }
}