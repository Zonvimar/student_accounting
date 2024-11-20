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
    public partial class FacultiesForm : Form
    {
        public FacultiesForm()
        {
            InitializeComponent();
            LoadFaculties();
        }

        private void LoadFaculties()
        {
            Faculties_Class.getFaculties();
            facultiesDataGridView.DataSource = Faculties_Class.dtFaculties;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuForm adminMenuForm = new AdminMenuForm();
            adminMenuForm.Show();
        }
    }
}
