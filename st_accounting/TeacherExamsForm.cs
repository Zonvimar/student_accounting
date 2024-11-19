﻿using System;
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
    public partial class TeacherExamsForm : Form
    {
        public TeacherExamsForm()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadExams(string query)
        {
            Exams_Class.getExams(query);
            examsGridView.DataSource = Exams_Class.dtExams;
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


        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherMenuForm teacherMenuForm = new TeacherMenuForm();
            teacherMenuForm.Show();
        }

        private void allExamsBtn_Click(object sender, EventArgs e)
        {
            string query = @"
                    SELECT 
                        exams.id_exam,
                        students.full_name,
                        subjects.subject_name, 
                        control_types.control_type_name, 
                        exams.date, 
                        exams.grade 
                    FROM 
                        exams
                    INNER JOIN 
                        students ON exams.id_student = students.id_student
                    INNER JOIN 
                        subjects ON exams.id_subject = subjects.id_subject
                    INNER JOIN 
                        control_types ON exams.id_control_type = control_types.id_control_type";
            LoadExams(query);
        }

        private void searchExamsBtn_Click(object sender, EventArgs e)
        {
            if (studentsCbx.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите студента", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (studentsCbx.SelectedItem is DataRowView selectedRow)
            {
                int selectedsStudentId = Convert.ToInt32(selectedRow["id_student"]);
                string query = @"
                    SELECT 
                        exams.id_exam,
                        students.full_name,
                        subjects.subject_name, 
                        control_types.control_type_name, 
                        exams.date, 
                        exams.grade 
                    FROM 
                        exams
                    INNER JOIN 
                        students ON exams.id_student = students.id_student
                    INNER JOIN 
                        subjects ON exams.id_subject = subjects.id_subject
                    INNER JOIN 
                        control_types ON exams.id_control_type = control_types.id_control_type
                    WHERE 
                        exams.id_student = '" + selectedsStudentId + "'";
                LoadExams(query);
            }
            else
            {
                MessageBox.Show("Неизвестная ошибка!", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
