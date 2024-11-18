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
    public partial class TeacherMenuForm : Form
    {
        public TeacherMenuForm()
        {
            InitializeComponent();
        }

        public TeacherMenuForm(string id_teacher, string full_name)
        {
            InitializeComponent();
            labelHi.Text = full_name + ", добро пожаловать в кабинет учителя!";
            Teacher_Class.getTeacherSubjects(id_teacher);
            subjectsTeacherGriedView.DataSource = Teacher_Class.dtSubjects;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
