using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st_accounting
{
    public partial class StudentsWithBadGradesForm : Form
    {
        public StudentsWithBadGradesForm()
        {
            InitializeComponent();
            LoadReport();
        }

        private void LoadReport()
        {
            Student_Class.getStudentsWithBadGrades();
            reportDataGridView.DataSource = Student_Class.dtStudents;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherMenuForm teacherMenuForm = new TeacherMenuForm();
            teacherMenuForm.Show();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (reportDataGridView.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    StringBuilder sb = new StringBuilder();

                    string[] headers = { "Факультет", "Специальность", "Курс", "Группа", "ФИО студента", "Количество двоек" };
                    sb.AppendLine(string.Join(", ", headers));

                    for (int i = 0; i < reportDataGridView.Rows.Count; i++)
                    {
                        List<string> rowValues = new List<string>();
                        for (int j = 0; j < reportDataGridView.Columns.Count; j++)
                        {
                            var value = reportDataGridView.Rows[i].Cells[j].Value;
                            rowValues.Add(value != null ? value.ToString() : string.Empty);
                        }
                        sb.AppendLine(string.Join(", ", rowValues));
                    }

                    System.IO.File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Данные успешно выгружены.", "Информация");
                }
            }
            else
            {
                MessageBox.Show("Нет данных для выгрузки.", "Информация");
            }
        }
    }
}
