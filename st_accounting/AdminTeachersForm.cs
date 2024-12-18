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
    public partial class AdminTeachersForm : Form
    {
        public AdminTeachersForm()
        {
            InitializeComponent();
            LoadTeachers();
        }

        private void LoadTeachers()
        {
            Teacher_Class.getTeachers();
            teachersGDV.DataSource = Teacher_Class.dtTeachers;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuForm adminMenuForm = new AdminMenuForm();
            adminMenuForm.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AdminTeachersActionForm teachersActionForm = new AdminTeachersActionForm(false);
            teachersActionForm.ShowDialog();
        }

        static public string teacher_id;

        private void editBtn_Click(object sender, EventArgs e)
        {
            teacher_id = teachersGDV.CurrentRow.Cells[0].Value.ToString();
            AdminTeachersActionForm teachersActionForm = new AdminTeachersActionForm(true, int.Parse(teacher_id));
            teachersActionForm.ShowDialog();
        }
    }
}
