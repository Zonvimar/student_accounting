namespace st_accounting
{
    partial class AdminTeachersForm
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
            this.teachersGDV = new System.Windows.Forms.DataGridView();
            this.id_teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teachersGDV)).BeginInit();
            this.SuspendLayout();
            // 
            // teachersGDV
            // 
            this.teachersGDV.AllowUserToAddRows = false;
            this.teachersGDV.AllowUserToDeleteRows = false;
            this.teachersGDV.AllowUserToResizeColumns = false;
            this.teachersGDV.AllowUserToResizeRows = false;
            this.teachersGDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersGDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_teacher,
            this.full_name,
            this.email,
            this.phone});
            this.teachersGDV.Location = new System.Drawing.Point(12, 12);
            this.teachersGDV.Name = "teachersGDV";
            this.teachersGDV.ReadOnly = true;
            this.teachersGDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teachersGDV.Size = new System.Drawing.Size(844, 409);
            this.teachersGDV.TabIndex = 1;
            // 
            // id_teacher
            // 
            this.id_teacher.DataPropertyName = "id_teacher";
            this.id_teacher.HeaderText = "id_teacher";
            this.id_teacher.Name = "id_teacher";
            this.id_teacher.ReadOnly = true;
            this.id_teacher.Visible = false;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "ФИО";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            this.full_name.Width = 300;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Электронная почта";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 250;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Телефон";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 250;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(731, 430);
            this.backButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 44);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(158, 430);
            this.editBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(136, 44);
            this.editBtn.TabIndex = 14;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 430);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 44);
            this.addBtn.TabIndex = 15;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AdminTeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 489);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.teachersGDV);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AdminTeachersForm";
            this.Text = "Преподователи";
            ((System.ComponentModel.ISupportInitialize)(this.teachersGDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView teachersGDV;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
    }
}