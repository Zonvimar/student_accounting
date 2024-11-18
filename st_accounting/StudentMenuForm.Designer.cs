namespace st_accounting
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
            this.examsGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.labelHi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.examsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // examsGridView
            // 
            this.examsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examsGridView.Location = new System.Drawing.Point(14, 15);
            this.examsGridView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.examsGridView.Name = "examsGridView";
            this.examsGridView.Size = new System.Drawing.Size(826, 417);
            this.examsGridView.TabIndex = 0;
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
            // StudentMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 500);
            this.Controls.Add(this.labelHi);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.examsGridView);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(870, 539);
            this.MinimumSize = new System.Drawing.Size(870, 539);
            this.Name = "StudentMenuForm";
            this.Text = "Экзамены";
            ((System.ComponentModel.ISupportInitialize)(this.examsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView examsGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label labelHi;
    }
}