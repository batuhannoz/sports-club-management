namespace app.admin.UsersProfiles
{
    partial class Users
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
            dgv_Users = new DataGridView();
            button3 = new Button();
            textBox_Search = new TextBox();
            btn_Search = new Button();
            cbox_Profiles = new ComboBox();
            label_AddressError = new Label();
            label_UserError = new Label();
            txtbox_Neighborhood = new TextBox();
            label9 = new Label();
            txtbox_Street = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtbox_District = new TextBox();
            label12 = new Label();
            txtbox_City = new TextBox();
            dtPicker_dob = new DateTimePicker();
            label4 = new Label();
            txtbox_Password = new TextBox();
            label3 = new Label();
            txtbox_Email = new TextBox();
            label6 = new Label();
            txtbox_PhoneNumber = new TextBox();
            label7 = new Label();
            label_Surname = new Label();
            txtbox_Surname = new TextBox();
            label_Name = new Label();
            txtbox_Name = new TextBox();
            btn_UpdateAddress = new Button();
            btn_UpdateUser = new Button();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            btn_InsertUser = new Button();
            lbl_InsertError = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Users).BeginInit();
            SuspendLayout();
            // 
            // dgv_Users
            // 
            dgv_Users.AllowUserToAddRows = false;
            dgv_Users.AllowUserToDeleteRows = false;
            dgv_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Users.Location = new Point(12, 41);
            dgv_Users.MultiSelect = false;
            dgv_Users.Name = "dgv_Users";
            dgv_Users.Size = new Size(823, 779);
            dgv_Users.TabIndex = 0;
            dgv_Users.SelectionChanged += dgv_Users_SelectionChanged;
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 44;
            button3.Text = "Ana Menü";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox_Search
            // 
            textBox_Search.Location = new Point(280, 12);
            textBox_Search.Name = "textBox_Search";
            textBox_Search.Size = new Size(219, 23);
            textBox_Search.TabIndex = 45;
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(505, 12);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(75, 23);
            btn_Search.TabIndex = 46;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // cbox_Profiles
            // 
            cbox_Profiles.FormattingEnabled = true;
            cbox_Profiles.Location = new Point(957, 273);
            cbox_Profiles.Name = "cbox_Profiles";
            cbox_Profiles.Size = new Size(159, 23);
            cbox_Profiles.TabIndex = 47;
            // 
            // label_AddressError
            // 
            label_AddressError.Location = new Point(1140, 309);
            label_AddressError.Name = "label_AddressError";
            label_AddressError.Size = new Size(302, 15);
            label_AddressError.TabIndex = 73;
            label_AddressError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_UserError
            // 
            label_UserError.Location = new Point(879, 309);
            label_UserError.Name = "label_UserError";
            label_UserError.Size = new Size(255, 15);
            label_UserError.TabIndex = 72;
            label_UserError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbox_Neighborhood
            // 
            txtbox_Neighborhood.Location = new Point(1227, 154);
            txtbox_Neighborhood.Name = "txtbox_Neighborhood";
            txtbox_Neighborhood.Size = new Size(159, 23);
            txtbox_Neighborhood.TabIndex = 71;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1177, 184);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 70;
            label9.Text = "Sokak :";
            // 
            // txtbox_Street
            // 
            txtbox_Street.Location = new Point(1227, 181);
            txtbox_Street.Name = "txtbox_Street";
            txtbox_Street.Size = new Size(159, 23);
            txtbox_Street.TabIndex = 69;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1166, 157);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 68;
            label10.Text = "Mahalle :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1190, 126);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 67;
            label11.Text = "İlçe :";
            // 
            // txtbox_District
            // 
            txtbox_District.Location = new Point(1227, 123);
            txtbox_District.Name = "txtbox_District";
            txtbox_District.Size = new Size(159, 23);
            txtbox_District.TabIndex = 66;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1202, 97);
            label12.Name = "label12";
            label12.Size = new Size(19, 15);
            label12.TabIndex = 65;
            label12.Text = "İl :";
            // 
            // txtbox_City
            // 
            txtbox_City.Location = new Point(1227, 94);
            txtbox_City.Name = "txtbox_City";
            txtbox_City.Size = new Size(159, 23);
            txtbox_City.TabIndex = 64;
            // 
            // dtPicker_dob
            // 
            dtPicker_dob.Location = new Point(957, 157);
            dtPicker_dob.Name = "dtPicker_dob";
            dtPicker_dob.Size = new Size(159, 23);
            dtPicker_dob.TabIndex = 63;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(915, 247);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 62;
            label4.Text = "Şifre :";
            // 
            // txtbox_Password
            // 
            txtbox_Password.Location = new Point(957, 244);
            txtbox_Password.Name = "txtbox_Password";
            txtbox_Password.Size = new Size(159, 23);
            txtbox_Password.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(879, 218);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 60;
            label3.Text = "Mail Adresi :";
            // 
            // txtbox_Email
            // 
            txtbox_Email.Location = new Point(957, 215);
            txtbox_Email.Name = "txtbox_Email";
            txtbox_Email.Size = new Size(159, 23);
            txtbox_Email.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(846, 189);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 58;
            label6.Text = "Telefon Numarası :";
            // 
            // txtbox_PhoneNumber
            // 
            txtbox_PhoneNumber.Location = new Point(957, 186);
            txtbox_PhoneNumber.Name = "txtbox_PhoneNumber";
            txtbox_PhoneNumber.Size = new Size(159, 23);
            txtbox_PhoneNumber.TabIndex = 57;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(867, 160);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 56;
            label7.Text = "Doğum Tarihi :";
            // 
            // label_Surname
            // 
            label_Surname.AutoSize = true;
            label_Surname.Location = new Point(897, 131);
            label_Surname.Name = "label_Surname";
            label_Surname.Size = new Size(54, 15);
            label_Surname.TabIndex = 55;
            label_Surname.Text = "Soyisim :";
            // 
            // txtbox_Surname
            // 
            txtbox_Surname.Location = new Point(957, 128);
            txtbox_Surname.Name = "txtbox_Surname";
            txtbox_Surname.Size = new Size(159, 23);
            txtbox_Surname.TabIndex = 54;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(916, 102);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(35, 15);
            label_Name.TabIndex = 53;
            label_Name.Text = "İsim :";
            // 
            // txtbox_Name
            // 
            txtbox_Name.Location = new Point(957, 99);
            txtbox_Name.Name = "txtbox_Name";
            txtbox_Name.Size = new Size(159, 23);
            txtbox_Name.TabIndex = 52;
            // 
            // btn_UpdateAddress
            // 
            btn_UpdateAddress.Location = new Point(1251, 346);
            btn_UpdateAddress.Name = "btn_UpdateAddress";
            btn_UpdateAddress.Size = new Size(107, 46);
            btn_UpdateAddress.TabIndex = 51;
            btn_UpdateAddress.Text = "Adress Bilgilerini Güncelle";
            btn_UpdateAddress.UseVisualStyleBackColor = true;
            btn_UpdateAddress.Click += btn_UpdateAddress_Click;
            // 
            // btn_UpdateUser
            // 
            btn_UpdateUser.Location = new Point(957, 346);
            btn_UpdateUser.Name = "btn_UpdateUser";
            btn_UpdateUser.Size = new Size(116, 46);
            btn_UpdateUser.TabIndex = 50;
            btn_UpdateUser.Text = "Kullanıcı bilgilerini Güncelle";
            btn_UpdateUser.UseVisualStyleBackColor = true;
            btn_UpdateUser.Click += btn_UpdateUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(1236, 41);
            label2.Name = "label2";
            label2.Size = new Size(139, 30);
            label2.TabIndex = 49;
            label2.Text = "Adres Bilgileri";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(953, 41);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 48;
            label1.Text = "Kullanıcı bilgileri";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(910, 276);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 74;
            label5.Text = "Profil :";
            // 
            // btn_InsertUser
            // 
            btn_InsertUser.Location = new Point(1114, 447);
            btn_InsertUser.Name = "btn_InsertUser";
            btn_InsertUser.Size = new Size(107, 46);
            btn_InsertUser.TabIndex = 75;
            btn_InsertUser.Text = "Yeni Kullanıcı Girişi";
            btn_InsertUser.UseVisualStyleBackColor = true;
            btn_InsertUser.Click += btn_InsertUser_Click;
            // 
            // lbl_InsertError
            // 
            lbl_InsertError.Location = new Point(1019, 419);
            lbl_InsertError.Name = "lbl_InsertError";
            lbl_InsertError.Size = new Size(302, 15);
            lbl_InsertError.TabIndex = 76;
            lbl_InsertError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 832);
            Controls.Add(lbl_InsertError);
            Controls.Add(btn_InsertUser);
            Controls.Add(label5);
            Controls.Add(label_AddressError);
            Controls.Add(label_UserError);
            Controls.Add(txtbox_Neighborhood);
            Controls.Add(label9);
            Controls.Add(txtbox_Street);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(txtbox_District);
            Controls.Add(label12);
            Controls.Add(txtbox_City);
            Controls.Add(dtPicker_dob);
            Controls.Add(label4);
            Controls.Add(txtbox_Password);
            Controls.Add(label3);
            Controls.Add(txtbox_Email);
            Controls.Add(label6);
            Controls.Add(txtbox_PhoneNumber);
            Controls.Add(label7);
            Controls.Add(label_Surname);
            Controls.Add(txtbox_Surname);
            Controls.Add(label_Name);
            Controls.Add(txtbox_Name);
            Controls.Add(btn_UpdateAddress);
            Controls.Add(btn_UpdateUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbox_Profiles);
            Controls.Add(btn_Search);
            Controls.Add(textBox_Search);
            Controls.Add(button3);
            Controls.Add(dgv_Users);
            Name = "Users";
            Text = "Users";
            Load += Users_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Users).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Users;
        private Button button3;
        private TextBox textBox_Search;
        private Button btn_Search;
        private ComboBox cbox_Profiles;
        private Label label_AddressError;
        private Label label_UserError;
        private TextBox txtbox_Neighborhood;
        private Label label9;
        private TextBox txtbox_Street;
        private Label label10;
        private Label label11;
        private TextBox txtbox_District;
        private Label label12;
        private TextBox txtbox_City;
        private DateTimePicker dtPicker_dob;
        private Label label4;
        private TextBox txtbox_Password;
        private Label label3;
        private TextBox txtbox_Email;
        private Label label6;
        private TextBox txtbox_PhoneNumber;
        private Label label7;
        private Label label_Surname;
        private TextBox txtbox_Surname;
        private Label label_Name;
        private TextBox txtbox_Name;
        private Button btn_UpdateAddress;
        private Button btn_UpdateUser;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button btn_InsertUser;
        private Label lbl_InsertError;
    }
}