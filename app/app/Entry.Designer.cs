namespace app
{
    partial class Entry
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
            btn_Register = new Button();
            btn_Login = new Button();
            SuspendLayout();
            // 
            // btn_Register
            // 
            btn_Register.Location = new Point(121, 63);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(95, 33);
            btn_Register.TabIndex = 0;
            btn_Register.Text = "Kayıt Ol";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(121, 102);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(95, 33);
            btn_Login.TabIndex = 1;
            btn_Login.Text = "Üye Girişi";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // Entry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 219);
            Controls.Add(btn_Login);
            Controls.Add(btn_Register);
            Name = "Entry";
            Text = "Entry";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Register;
        private Button btn_Login;
    }
}