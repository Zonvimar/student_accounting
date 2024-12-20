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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            User_Class.getUsers();
            usersDataGridView.DataSource = User_Class.dtUsers;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuForm adminMenuForm = new AdminMenuForm();
            adminMenuForm.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AdminUsersActionForm adminUsersActionForm = new AdminUsersActionForm(false);
            adminUsersActionForm.ShowDialog();
        }

        static public string entrance_id;

        private void editBtn_Click(object sender, EventArgs e)
        {
            entrance_id = usersDataGridView.CurrentRow.Cells[0].Value.ToString();
            AdminUsersActionForm adminUsersActionForm = new AdminUsersActionForm(true, int.Parse(entrance_id));
            adminUsersActionForm.ShowDialog();
        }
    }
}
