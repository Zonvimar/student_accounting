namespace st_accounting
{
    partial class StudentsWithBadGradesForm
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
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.faculty_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialty_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.AllowUserToAddRows = false;
            this.reportDataGridView.AllowUserToDeleteRows = false;
            this.reportDataGridView.AllowUserToResizeColumns = false;
            this.reportDataGridView.AllowUserToResizeRows = false;
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faculty_name,
            this.specialty_name,
            this.course,
            this.group_number,
            this.full_name,
            this.grade_count});
            this.reportDataGridView.Location = new System.Drawing.Point(12, 12);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.ReadOnly = true;
            this.reportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportDataGridView.Size = new System.Drawing.Size(1003, 420);
            this.reportDataGridView.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(890, 441);
            this.backButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 44);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(12, 441);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(210, 44);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Выгрузить отчет";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // faculty_name
            // 
            this.faculty_name.DataPropertyName = "faculty_name";
            this.faculty_name.HeaderText = "Факультет";
            this.faculty_name.Name = "faculty_name";
            this.faculty_name.ReadOnly = true;
            this.faculty_name.Width = 200;
            // 
            // specialty_name
            // 
            this.specialty_name.DataPropertyName = "specialty_name";
            this.specialty_name.HeaderText = "Специальность";
            this.specialty_name.Name = "specialty_name";
            this.specialty_name.ReadOnly = true;
            this.specialty_name.Width = 200;
            // 
            // course
            // 
            this.course.DataPropertyName = "course";
            this.course.HeaderText = "Курс";
            this.course.Name = "course";
            this.course.ReadOnly = true;
            this.course.Width = 80;
            // 
            // group_number
            // 
            this.group_number.DataPropertyName = "group_number";
            this.group_number.HeaderText = "Номер группы";
            this.group_number.Name = "group_number";
            this.group_number.ReadOnly = true;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "Студент";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            this.full_name.Width = 300;
            // 
            // grade_count
            // 
            this.grade_count.DataPropertyName = "grade_count";
            this.grade_count.HeaderText = "Кол-во двоек";
            this.grade_count.Name = "grade_count";
            this.grade_count.ReadOnly = true;
            this.grade_count.Width = 80;
            // 
            // StudentsWithBadGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 500);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.reportDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "StudentsWithBadGradesForm";
            this.Text = "Список студентов имеющих двойки";
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn faculty_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialty_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade_count;
        private System.Windows.Forms.Button exportButton;
    }
}