﻿namespace st_accounting
{
    partial class StudentMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMenuForm));
            this.examsGridView = new System.Windows.Forms.DataGridView();
            this.id_exam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.control_type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            this.labelHi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
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
            this.subject_name,
            this.control_type_name,
            this.date,
            this.grade});
            this.examsGridView.Location = new System.Drawing.Point(14, 42);
            this.examsGridView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.examsGridView.Name = "examsGridView";
            this.examsGridView.ReadOnly = true;
            this.examsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.examsGridView.Size = new System.Drawing.Size(826, 390);
            this.examsGridView.TabIndex = 0;
            this.examsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.examsGridView_CellContentClick);
            // 
            // id_exam
            // 
            this.id_exam.DataPropertyName = "id_exam";
            this.id_exam.HeaderText = "id_exam";
            this.id_exam.Name = "id_exam";
            this.id_exam.ReadOnly = true;
            this.id_exam.Visible = false;
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
            this.backButton.Location = new System.Drawing.Point(715, 444);
            this.backButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 44);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // labelHi
            // 
            this.labelHi.AutoSize = true;
            this.labelHi.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.labelHi.Location = new System.Drawing.Point(12, 455);
            this.labelHi.Name = "labelHi";
            this.labelHi.Size = new System.Drawing.Size(0, 25);
            this.labelHi.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Список ваших экзаменов:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(619, 9);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(204, 25);
            this.labelCount.TabIndex = 16;
            this.labelCount.Text = "Количество экзаменов:";
            // 
            // StudentMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 500);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHi);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.examsGridView);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(870, 539);
            this.MinimumSize = new System.Drawing.Size(870, 539);
            this.Name = "StudentMenuForm";
            this.Text = "Экзамены";
            this.Load += new System.EventHandler(this.StudentMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView examsGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label labelHi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_exam;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn control_type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCount;
    }
}