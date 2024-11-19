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
    public partial class StudentMenuForm : Form
    {
        public StudentMenuForm()
        {
            InitializeComponent();
        }
        
        public StudentMenuForm(string student_id, string role, string full_name)
        {
            InitializeComponent();
            Student_Class.getStudentExams(student_id);
            examsGridView.DataSource = Student_Class.dtExams;
            labelCount.Text = "Количество экзаменов: " + Student_Class.dtExams.Rows.Count.ToString();
            labelHi.Text = role + " " + full_name + ", добро пожаловать!";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void StudentMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void examsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
