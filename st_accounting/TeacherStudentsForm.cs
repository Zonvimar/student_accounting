using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st_accounting
{
    public partial class TeacherStudentsForm : Form
    {
        public TeacherStudentsForm()
        {
            InitializeComponent();
            LoadFaculties();
        }

        private void LoadStudents(string query)
        {
            Student_Class.getStudentsByQuery(query);
            studentsDataGridView.DataSource = Student_Class.dtStudents;

        }


        private void LoadFaculties()
        {
            Faculties_Class.getFaculties();
            if (Faculties_Class.dtFaculties.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для загрузки факультетов.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //facultiesCbx.Items.Clear();
            facultiesCbx.DataSource = Faculties_Class.dtFaculties;
            facultiesCbx.DisplayMember = "faculty_name";
            facultiesCbx.ValueMember = "id_faculty";

            if (facultiesCbx.Items.Count > 0)
            {
                facultiesCbx.SelectedIndex = 0;
                int selectedFacultyId = Convert.ToInt32(facultiesCbx.SelectedValue);
                LoadSpecialties(selectedFacultyId); // Явный вызов метода загрузки специальностей
            }
        }


        private void facultiesCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (facultiesCbx.SelectedItem is DataRowView selectedRow)
            {
                int selectedFacultyId = Convert.ToInt32(selectedRow["id_faculty"]);
                LoadSpecialties(selectedFacultyId);
            }
        }

        private void LoadSpecialties(int id_faculty)
        {
            Specialties_Class.getSpecilatiesByFaculty(id_faculty);
            specialtiesCbx.DataSource = Specialties_Class.dtSpecialties;
            specialtiesCbx.DisplayMember = "specialty_name";
            specialtiesCbx.ValueMember = "id_specialty";

            if (specialtiesCbx.Items.Count > 0)
            {
                specialtiesCbx.SelectedIndex = 0;
                int selectedSpecialtyId = Convert.ToInt32(specialtiesCbx.SelectedValue);
                LoadGroups(selectedSpecialtyId); // Явный вызов метода загрузки специальностей
            }
        }


        private void specialtiesCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (specialtiesCbx.SelectedItem is DataRowView selectedRow)
            {
                int selectedSpecialtyId = Convert.ToInt32(selectedRow["id_specialty"]);
                LoadGroups(selectedSpecialtyId);
            }
        }

        private void LoadGroups(int specialtyId)
        {
            Groups_Class.getGroupsBySpecialty(specialtyId);
            //groupsCbx.Items.Clear();
            groupsCbx.DataSource = Groups_Class.dtGroups;
            groupsCbx.DisplayMember = "group_number";
            groupsCbx.ValueMember = "id_group";
        }

        private void allStudentsBtn_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT 
                    students.student_id_number, 
                    students.full_name, 
                    students.sex, 
                    students.date_birth, 
                    groups.group_number, 
                    groups.course
                FROM 
                    students
                INNER JOIN 
                    groups ON students.id_group = groups.id_group";
            LoadStudents(query);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherMenuForm teacherMenuForm = new TeacherMenuForm();
            teacherMenuForm.Show();
        }

        private void searchStudentsBtn_Click(object sender, EventArgs e)
        {
            if (facultiesCbx.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите факультет.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (specialtiesCbx.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите специальность.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (groupsCbx.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите группу.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (groupsCbx.SelectedItem is DataRowView selectedRow)
            {
                int selectedGroupId = Convert.ToInt32(selectedRow["id_group"]);
                string query = @"
                SELECT 
                    students.student_id_number, 
                    students.full_name, 
                    students.sex, 
                    students.date_birth, 
                    groups.group_number, 
                    groups.course
                FROM 
                    students
                INNER JOIN 
                    groups ON students.id_group = groups.id_group
                WHERE
                    students.id_group = '" + selectedGroupId + "'";
                LoadStudents(query);
            } 
            else
            {
                MessageBox.Show("Неизвестная ошибка!", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
    }
}
