namespace app.user
{
    partial class HealthStatus
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
            dgv_HealthRecords = new DataGridView();
            label_Error = new Label();
            label11 = new Label();
            label12 = new Label();
            button2 = new Button();
            num_Height = new NumericUpDown();
            num_Weight = new NumericUpDown();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_HealthRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Height).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Weight).BeginInit();
            SuspendLayout();
            // 
            // dgv_HealthRecords
            // 
            dgv_HealthRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HealthRecords.Location = new Point(294, 12);
            dgv_HealthRecords.Name = "dgv_HealthRecords";
            dgv_HealthRecords.Size = new Size(372, 426);
            dgv_HealthRecords.TabIndex = 0;
            // 
            // label_Error
            // 
            label_Error.Location = new Point(12, 221);
            label_Error.Name = "label_Error";
            label_Error.Size = new Size(276, 25);
            label_Error.TabIndex = 51;
            label_Error.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(43, 187);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 46;
            label11.Text = "Kilo :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(43, 158);
            label12.Name = "label12";
            label12.Size = new Size(33, 15);
            label12.TabIndex = 44;
            label12.Text = "Boy :";
            // 
            // button2
            // 
            button2.Location = new Point(108, 258);
            button2.Name = "button2";
            button2.Size = new Size(89, 34);
            button2.TabIndex = 42;
            button2.Text = "Kayıt Girişi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // num_Height
            // 
            num_Height.Location = new Point(82, 156);
            num_Height.Maximum = new decimal(new int[] { 320, 0, 0, 0 });
            num_Height.Name = "num_Height";
            num_Height.Size = new Size(151, 23);
            num_Height.TabIndex = 52;
            // 
            // num_Weight
            // 
            num_Weight.Location = new Point(82, 185);
            num_Weight.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            num_Weight.Name = "num_Weight";
            num_Weight.Size = new Size(151, 23);
            num_Weight.TabIndex = 53;
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 54;
            button3.Text = "Ana Menü";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // HealthStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 450);
            Controls.Add(button3);
            Controls.Add(num_Weight);
            Controls.Add(num_Height);
            Controls.Add(label_Error);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(button2);
            Controls.Add(dgv_HealthRecords);
            Name = "HealthStatus";
            Text = "HealthStatus";
            Load += HealthStatus_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_HealthRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Height).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Weight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_HealthRecords;
        private Label label_Error;
        private Label label11;
        private Label label12;
        private Button button2;
        private NumericUpDown num_Height;
        private NumericUpDown num_Weight;
        private Button button3;
    }
}