namespace st_accounting
{
    partial class AdminUsersActionForm
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
            this.loginTbx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.roleCbx = new System.Windows.Forms.ComboBox();
            this.entityCbx = new System.Windows.Forms.ComboBox();
            this.passwordTbx = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.actionBtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelTop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTbx
            // 
            this.loginTbx.Location = new System.Drawing.Point(16, 83);
            this.loginTbx.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.loginTbx.MaxLength = 20;
            this.loginTbx.Name = "loginTbx";
            this.loginTbx.Size = new System.Drawing.Size(316, 33);
            this.loginTbx.TabIndex = 87;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(58, 271);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 19);
            this.label11.TabIndex = 86;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(74, 125);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 19);
            this.label12.TabIndex = 85;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(62, 54);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 19);
            this.label13.TabIndex = 84;
            this.label13.Text = "*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 36);
            this.button1.TabIndex = 83;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roleCbx
            // 
            this.roleCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCbx.FormattingEnabled = true;
            this.roleCbx.Location = new System.Drawing.Point(16, 225);
            this.roleCbx.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.roleCbx.Name = "roleCbx";
            this.roleCbx.Size = new System.Drawing.Size(316, 33);
            this.roleCbx.TabIndex = 76;
            this.roleCbx.SelectedIndexChanged += new System.EventHandler(this.roleCbx_SelectedIndexChanged_1);
            // 
            // entityCbx
            // 
            this.entityCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entityCbx.FormattingEnabled = true;
            this.entityCbx.Location = new System.Drawing.Point(17, 298);
            this.entityCbx.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.entityCbx.Name = "entityCbx";
            this.entityCbx.Size = new System.Drawing.Size(316, 33);
            this.entityCbx.TabIndex = 75;
            // 
            // passwordTbx
            // 
            this.passwordTbx.Location = new System.Drawing.Point(16, 154);
            this.passwordTbx.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.passwordTbx.MaxLength = 255;
            this.passwordTbx.Name = "passwordTbx";
            this.passwordTbx.Size = new System.Drawing.Size(316, 33);
            this.passwordTbx.TabIndex = 77;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            this.label14.Location = new System.Drawing.Point(13, 269);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 23);
            this.label14.TabIndex = 82;
            this.label14.Text = "Лицо";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            this.label15.Location = new System.Drawing.Point(13, 196);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 23);
            this.label15.TabIndex = 81;
            this.label15.Text = "Роль";
            // 
            // actionBtn
            // 
            this.actionBtn.Location = new System.Drawing.Point(16, 350);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(315, 46);
            this.actionBtn.TabIndex = 78;
            this.actionBtn.Text = "Добавить";
            this.actionBtn.UseVisualStyleBackColor = true;
            this.actionBtn.Click += new System.EventHandler(this.actionBtn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            this.label16.Location = new System.Drawing.Point(13, 125);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 23);
            this.label16.TabIndex = 80;
            this.label16.Text = "Пароль";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            this.label17.Location = new System.Drawing.Point(13, 54);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 23);
            this.label17.TabIndex = 79;
            this.label17.Text = "Логин";
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.labelTop.Location = new System.Drawing.Point(29, 9);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(288, 35);
            this.labelTop.TabIndex = 74;
            this.labelTop.Text = "Добавить пользователя";
            // 
            // AdminUsersActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 448);
            this.Controls.Add(this.loginTbx);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roleCbx);
            this.Controls.Add(this.entityCbx);
            this.Controls.Add(this.passwordTbx);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.labelTop);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AdminUsersActionForm";
            this.Text = "Добавление/Изменение пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox loginTbx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox roleCbx;
        private System.Windows.Forms.ComboBox entityCbx;
        private System.Windows.Forms.TextBox passwordTbx;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelTop;
    }
}