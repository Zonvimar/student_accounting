namespace st_accounting
{
    partial class AdminStudentsForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.studentsDGV = new System.Windows.Forms.DataGridView();
            this.id_student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_id_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(13, 546);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 44);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(159, 546);
            this.editBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(136, 44);
            this.editBtn.TabIndex = 17;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(1194, 546);
            this.backButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 44);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // studentsDGV
            // 
            this.studentsDGV.AllowUserToAddRows = false;
            this.studentsDGV.AllowUserToDeleteRows = false;
            this.studentsDGV.AllowUserToResizeColumns = false;
            this.studentsDGV.AllowUserToResizeRows = false;
            this.studentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_student,
            this.student_id_number,
            this.full_name,
            this.sex,
            this.date_birth,
            this.id_group,
            this.group_number,
            this.course});
            this.studentsDGV.Location = new System.Drawing.Point(13, 15);
            this.studentsDGV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.studentsDGV.Name = "studentsDGV";
            this.studentsDGV.ReadOnly = true;
            this.studentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsDGV.Size = new System.Drawing.Size(1306, 519);
            this.studentsDGV.TabIndex = 20;
            // 
            // id_student
            // 
            this.id_student.DataPropertyName = "id_student";
            this.id_student.HeaderText = "id_student";
            this.id_student.Name = "id_student";
            this.id_student.ReadOnly = true;
            this.id_student.Visible = false;
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
            // id_group
            // 
            this.id_group.DataPropertyName = "id_group";
            this.id_group.HeaderText = "id_group";
            this.id_group.Name = "id_group";
            this.id_group.ReadOnly = true;
            this.id_group.Visible = false;
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
            // AdminStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 600);
            this.Controls.Add(this.studentsDGV);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AdminStudentsForm";
            this.Text = "Студенты";
            ((System.ComponentModel.ISupportInitialize)(this.studentsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView studentsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
    }
}