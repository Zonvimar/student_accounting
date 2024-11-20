namespace st_accounting
{
    partial class TeacherExamsForm
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
            this.examsGridView = new System.Windows.Forms.DataGridView();
            this.id_exam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.control_type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            this.allExamsBtn = new System.Windows.Forms.Button();
            this.studentsCbx = new System.Windows.Forms.ComboBox();
            this.searchExamsBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.examsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // examsGridView
            // 
            this.examsGridView.AllowUserToAddRows = false;
            this.examsGridView.AllowUserToDeleteRows = false;
            this.examsGridView.AllowUserToResizeColumns = false;
            this.examsGridView.AllowUserToResizeRows = false;
            this.examsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_exam,
            this.full_name,
            this.subject_name,
            this.control_type_name,
            this.date,
            this.grade});
            this.examsGridView.Location = new System.Drawing.Point(14, 60);
            this.examsGridView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.examsGridView.Name = "examsGridView";
            this.examsGridView.ReadOnly = true;
            this.examsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.examsGridView.Size = new System.Drawing.Size(1128, 390);
            this.examsGridView.TabIndex = 1;
            // 
            // id_exam
            // 
            this.id_exam.DataPropertyName = "id_exam";
            this.id_exam.HeaderText = "id_exam";
            this.id_exam.Name = "id_exam";
            this.id_exam.ReadOnly = true;
            this.id_exam.Visible = false;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "Имя студента";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            this.full_name.Width = 300;
            // 
            // subject_name
            // 
            this.subject_name.DataPropertyName = "subject_name";
            this.subject_name.HeaderText = "Предмет";
            this.subject_name.Name = "subject_name";
            this.subject_name.ReadOnly = true;
            this.subject_name.Width = 400;
            // 
            // control_type_name
            // 
            this.control_type_name.DataPropertyName = "control_type_name";
            this.control_type_name.HeaderText = "Тип контроля";
            this.control_type_name.Name = "control_type_name";
            this.control_type_name.ReadOnly = true;
            this.control_type_name.Width = 150;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 133;
            // 
            // grade
            // 
            this.grade.DataPropertyName = "grade";
            this.grade.HeaderText = "Оценка";
            this.grade.Name = "grade";
            this.grade.ReadOnly = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(1017, 462);
            this.backButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 44);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // allExamsBtn
            // 
            this.allExamsBtn.Location = new System.Drawing.Point(928, 15);
            this.allExamsBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.allExamsBtn.Name = "allExamsBtn";
            this.allExamsBtn.Size = new System.Drawing.Size(214, 33);
            this.allExamsBtn.TabIndex = 7;
            this.allExamsBtn.Text = "Показать все экзамены";
            this.allExamsBtn.UseVisualStyleBackColor = true;
            this.allExamsBtn.Click += new System.EventHandler(this.allExamsBtn_Click);
            // 
            // studentsCbx
            // 
            this.studentsCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentsCbx.FormattingEnabled = true;
            this.studentsCbx.Location = new System.Drawing.Point(14, 15);
            this.studentsCbx.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.studentsCbx.Name = "studentsCbx";
            this.studentsCbx.Size = new System.Drawing.Size(355, 33);
            this.studentsCbx.TabIndex = 8;
            // 
            // searchExamsBtn
            // 
            this.searchExamsBtn.Location = new System.Drawing.Point(379, 15);
            this.searchExamsBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.searchExamsBtn.Name = "searchExamsBtn";
            this.searchExamsBtn.Size = new System.Drawing.Size(130, 33);
            this.searchExamsBtn.TabIndex = 9;
            this.searchExamsBtn.Text = "Найти";
            this.searchExamsBtn.UseVisualStyleBackColor = true;
            this.searchExamsBtn.Click += new System.EventHandler(this.searchExamsBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(14, 462);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 44);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(160, 462);
            this.editBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(136, 44);
            this.editBtn.TabIndex = 11;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(306, 462);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(136, 44);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // TeacherExamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 521);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchExamsBtn);
            this.Controls.Add(this.studentsCbx);
            this.Controls.Add(this.allExamsBtn);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.examsGridView);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TeacherExamsForm";
            this.Text = "Экзамены";
            ((System.ComponentModel.ISupportInitialize)(this.examsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView examsGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button allExamsBtn;
        private System.Windows.Forms.ComboBox studentsCbx;
        private System.Windows.Forms.Button searchExamsBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_exam;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn control_type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}