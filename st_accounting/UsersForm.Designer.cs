namespace st_accounting
{
    partial class UsersForm
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
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.id_entrance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_entity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_last_login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.AllowUserToResizeColumns = false;
            this.usersDataGridView.AllowUserToResizeRows = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_entrance,
            this.id_entity,
            this.login,
            this.password,
            this.role_name,
            this.id_role,
            this.date_last_login});
            this.usersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDataGridView.Size = new System.Drawing.Size(844, 409);
            this.usersDataGridView.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(731, 430);
            this.backButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 44);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(14, 430);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 44);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(160, 430);
            this.editBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(136, 44);
            this.editBtn.TabIndex = 13;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // id_entrance
            // 
            this.id_entrance.DataPropertyName = "id_entrance";
            this.id_entrance.HeaderText = "id_entrance";
            this.id_entrance.Name = "id_entrance";
            this.id_entrance.ReadOnly = true;
            this.id_entrance.Visible = false;
            // 
            // id_entity
            // 
            this.id_entity.DataPropertyName = "id_entity";
            this.id_entity.HeaderText = "id_entity";
            this.id_entity.Name = "id_entity";
            this.id_entity.ReadOnly = true;
            this.id_entity.Visible = false;
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Логин";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Width = 200;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Пароль";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Width = 200;
            // 
            // role_name
            // 
            this.role_name.DataPropertyName = "role_name";
            this.role_name.HeaderText = "Роль";
            this.role_name.Name = "role_name";
            this.role_name.ReadOnly = true;
            this.role_name.Width = 200;
            // 
            // id_role
            // 
            this.id_role.DataPropertyName = "id_role";
            this.id_role.HeaderText = "id_role";
            this.id_role.Name = "id_role";
            this.id_role.ReadOnly = true;
            this.id_role.Visible = false;
            // 
            // date_last_login
            // 
            this.date_last_login.DataPropertyName = "date_last_login";
            this.date_last_login.HeaderText = "Дата входа";
            this.date_last_login.Name = "date_last_login";
            this.date_last_login.ReadOnly = true;
            this.date_last_login.Width = 200;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 489);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.usersDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UsersForm";
            this.Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_entrance;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_entity;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn role_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_last_login;
    }
}