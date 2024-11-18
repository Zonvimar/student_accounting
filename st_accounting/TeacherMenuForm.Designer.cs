namespace st_accounting
{
    partial class TeacherMenuForm
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
            this.examsButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.labelHi = new System.Windows.Forms.Label();
            this.subjectsTeacherGriedView = new System.Windows.Forms.DataGridView();
            this.labelSubjects = new System.Windows.Forms.Label();
            this.subject_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsTeacherGriedView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsButton
            // 
            this.studentsButton.Location = new System.Drawing.Point(12, 37);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(210, 44);
            this.studentsButton.TabIndex = 0;
            this.studentsButton.Text = "Студенты";
            this.studentsButton.UseVisualStyleBackColor = true;
            // 
            // examsButton
            // 
            this.examsButton.Location = new System.Drawing.Point(235, 37);
            this.examsButton.Name = "examsButton";
            this.examsButton.Size = new System.Drawing.Size(210, 44);
            this.examsButton.TabIndex = 1;
            this.examsButton.Text = "Экзамены";
            this.examsButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(715, 441);
            this.backButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 44);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // labelHi
            // 
            this.labelHi.AutoSize = true;
            this.labelHi.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.labelHi.Location = new System.Drawing.Point(12, 454);
            this.labelHi.Name = "labelHi";
            this.labelHi.Size = new System.Drawing.Size(327, 25);
            this.labelHi.TabIndex = 13;
            this.labelHi.Text = "Добро пожаловать в кабинет учителя!";
            // 
            // subjectsTeacherGriedView
            // 
            this.subjectsTeacherGriedView.AllowUserToAddRows = false;
            this.subjectsTeacherGriedView.AllowUserToDeleteRows = false;
            this.subjectsTeacherGriedView.AllowUserToResizeColumns = false;
            this.subjectsTeacherGriedView.AllowUserToResizeRows = false;
            this.subjectsTeacherGriedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsTeacherGriedView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject_name});
            this.subjectsTeacherGriedView.Location = new System.Drawing.Point(451, 37);
            this.subjectsTeacherGriedView.MultiSelect = false;
            this.subjectsTeacherGriedView.Name = "subjectsTeacherGriedView";
            this.subjectsTeacherGriedView.ReadOnly = true;
            this.subjectsTeacherGriedView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectsTeacherGriedView.Size = new System.Drawing.Size(393, 395);
            this.subjectsTeacherGriedView.TabIndex = 14;
            // 
            // labelSubjects
            // 
            this.labelSubjects.AutoSize = true;
            this.labelSubjects.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.labelSubjects.Location = new System.Drawing.Point(446, 9);
            this.labelSubjects.Name = "labelSubjects";
            this.labelSubjects.Size = new System.Drawing.Size(259, 25);
            this.labelSubjects.TabIndex = 15;
            this.labelSubjects.Text = "Предметы которые вы ведете:";
            this.labelSubjects.Click += new System.EventHandler(this.label1_Click);
            // 
            // subject_name
            // 
            this.subject_name.DataPropertyName = "subject_name";
            this.subject_name.HeaderText = "Наименование";
            this.subject_name.Name = "subject_name";
            this.subject_name.Width = 350;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(433, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Студенты представленные на стипендию";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(433, 44);
            this.button2.TabIndex = 17;
            this.button2.Text = "Студенты имеющие двойки";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TeacherMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 500);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSubjects);
            this.Controls.Add(this.subjectsTeacherGriedView);
            this.Controls.Add(this.labelHi);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.examsButton);
            this.Controls.Add(this.studentsButton);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(870, 539);
            this.MinimumSize = new System.Drawing.Size(870, 539);
            this.Name = "TeacherMenuForm";
            this.Text = "Преподавательская";
            ((System.ComponentModel.ISupportInitialize)(this.subjectsTeacherGriedView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.Button examsButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label labelHi;
        private System.Windows.Forms.DataGridView subjectsTeacherGriedView;
        private System.Windows.Forms.Label labelSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}