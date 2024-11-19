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
    public partial class TeacherExamsActionsForm : Form
    {
        private bool isEditMode;
        private int currentExamId;

        public TeacherExamsActionsForm(bool isEditMode, int? id_exam = null)
        {
            InitializeComponent();

            this.isEditMode = isEditMode;

            if (isEditMode)
            {
                currentExamId = id_exam.GetValueOrDefault();
                actionButton.Text = "Изменить";
                labelTop.Text = "Изменить информацию об экзамене";
                LoadExamData(currentExamId);
            }
            else
            {
                ClearFields();
            }
        }


        private void ClearFields()
        {
            gradeTbx.Clear();
            //dateTimePicker.Clear();
        }


        private void LoadExamData(int id_exam)
        {
            var dtExam = Exams_Class.getExam(id_exam);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherExamsForm teacherExamsForm = new TeacherExamsForm();
            teacherExamsForm.Show();
        }
    }
}
