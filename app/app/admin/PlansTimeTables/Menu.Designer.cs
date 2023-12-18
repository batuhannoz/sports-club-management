namespace app.admin.PlansTimeTables
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
            btn_Update = new Button();
            btn_Create = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 42;
            button3.Text = "Ana Menü";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(57, 60);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(93, 41);
            btn_Update.TabIndex = 43;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Create
            // 
            btn_Create.Location = new Point(187, 60);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(93, 41);
            btn_Create.TabIndex = 44;
            btn_Create.Text = "Create";
            btn_Create.UseVisualStyleBackColor = true;
            btn_Create.Click += btn_Create_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 149);
            Controls.Add(btn_Create);
            Controls.Add(btn_Update);
            Controls.Add(button3);
            Name = "Menu";
            Text = "PlanTimeTablesMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button btn_Update;
        private Button btn_Create;
    }
}