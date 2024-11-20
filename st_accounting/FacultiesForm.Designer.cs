namespace st_accounting
{
    partial class FacultiesForm
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
            this.facultiesDataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.id_faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faculty_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // facultiesDataGridView
            // 
            this.facultiesDataGridView.AllowUserToAddRows = false;
            this.facultiesDataGridView.AllowUserToDeleteRows = false;
            this.facultiesDataGridView.AllowUserToResizeColumns = false;
            this.facultiesDataGridView.AllowUserToResizeRows = false;
            this.facultiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_faculty,
            this.faculty_name});
            this.facultiesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.facultiesDataGridView.Name = "facultiesDataGridView";
            this.facultiesDataGridView.ReadOnly = true;
            this.facultiesDataGridView.Size = new System.Drawing.Size(343, 491);
            this.facultiesDataGridView.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(373, 459);
            this.backButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(157, 44);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // id_faculty
            // 
            this.id_faculty.DataPropertyName = "id_faculty";
            this.id_faculty.HeaderText = "id_faculty";
            this.id_faculty.Name = "id_faculty";
            this.id_faculty.ReadOnly = true;
            this.id_faculty.Visible = false;
            // 
            // faculty_name
            // 
            this.faculty_name.DataPropertyName = "faculty_name";
            this.faculty_name.HeaderText = "Название факультета";
            this.faculty_name.Name = "faculty_name";
            this.faculty_name.ReadOnly = true;
            this.faculty_name.Width = 300;
            // 
            // FacultiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 518);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.facultiesDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FacultiesForm";
            this.Text = "FacultiesForm";
            ((System.ComponentModel.ISupportInitialize)(this.facultiesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView facultiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn faculty_name;
        private System.Windows.Forms.Button backButton;
    }
}