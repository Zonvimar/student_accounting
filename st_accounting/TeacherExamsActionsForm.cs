using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace st_accounting
{
    public partial class TeacherExamsActionsForm : Form
    {
        private bool isEditMode;
        private int currentExamId;

        public TeacherExamsActionsForm(bool isEditMode, int? id_exam = null)
        {
            InitializeComponent();
            LoadStudents();
            LoadSubjects();
            LoadControlTypes();
            this.isEditMode = isEditMode;

            if (isEditMode)
            {
                currentExamId = id_exam.GetValueOrDefault();
                actionButton.Text = "Изменить";
                labelTop.Text = "Изменить экзамен";
                LoadExamData(currentExamId);

            }
           
        }


        private void LoadExamData(int id_exam)
        {
            DataTable dtExam = Exams_Class.getExam(id_exam);
            if (dtExam != null && dtExam.Rows.Count > 0)
            {
                DataRow row = dtExam.Rows[0];

                subjectsCbx.SelectedValue = row["id_subject"];
                controlTypeCbx.SelectedValue = row["id_control_type"];
                studentsCbx.SelectedValue = row["id_student"];
                dateTimePicker.Value = Convert.ToDateTime(row["date"]);
                gradeTbx.Text = row["grade"].ToString();
            }
            else
            {
                MessageBox.Show("Экзамен не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadStudents()
        {
            string query = @"SELECT * FROM students";
            Student_Class.getStudentsByQuery(query);
            if (Student_Class.dtStudents.Rows.Count == 0)
            {
                MessageBox.Show("Нет студентов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            studentsCbx.DataSource = Student_Class.dtStudents;
            studentsCbx.DisplayMember = "full_name";
            studentsCbx.ValueMember = "id_student";
        }


        private void LoadSubjects()
        {
            Subjects_Class.getSubjects();
            if (Subjects_Class.dtSubjects.Rows.Count == 0)
            {
                MessageBox.Show("Нет предметов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            subjectsCbx.DataSource = Subjects_Class.dtSubjects;
            subjectsCbx.DisplayMember = "subject_name";
            subjectsCbx.ValueMember = "id_subject";
        }


        private void LoadControlTypes()
        {
            Exams_Class.getExamTypes();
            if (Exams_Class.dtExamTypes.Rows.Count == 0)
            {
                MessageBox.Show("Нет типов контроля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            controlTypeCbx.DataSource = Exams_Class.dtExamTypes;
            controlTypeCbx.DisplayMember = "control_type_name";
            controlTypeCbx.ValueMember = "id_control_type";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            int id_student = Convert.ToInt32(studentsCbx.SelectedValue);
            int id_subject = Convert.ToInt32(subjectsCbx.SelectedValue);
            int id_control_type = Convert.ToInt32(controlTypeCbx.SelectedValue);
            DateTime examDate = dateTimePicker.Value;
            string grade = gradeTbx.Text;

            if (!String.IsNullOrEmpty(studentsCbx.Text) || !String.IsNullOrEmpty(subjectsCbx.Text) || !String.IsNullOrEmpty(controlTypeCbx.Text) || !String.IsNullOrEmpty(dateTimePicker.Text))
            {

                if (!isEditMode)
                {
                    bool success = Exams_Class.AddExam(id_student, id_subject, id_control_type, examDate, grade);
                    if (success)
                    {
                        MessageBox.Show("Экзамен успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось добавить экзамен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bool success = Exams_Class.UpdateExam(currentExamId, id_student, id_subject, id_control_type, examDate, grade.ToString());
                    if (success)
                    {
                        MessageBox.Show("Экзамен успешно обновлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось обновить экзамен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пожалуйста заполните необходимые поля", "Заполнение полей", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gradeTbx_TextChanged(object sender, EventArgs e)
        {
            string gradeText = gradeTbx.Text.Trim();

            if (string.IsNullOrEmpty(gradeText))
            {
                return;
            }

            if (int.TryParse(gradeText, out int grade))
            {
                if (grade < 2 || grade > 5)
                {
                    MessageBox.Show("Оценка должна быть целым числом от 2 до 5.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gradeTbx.Clear();
                }
            }
            else
            {
                MessageBox.Show("Оценка должна быть целым числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gradeTbx.Clear();
            }
        }
    }
}
