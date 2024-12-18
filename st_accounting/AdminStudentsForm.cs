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
    public partial class AdminStudentsForm : Form
    {
        public AdminStudentsForm()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            string query = @"
                SELECT
                    students.id_student,
                    students.student_id_number, 
                    students.full_name, 
                    students.sex, 
                    students.date_birth, 
                    students.id_group,
                    groups.group_number, 
                    groups.course
                FROM 
                    students
                INNER JOIN 
                    groups ON students.id_group = groups.id_group";
            Student_Class.getStudentsByQuery(query);
            studentsDGV.DataSource = Student_Class.dtStudents;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuForm adminMenuForm = new AdminMenuForm();
            adminMenuForm.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AdminStudentsActionForm studentsActionForm = new AdminStudentsActionForm(false);
            studentsActionForm.ShowDialog();
        }

        static public string student_id;

        private void editBtn_Click(object sender, EventArgs e)
        {
            student_id = studentsDGV.CurrentRow.Cells[0].Value.ToString();
            AdminStudentsActionForm studentsActionForm = new AdminStudentsActionForm(true, int.Parse(student_id));
            studentsActionForm.ShowDialog();
        }
    }
}
