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
            this.teachersButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentsButton
            // 
            this.studentsButton.Location = new System.Drawing.Point(215, 12);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(166, 44);
            this.studentsButton.TabIndex = 8;
            this.studentsButton.Text = "Студенты";
            this.studentsButton.UseVisualStyleBackColor = true;
            this.studentsButton.Click += new System.EventHandler(this.studentsButton_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.Location = new System.Drawing.Point(418, 12);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(166, 44);
            this.usersBtn.TabIndex = 9;
            this.usersBtn.Text = "Пользователи";
            this.usersBtn.UseVisualStyleBackColor = true;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // teachersButton
            // 
            this.teachersButton.Location = new System.Drawing.Point(12, 12);
            this.teachersButton.Name = "teachersButton";
            this.teachersButton.Size = new System.Drawing.Size(166, 44);
            this.teachersButton.TabIndex = 7;
            this.teachersButton.Text = "Преподователи";
            this.teachersButton.UseVisualStyleBackColor = true;
            this.teachersButton.Click += new System.EventHandler(this.teachersButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(457, 441);
            this.backButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 44);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Выйти";
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
            this.ClientSize = new System.Drawing.Size(596, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.teachersButton);
            this.Controls.Add(this.usersBtn);
            this.Controls.Add(this.studentsButton);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AdminMenuForm";
            this.Text = "Админ-панель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.Button teachersButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
    }
}