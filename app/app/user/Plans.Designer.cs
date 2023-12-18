namespace app.user
{
    partial class Plans
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
            dgv_Plans = new DataGridView();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label9 = new Label();
            btn_Subscribe = new Button();
            lbl_SundayEnd = new Label();
            lbl_SundayStart = new Label();
            lbl_SaturdayEnd = new Label();
            lbl_SaturdayStart = new Label();
            lbl_FridayEnd = new Label();
            lbl_FridayStart = new Label();
            lbl_ThursdayEnd = new Label();
            lbl_ThursdayStart = new Label();
            lbl_WednesdayEnd = new Label();
            lbl_WednesdayStart = new Label();
            lbl_TuesdayEnd = new Label();
            lbl_TuesdayStart = new Label();
            lbl_MondayEnd = new Label();
            lbl_MondayStart = new Label();
            label5 = new Label();
            label6 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label7 = new Label();
            label8 = new Label();
            label13 = new Label();
            label14 = new Label();
            lbl_PlanType = new Label();
            lbl_PlanPrice = new Label();
            lbl_PlanDesc = new Label();
            lbl_PlanName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Plans).BeginInit();
            SuspendLayout();
            // 
            // dgv_Plans
            // 
            dgv_Plans.AllowUserToAddRows = false;
            dgv_Plans.AllowUserToDeleteRows = false;
            dgv_Plans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Plans.Location = new Point(544, 12);
            dgv_Plans.Name = "dgv_Plans";
            dgv_Plans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Plans.Size = new Size(474, 568);
            dgv_Plans.TabIndex = 0;
            dgv_Plans.SelectionChanged += dgv_Plans_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(169, 328);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Plan ismi :";
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 55;
            button3.Text = "Ana Menü";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(133, 352);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 56;
            label2.Text = "Plan Açıklaması :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(162, 406);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 57;
            label3.Text = "Plan Fiyatı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(169, 431);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 58;
            label4.Text = "Plan Tipi :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(196, 72);
            label9.Name = "label9";
            label9.Size = new Size(126, 30);
            label9.TabIndex = 63;
            label9.Text = "Plan Seçimi";
            // 
            // btn_Subscribe
            // 
            btn_Subscribe.Location = new Point(213, 510);
            btn_Subscribe.Name = "btn_Subscribe";
            btn_Subscribe.Size = new Size(93, 38);
            btn_Subscribe.TabIndex = 64;
            btn_Subscribe.Text = "Plana Abone Ol";
            btn_Subscribe.UseVisualStyleBackColor = true;
            btn_Subscribe.Click += btn_Subscribe_Click;
            // 
            // lbl_SundayEnd
            // 
            lbl_SundayEnd.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lbl_SundayEnd.Location = new Point(464, 250);
            lbl_SundayEnd.Name = "lbl_SundayEnd";
            lbl_SundayEnd.Size = new Size(70, 59);
            lbl_SundayEnd.TabIndex = 87;
            lbl_SundayEnd.Text = "Bitiş Saati";
            lbl_SundayEnd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_SundayStart
            // 
            lbl_SundayStart.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lbl_SundayStart.Location = new Point(464, 191);
            lbl_SundayStart.Name = "lbl_SundayStart";
            lbl_SundayStart.Size = new Size(70, 59);
            lbl_SundayStart.TabIndex = 86;
            lbl_SundayStart.Text = "Başlangıç Saati";
            lbl_SundayStart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_SaturdayEnd
            // 
            lbl_SaturdayEnd.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lbl_SaturdayEnd.Location = new Point(388, 250);
            lbl_SaturdayEnd.Name = "lbl_SaturdayEnd";
            lbl_SaturdayEnd.Size = new Size(70, 59);
            lbl_SaturdayEnd.TabIndex = 85;
            lbl_SaturdayEnd.Text = "Bitiş Saati";
            lbl_SaturdayEnd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_SaturdayStart
            // 
            lbl_SaturdayStart.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lbl_SaturdayStart.Location = new Point(388, 191);
            lbl_SaturdayStart.Name = "lbl_SaturdayStart";
            lbl_SaturdayStart.Size = new Size(70, 59);
            lbl_SaturdayStart.TabIndex = 84;
            lbl_SaturdayStart.Text = "Başlangıç Saati";
            lbl_SaturdayStart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_FridayEnd
            // 
            lbl_FridayEnd.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lbl_FridayEnd.Location = new Point(312, 250);
            lbl_FridayEnd.Name = "lbl_FridayEnd";
            lbl_FridayEnd.Size = new Size(70, 59);
            lbl_FridayEnd.TabIndex = 83;
            lbl_FridayEnd.Text = "Bitiş Saati";
            lbl_FridayEnd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_FridayStart
            // 
            lbl_FridayStart.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lbl_FridayStart.Location = new Point(312, 191);
            lbl_FridayStart.Name = "lbl_FridayStart";
            lbl_FridayStart.Size = new Size(70, 59);
            lbl_FridayStart.TabIndex = 82;
            lbl_FridayStart.Text = "Başlangıç Saati";
            lbl_FridayStart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_ThursdayEnd
            // 
            lbl_ThursdayEnd.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lbl_ThursdayEnd.Location = new Point(236, 250);
            lbl_ThursdayEnd.Name = "lbl_ThursdayEnd";
            lbl_ThursdayEnd.Size = new Size(70, 59);
            lbl_ThursdayEnd.TabIndex = 81;
            lbl_ThursdayEnd.Text = "Bitiş Saati";
            lbl_ThursdayEnd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_ThursdayStart
            // 
            lbl_ThursdayStart.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lbl_ThursdayStart.Location = new Point(236, 191);
            lbl_ThursdayStart.Name = "lbl_ThursdayStart";
            lbl_ThursdayStart.Size = new Size(70, 59);
            lbl_ThursdayStart.TabIndex = 80;
            lbl_ThursdayStart.Text = "Başlangıç Saati";
            lbl_ThursdayStart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_WednesdayEnd
            // 
            lbl_WednesdayEnd.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lbl_WednesdayEnd.Location = new Point(160, 250);
            lbl_WednesdayEnd.Name = "lbl_WednesdayEnd";
            lbl_WednesdayEnd.Size = new Size(70, 59);
            lbl_WednesdayEnd.TabIndex = 79;
            lbl_WednesdayEnd.Text = "Bitiş Saati";
            lbl_WednesdayEnd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_WednesdayStart
            // 
            lbl_WednesdayStart.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lbl_WednesdayStart.Location = new Point(160, 191);
            lbl_WednesdayStart.Name = "lbl_WednesdayStart";
            lbl_WednesdayStart.Size = new Size(70, 59);
            lbl_WednesdayStart.TabIndex = 78;
            lbl_WednesdayStart.Text = "Başlangıç Saati";
            lbl_WednesdayStart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_TuesdayEnd
            // 
            lbl_TuesdayEnd.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lbl_TuesdayEnd.Location = new Point(84, 250);
            lbl_TuesdayEnd.Name = "lbl_TuesdayEnd";
            lbl_TuesdayEnd.Size = new Size(70, 59);
            lbl_TuesdayEnd.TabIndex = 77;
            lbl_TuesdayEnd.Text = "Bitiş Saati";
            lbl_TuesdayEnd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_TuesdayStart
            // 
            lbl_TuesdayStart.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lbl_TuesdayStart.Location = new Point(84, 191);
            lbl_TuesdayStart.Name = "lbl_TuesdayStart";
            lbl_TuesdayStart.Size = new Size(70, 59);
            lbl_TuesdayStart.TabIndex = 76;
            lbl_TuesdayStart.Text = "Başlangıç Saati";
            lbl_TuesdayStart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_MondayEnd
            // 
            lbl_MondayEnd.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lbl_MondayEnd.Location = new Point(8, 250);
            lbl_MondayEnd.Name = "lbl_MondayEnd";
            lbl_MondayEnd.Size = new Size(70, 59);
            lbl_MondayEnd.TabIndex = 75;
            lbl_MondayEnd.Text = "Bitiş Saati";
            lbl_MondayEnd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_MondayStart
            // 
            lbl_MondayStart.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lbl_MondayStart.Location = new Point(8, 191);
            lbl_MondayStart.Name = "lbl_MondayStart";
            lbl_MondayStart.Size = new Size(70, 59);
            lbl_MondayStart.TabIndex = 74;
            lbl_MondayStart.Text = "Başlangıç Saati";
            lbl_MondayStart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            label5.Location = new Point(-151, 394);
            label5.Name = "label5";
            label5.Size = new Size(84, 59);
            label5.TabIndex = 73;
            label5.Text = "Bitiş Saati";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            label6.Location = new Point(-151, 335);
            label6.Name = "label6";
            label6.Size = new Size(84, 59);
            label6.TabIndex = 72;
            label6.Text = "Başlangıç Saati";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            label10.Location = new Point(464, 170);
            label10.Name = "label10";
            label10.Size = new Size(70, 21);
            label10.TabIndex = 71;
            label10.Text = "Pazar";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            label11.Location = new Point(388, 170);
            label11.Name = "label11";
            label11.Size = new Size(70, 21);
            label11.TabIndex = 70;
            label11.Text = "Cumartesi";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            label12.Location = new Point(312, 170);
            label12.Name = "label12";
            label12.Size = new Size(70, 21);
            label12.TabIndex = 69;
            label12.Text = "Cuma";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            label7.Location = new Point(236, 170);
            label7.Name = "label7";
            label7.Size = new Size(70, 21);
            label7.TabIndex = 68;
            label7.Text = "Perşembe";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            label8.Location = new Point(160, 170);
            label8.Name = "label8";
            label8.Size = new Size(70, 21);
            label8.TabIndex = 67;
            label8.Text = "Çarşamba";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            label13.Location = new Point(84, 170);
            label13.Name = "label13";
            label13.Size = new Size(70, 21);
            label13.TabIndex = 66;
            label13.Text = "Salı";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            label14.Location = new Point(8, 170);
            label14.Name = "label14";
            label14.Size = new Size(70, 21);
            label14.TabIndex = 65;
            label14.Text = "Pazartesi";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_PlanType
            // 
            lbl_PlanType.Location = new Point(236, 431);
            lbl_PlanType.Name = "lbl_PlanType";
            lbl_PlanType.Size = new Size(179, 15);
            lbl_PlanType.TabIndex = 62;
            lbl_PlanType.Text = "lbl_PlanType";
            // 
            // lbl_PlanPrice
            // 
            lbl_PlanPrice.Location = new Point(236, 406);
            lbl_PlanPrice.Name = "lbl_PlanPrice";
            lbl_PlanPrice.Size = new Size(179, 15);
            lbl_PlanPrice.TabIndex = 61;
            lbl_PlanPrice.Text = "lbl_PlanPrice";
            // 
            // lbl_PlanDesc
            // 
            lbl_PlanDesc.Location = new Point(236, 352);
            lbl_PlanDesc.Name = "lbl_PlanDesc";
            lbl_PlanDesc.Size = new Size(179, 43);
            lbl_PlanDesc.TabIndex = 60;
            lbl_PlanDesc.Text = "lbl_PlanDesc";
            // 
            // lbl_PlanName
            // 
            lbl_PlanName.Location = new Point(236, 328);
            lbl_PlanName.Name = "lbl_PlanName";
            lbl_PlanName.Size = new Size(179, 15);
            lbl_PlanName.TabIndex = 59;
            lbl_PlanName.Text = "lbl_PlanName";
            // 
            // Plans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 592);
            Controls.Add(lbl_SundayEnd);
            Controls.Add(lbl_SundayStart);
            Controls.Add(lbl_SaturdayEnd);
            Controls.Add(lbl_SaturdayStart);
            Controls.Add(lbl_FridayEnd);
            Controls.Add(lbl_FridayStart);
            Controls.Add(lbl_ThursdayEnd);
            Controls.Add(lbl_ThursdayStart);
            Controls.Add(lbl_WednesdayEnd);
            Controls.Add(lbl_WednesdayStart);
            Controls.Add(lbl_TuesdayEnd);
            Controls.Add(lbl_TuesdayStart);
            Controls.Add(lbl_MondayEnd);
            Controls.Add(lbl_MondayStart);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(btn_Subscribe);
            Controls.Add(label9);
            Controls.Add(lbl_PlanType);
            Controls.Add(lbl_PlanPrice);
            Controls.Add(lbl_PlanDesc);
            Controls.Add(lbl_PlanName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(dgv_Plans);
            Name = "Plans";
            Text = "Plans";
            Load += Plans_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Plans).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Plans;
        private Label label1;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label9;
        private Button btn_Subscribe;
        private Label lbl_SundayEnd;
        private Label lbl_SundayStart;
        private Label lbl_SaturdayEnd;
        private Label lbl_SaturdayStart;
        private Label lbl_FridayEnd;
        private Label lbl_FridayStart;
        private Label lbl_ThursdayEnd;
        private Label lbl_ThursdayStart;
        private Label lbl_WednesdayEnd;
        private Label lbl_WednesdayStart;
        private Label lbl_TuesdayEnd;
        private Label lbl_TuesdayStart;
        private Label lbl_MondayEnd;
        private Label lbl_MondayStart;
        private Label label5;
        private Label label6;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label7;
        private Label label8;
        private Label label13;
        private Label label14;
        private Label lbl_PlanType;
        private Label lbl_PlanPrice;
        private Label lbl_PlanDesc;
        private Label lbl_PlanName;
    }
}