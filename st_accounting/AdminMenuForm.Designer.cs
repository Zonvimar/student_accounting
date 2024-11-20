namespace st_accounting
{
    partial class AdminMenuForm
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
            this.studentsButton = new System.Windows.Forms.Button();
            this.usersBtn = new System.Windows.Forms.Button();
            this.facultiesButton = new System.Windows.Forms.Button();
            this.specialtiesButton = new System.Windows.Forms.Button();
            this.groupsButton = new System.Windows.Forms.Button();
            this.subjetsButton = new System.Windows.Forms.Button();
            this.teachersButton = new System.Windows.Forms.Button();
            this.controlTypesButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentsButton
            // 
            this.studentsButton.Location = new System.Drawing.Point(193, 66);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(166, 44);
            this.studentsButton.TabIndex = 8;
            this.studentsButton.Text = "Студенты";
            this.studentsButton.UseVisualStyleBackColor = true;
            // 
            // usersBtn
            // 
            this.usersBtn.Location = new System.Drawing.Point(676, 12);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(166, 44);
            this.usersBtn.TabIndex = 9;
            this.usersBtn.Text = "Пользователи";
            this.usersBtn.UseVisualStyleBackColor = true;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // facultiesButton
            // 
            this.facultiesButton.Location = new System.Drawing.Point(12, 12);
            this.facultiesButton.Name = "facultiesButton";
            this.facultiesButton.Size = new System.Drawing.Size(166, 44);
            this.facultiesButton.TabIndex = 1;
            this.facultiesButton.Text = "Факультеты";
            this.facultiesButton.UseVisualStyleBackColor = true;
            this.facultiesButton.Click += new System.EventHandler(this.facultiesButton_Click);
            // 
            // specialtiesButton
            // 
            this.specialtiesButton.Location = new System.Drawing.Point(12, 66);
            this.specialtiesButton.Name = "specialtiesButton";
            this.specialtiesButton.Size = new System.Drawing.Size(166, 44);
            this.specialtiesButton.TabIndex = 2;
            this.specialtiesButton.Text = "Специальности";
            this.specialtiesButton.UseVisualStyleBackColor = true;
            // 
            // groupsButton
            // 
            this.groupsButton.Location = new System.Drawing.Point(12, 120);
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.Size = new System.Drawing.Size(166, 44);
            this.groupsButton.TabIndex = 3;
            this.groupsButton.Text = "Группы";
            this.groupsButton.UseVisualStyleBackColor = true;
            // 
            // subjetsButton
            // 
            this.subjetsButton.Location = new System.Drawing.Point(12, 228);
            this.subjetsButton.Name = "subjetsButton";
            this.subjetsButton.Size = new System.Drawing.Size(166, 44);
            this.subjetsButton.TabIndex = 6;
            this.subjetsButton.Text = "Предметы";
            this.subjetsButton.UseVisualStyleBackColor = true;
            // 
            // teachersButton
            // 
            this.teachersButton.Location = new System.Drawing.Point(193, 12);
            this.teachersButton.Name = "teachersButton";
            this.teachersButton.Size = new System.Drawing.Size(166, 44);
            this.teachersButton.TabIndex = 7;
            this.teachersButton.Text = "Преподователи";
            this.teachersButton.UseVisualStyleBackColor = true;
            // 
            // controlTypesButton
            // 
            this.controlTypesButton.Location = new System.Drawing.Point(12, 174);
            this.controlTypesButton.Name = "controlTypesButton";
            this.controlTypesButton.Size = new System.Drawing.Size(166, 44);
            this.controlTypesButton.TabIndex = 5;
            this.controlTypesButton.Text = "Типы контроля";
            this.controlTypesButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(715, 441);
            this.backButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 44);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.label1.Location = new System.Drawing.Point(12, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Добро пожаловать в админ-панель!";
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.controlTypesButton);
            this.Controls.Add(this.teachersButton);
            this.Controls.Add(this.subjetsButton);
            this.Controls.Add(this.groupsButton);
            this.Controls.Add(this.specialtiesButton);
            this.Controls.Add(this.facultiesButton);
            this.Controls.Add(this.usersBtn);
            this.Controls.Add(this.studentsButton);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(870, 539);
            this.MinimumSize = new System.Drawing.Size(870, 539);
            this.Name = "AdminMenuForm";
            this.Text = "Админ-панель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.Button facultiesButton;
        private System.Windows.Forms.Button specialtiesButton;
        private System.Windows.Forms.Button groupsButton;
        private System.Windows.Forms.Button subjetsButton;
        private System.Windows.Forms.Button teachersButton;
        private System.Windows.Forms.Button controlTypesButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
    }
}