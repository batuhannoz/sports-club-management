namespace app
{
    partial class Register
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
            txtbox_Name = new TextBox();
            label_Name = new Label();
            label_Surname = new Label();
            txtbox_Surname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtbox_PhoneNumber = new TextBox();
            label3 = new Label();
            txtbox_Email = new TextBox();
            label4 = new Label();
            txtbox_Password = new TextBox();
            label5 = new Label();
            txtbox_PasswordCheck = new TextBox();
            btn_Register = new Button();
            label_RegisterError = new Label();
            dtPicker_dob = new DateTimePicker();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // txtbox_Name
            // 
            txtbox_Name.Location = new Point(142, 27);
            txtbox_Name.Name = "txtbox_Name";
            txtbox_Name.Size = new Size(138, 23);
            txtbox_Name.TabIndex = 0;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(101, 30);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(35, 15);
            label_Name.TabIndex = 1;
            label_Name.Text = "İsim :";
            // 
            // label_Surname
            // 
            label_Surname.AutoSize = true;
            label_Surname.Location = new Point(82, 59);
            label_Surname.Name = "label_Surname";
            label_Surname.Size = new Size(54, 15);
            label_Surname.TabIndex = 3;
            label_Surname.Text = "Soyisim :";
            // 
            // txtbox_Surname
            // 
            txtbox_Surname.Location = new Point(142, 56);
            txtbox_Surname.Name = "txtbox_Surname";
            txtbox_Surname.Size = new Size(138, 23);
            txtbox_Surname.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 88);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 5;
            label1.Text = "Doğum Tarihi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 117);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 7;
            label2.Text = "Telefon Numarası :";
            // 
            // txtbox_PhoneNumber
            // 
            txtbox_PhoneNumber.Location = new Point(142, 114);
            txtbox_PhoneNumber.Name = "txtbox_PhoneNumber";
            txtbox_PhoneNumber.Size = new Size(138, 23);
            txtbox_PhoneNumber.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 146);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 9;
            label3.Text = "Mail Adresi :";
            // 
            // txtbox_Email
            // 
            txtbox_Email.Location = new Point(142, 143);
            txtbox_Email.Name = "txtbox_Email";
            txtbox_Email.Size = new Size(138, 23);
            txtbox_Email.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 175);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 11;
            label4.Text = "Şifre :";
            // 
            // txtbox_Password
            // 
            txtbox_Password.Location = new Point(142, 172);
            txtbox_Password.Name = "txtbox_Password";
            txtbox_Password.Size = new Size(138, 23);
            txtbox_Password.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 204);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 13;
            label5.Text = "Şifre Tekrar :";
            // 
            // txtbox_PasswordCheck
            // 
            txtbox_PasswordCheck.Location = new Point(142, 201);
            txtbox_PasswordCheck.Name = "txtbox_PasswordCheck";
            txtbox_PasswordCheck.Size = new Size(138, 23);
            txtbox_PasswordCheck.TabIndex = 12;
            // 
            // btn_Register
            // 
            btn_Register.Location = new Point(128, 268);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(93, 35);
            btn_Register.TabIndex = 14;
            btn_Register.Text = "Kayıt Ol";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // label_RegisterError
            // 
            label_RegisterError.Location = new Point(12, 241);
            label_RegisterError.Name = "label_RegisterError";
            label_RegisterError.Size = new Size(320, 15);
            label_RegisterError.TabIndex = 15;
            label_RegisterError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtPicker_dob
            // 
            dtPicker_dob.Location = new Point(142, 85);
            dtPicker_dob.Name = "dtPicker_dob";
            dtPicker_dob.Size = new Size(138, 23);
            dtPicker_dob.TabIndex = 16;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(12, 12);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(75, 23);
            btn_Exit.TabIndex = 17;
            btn_Exit.Text = "Geri";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 329);
            Controls.Add(btn_Exit);
            Controls.Add(dtPicker_dob);
            Controls.Add(label_RegisterError);
            Controls.Add(btn_Register);
            Controls.Add(label5);
            Controls.Add(txtbox_PasswordCheck);
            Controls.Add(label4);
            Controls.Add(txtbox_Password);
            Controls.Add(label3);
            Controls.Add(txtbox_Email);
            Controls.Add(label2);
            Controls.Add(txtbox_PhoneNumber);
            Controls.Add(label1);
            Controls.Add(label_Surname);
            Controls.Add(txtbox_Surname);
            Controls.Add(label_Name);
            Controls.Add(txtbox_Name);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbox_Name;
        private Label label_Name;
        private Label label_Surname;
        private TextBox txtbox_Surname;
        private Label label1;
        private Label label2;
        private TextBox txtbox_PhoneNumber;
        private Label label3;
        private TextBox txtbox_Email;
        private Label label4;
        private TextBox txtbox_Password;
        private Label label5;
        private TextBox txtbox_PasswordCheck;
        private Button btn_Register;
        private Label label_RegisterError;
        private DateTimePicker dtPicker_dob;
        private Button btn_Exit;
    }
}