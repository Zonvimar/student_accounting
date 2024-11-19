namespace st_accounting
{
    partial class TeacherStudentsForm
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
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.facultiesCbx = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.specialtiesCbx = new System.Windows.Forms.ComboBox();
            this.groupsCbx = new System.Windows.Forms.ComboBox();
            this.allStudentsBtn = new System.Windows.Forms.Button();
            this.student_id_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchStudentsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AllowUserToAddRows = false;
            this.studentsDataGridView.AllowUserToDeleteRows = false;
            this.studentsDataGridView.AllowUserToResizeColumns = false;
            this.studentsDataGridView.AllowUserToResizeRows = false;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_id_number,
            this.full_name,
            this.sex,
            this.date_birth,
            this.group_number,
            this.course});
            this.studentsDataGridView.Location = new System.Drawing.Point(13, 60);
            this.studentsDataGridView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.ReadOnly = true;
            this.studentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsDataGridView.Size = new System.Drawing.Size(1306, 519);
            this.studentsDataGridView.TabIndex = 0;
            // 
            // facultiesCbx
            // 
            this.facultiesCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultiesCbx.FormattingEnabled = true;
            this.facultiesCbx.Location = new System.Drawing.Point(14, 15);
            this.facultiesCbx.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.facultiesCbx.Name = "facultiesCbx";
            this.facultiesCbx.Size = new System.Drawing.Size(265, 33);
            this.facultiesCbx.TabIndex = 1;
            this.facultiesCbx.SelectedIndexChanged += new System.EventHandler(this.facultiesCbx_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(1194, 597);
            this.backButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 44);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // specialtiesCbx
            // 
            this.specialtiesCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialtiesCbx.FormattingEnabled = true;
            this.specialtiesCbx.Location = new System.Drawing.Point(288, 15);
            this.specialtiesCbx.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.specialtiesCbx.Name = "specialtiesCbx";
            this.specialtiesCbx.Size = new System.Drawing.Size(265, 33);
            this.specialtiesCbx.TabIndex = 4;
            this.specialtiesCbx.SelectedIndexChanged += new System.EventHandler(this.specialtiesCbx_SelectedIndexChanged);
            // 
            // groupsCbx
            // 
            this.groupsCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupsCbx.FormattingEnabled = true;
            this.groupsCbx.Location = new System.Drawing.Point(563, 15);
            this.groupsCbx.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupsCbx.Name = "groupsCbx";
            this.groupsCbx.Size = new System.Drawing.Size(265, 33);
            this.groupsCbx.TabIndex = 5;
            // 
            // allStudentsBtn
            // 
            this.allStudentsBtn.Location = new System.Drawing.Point(1077, 15);
            this.allStudentsBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.allStudentsBtn.Name = "allStudentsBtn";
            this.allStudentsBtn.Size = new System.Drawing.Size(242, 33);
            this.allStudentsBtn.TabIndex = 6;
            this.allStudentsBtn.Text = "Показать всех студентов";
            this.allStudentsBtn.UseVisualStyleBackColor = true;
            this.allStudentsBtn.Click += new System.EventHandler(this.allStudentsBtn_Click);
            // 
            // student_id_number
            // 
            this.student_id_number.DataPropertyName = "student_id_number";
            this.student_id_number.HeaderText = "Номер студ. билета";
            this.student_id_number.Name = "student_id_number";
            this.student_id_number.ReadOnly = true;
            this.student_id_number.Width = 250;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "Полное имя";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            this.full_name.Width = 300;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "Пол";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Width = 110;
            // 
            // date_birth
            // 
            this.date_birth.DataPropertyName = "date_birth";
            this.date_birth.HeaderText = "Дата рождения";
            this.date_birth.Name = "date_birth";
            this.date_birth.ReadOnly = true;
            this.date_birth.Width = 200;
            // 
            // group_number
            // 
            this.group_number.DataPropertyName = "group_number";
            this.group_number.HeaderText = "Номер группы";
            this.group_number.Name = "group_number";
            this.group_number.ReadOnly = true;
            this.group_number.Width = 200;
            // 
            // course
            // 
            this.course.DataPropertyName = "course";
            this.course.HeaderText = "Курс";
            this.course.Name = "course";
            this.course.ReadOnly = true;
            this.course.Width = 200;
            // 
            // searchStudentsBtn
            // 
            this.searchStudentsBtn.Location = new System.Drawing.Point(838, 15);
            this.searchStudentsBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.searchStudentsBtn.Name = "searchStudentsBtn";
            this.searchStudentsBtn.Size = new System.Drawing.Size(130, 33);
            this.searchStudentsBtn.TabIndex = 7;
            this.searchStudentsBtn.Text = "Найти";
            this.searchStudentsBtn.UseVisualStyleBackColor = true;
            this.searchStudentsBtn.Click += new System.EventHandler(this.searchStudentsBtn_Click);
            // 
            // TeacherStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 656);
            this.Controls.Add(this.searchStudentsBtn);
            this.Controls.Add(this.allStudentsBtn);
            this.Controls.Add(this.groupsCbx);
            this.Controls.Add(this.specialtiesCbx);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.facultiesCbx);
            this.Controls.Add(this.studentsDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TeacherStudentsForm";
            this.Text = "TeacherStudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.ComboBox facultiesCbx;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox specialtiesCbx;
        private System.Windows.Forms.ComboBox groupsCbx;
        private System.Windows.Forms.Button allStudentsBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private System.Windows.Forms.Button searchStudentsBtn;
    }
}