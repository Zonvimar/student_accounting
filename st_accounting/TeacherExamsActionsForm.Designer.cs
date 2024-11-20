namespace st_accounting
{
    partial class TeacherExamsActionsForm
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
            this.labelTop = new System.Windows.Forms.Label();
            this.controlTypeCbx = new System.Windows.Forms.ComboBox();
            this.subjectsCbx = new System.Windows.Forms.ComboBox();
            this.studentsCbx = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gradeTbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.actionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.labelTop.Location = new System.Drawing.Point(61, 16);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(225, 35);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "Добавить экзамен";
            // 
            // controlTypeCbx
            // 
            this.controlTypeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlTypeCbx.FormattingEnabled = true;
            this.controlTypeCbx.Location = new System.Drawing.Point(14, 236);
            this.controlTypeCbx.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.controlTypeCbx.Name = "controlTypeCbx";
            this.controlTypeCbx.Size = new System.Drawing.Size(316, 33);
            this.controlTypeCbx.TabIndex = 3;
            // 
            // subjectsCbx
            // 
            this.subjectsCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectsCbx.FormattingEnabled = true;
            this.subjectsCbx.Location = new System.Drawing.Point(15, 166);
            this.subjectsCbx.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.subjectsCbx.Name = "subjectsCbx";
            this.subjectsCbx.Size = new System.Drawing.Size(316, 33);
            this.subjectsCbx.TabIndex = 2;
            // 
            // studentsCbx
            // 
            this.studentsCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentsCbx.FormattingEnabled = true;
            this.studentsCbx.Location = new System.Drawing.Point(14, 95);
            this.studentsCbx.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.studentsCbx.Name = "studentsCbx";
            this.studentsCbx.Size = new System.Drawing.Size(316, 33);
            this.studentsCbx.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(15, 301);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(315, 33);
            this.dateTimePicker.TabIndex = 4;
            // 
            // gradeTbx
            // 
            this.gradeTbx.Location = new System.Drawing.Point(15, 370);
            this.gradeTbx.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gradeTbx.MaxLength = 1;
            this.gradeTbx.Name = "gradeTbx";
            this.gradeTbx.Size = new System.Drawing.Size(316, 33);
            this.gradeTbx.TabIndex = 5;
            this.gradeTbx.TextChanged += new System.EventHandler(this.gradeTbx_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            this.label6.Location = new System.Drawing.Point(11, 347);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Оценка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            this.label5.Location = new System.Drawing.Point(11, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            this.label3.Location = new System.Drawing.Point(11, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Тип контроля";
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(15, 418);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(315, 46);
            this.actionButton.TabIndex = 6;
            this.actionButton.Text = "Добавить";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            this.label2.Location = new System.Drawing.Point(11, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Предмет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            this.label4.Location = new System.Drawing.Point(11, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Студент";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(15, 470);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(315, 36);
            this.backBtn.TabIndex = 32;
            this.backBtn.Text = "Отмена";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(82, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(117, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(47, 277);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "*";
            // 
            // TeacherExamsActionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 520);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.controlTypeCbx);
            this.Controls.Add(this.subjectsCbx);
            this.Controls.Add(this.studentsCbx);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.gradeTbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTop);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TeacherExamsActionsForm";
            this.Text = "Добавление/Изменение информации об экзамене";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.ComboBox controlTypeCbx;
        private System.Windows.Forms.ComboBox subjectsCbx;
        private System.Windows.Forms.ComboBox studentsCbx;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox gradeTbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}