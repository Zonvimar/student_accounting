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
    }
}
