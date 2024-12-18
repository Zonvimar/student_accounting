namespace st_accounting
{
    partial class StudentWithGoodGrades
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
            this.exportButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.faculty_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.course,
            this.group_name,
            this.student_name});
            this.reportDataGridView.Location = new System.Drawing.Point(12, 12);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.ReadOnly = true;
            this.reportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportDataGridView.Size = new System.Drawing.Size(723, 420);
            this.reportDataGridView.TabIndex = 1;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(12, 438);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(210, 44);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Выгрузить отчет";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(609, 438);
            this.backButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 44);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // faculty_name
            // 
            this.faculty_name.DataPropertyName = "faculty_name";
            this.faculty_name.HeaderText = "Факультет";
            this.faculty_name.Name = "faculty_name";
            this.faculty_name.ReadOnly = true;
            this.faculty_name.Width = 200;
            // 
            // course
            // 
            this.course.DataPropertyName = "course";
            this.course.HeaderText = "Курс";
            this.course.Name = "course";
            this.course.ReadOnly = true;
            this.course.Width = 80;
            // 
            // group_name
            // 
            this.group_name.DataPropertyName = "group_name";
            this.group_name.HeaderText = "Номер группы";
            this.group_name.Name = "group_name";
            this.group_name.ReadOnly = true;
            // 
            // student_name
            // 
            this.student_name.DataPropertyName = "student_name";
            this.student_name.HeaderText = "Студент";
            this.student_name.Name = "student_name";
            this.student_name.ReadOnly = true;
            this.student_name.Width = 300;
            // 
            // StudentWithGoodGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 490);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.reportDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "StudentWithGoodGrades";
            this.Text = "StudentWithGoodGrades";
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn faculty_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_name;
    }
}