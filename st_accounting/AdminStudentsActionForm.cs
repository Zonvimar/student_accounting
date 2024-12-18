using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace st_accounting
{
    public partial class AdminStudentsActionForm : Form
    {
        private bool isEditMode;
        private int currentStudentId;

        public AdminStudentsActionForm(bool isEditMode, int? id_student = null)
        {
            InitializeComponent();
            LoadGroups();
            LoadSex();
            this.isEditMode = isEditMode;

            if (isEditMode)
            {
                currentStudentId = id_student.GetValueOrDefault();
                actionButton.Text = "Изменить";
                labelTop.Text = "Изменить студента";
                LoadStudentData(currentStudentId);

            }
        }

        private void LoadStudentData(int id_student)
        {
            string query = @"SELECT * FROM students WHERE id_student = '" + id_student + "'";
            Student_Class.getStudentsByQuery(query);
            DataTable dtStudent = Student_Class.dtStudents;
            if (dtStudent != null && dtStudent.Rows.Count > 0)
            {
                DataRow row = dtStudent.Rows[0];

                studenIdNumberTbx.Text = row["student_id_number"].ToString();
                fullNameTbx.Text = row["full_name"].ToString();
                sexCbx.SelectedValue = row["sex"].ToString();
                groupCbx.SelectedValue = row["id_group"];
                dateTimePicker.Value = Convert.ToDateTime(row["date_birth"]);
            }
            else
            {
                MessageBox.Show("Студент не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadSex()
        {
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("муж", "муж");
            test.Add("жен", "жен");
            sexCbx.DataSource = new BindingSource(test, null);
            sexCbx.DisplayMember = "Value";
            sexCbx.ValueMember = "Key";
        }

        private void LoadGroups()
        {
            Groups_Class.getGroups();
            if (Groups_Class.dtGroups.Rows.Count == 0)
            {
                MessageBox.Show("Нет групп", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            groupCbx.DataSource = Groups_Class.dtGroups;
            groupCbx.DisplayMember = "group_number";
            groupCbx.ValueMember = "id_group";
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            int id_group = Convert.ToInt32(groupCbx.SelectedValue);
            string sex = sexCbx.SelectedValue.ToString();
            DateTime date_birth = dateTimePicker.Value;

            if (!String.IsNullOrEmpty(groupCbx.Text) || !String.IsNullOrEmpty(sexCbx.Text) || !String.IsNullOrEmpty(studenIdNumberTbx.Text) || !String.IsNullOrEmpty(fullNameTbx.Text) || !String.IsNullOrEmpty(dateTimePicker.Text))
            {

                if (!isEditMode)
                {
                    bool success = Student_Class.AddStudent(studenIdNumberTbx.Text, fullNameTbx.Text, sex, id_group, date_birth);
                    if (success)
                    {
                        MessageBox.Show("Студент успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось добавить студента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bool success = Student_Class.UpdateStudent(currentStudentId, studenIdNumberTbx.Text, fullNameTbx.Text, sex, id_group, date_birth);
                    if (success)
                    {
                        MessageBox.Show("Студент успешно изменен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось изменить студента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пожалуйста заполните необходимые поля", "Заполнение полей", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
