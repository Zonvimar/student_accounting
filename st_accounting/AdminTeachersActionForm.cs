using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace st_accounting
{
    public partial class AdminTeachersActionForm : Form
    {
        private bool isEditMode;
        private int currentTeacherId;

        public AdminTeachersActionForm(bool isEditMode, int? id_teacher = null)
        {
            InitializeComponent();
            this.isEditMode = isEditMode;

            if (isEditMode)
            {
                currentTeacherId = id_teacher.GetValueOrDefault();
                actionButton.Text = "Изменить";
                labelTop.Text = "Изменить преподователя";
                LoadTeacherData(currentTeacherId);

            }
        }

        private void LoadTeacherData(int id_teacher)
        {
            DataTable dtTeacher = Teacher_Class.getTeachersById(id_teacher);
            if (dtTeacher != null && dtTeacher.Rows.Count > 0)
            {
                DataRow row = dtTeacher.Rows[0];
                fullNameTbx.Text = row["full_name"].ToString();
                phoneTbx.Text = row["phone"].ToString();
                emailTbx.Text = row["email"].ToString();
            }
            else
            {
                MessageBox.Show("Преподователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void actionButton_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(fullNameTbx.Text) || !String.IsNullOrEmpty(phoneTbx.Text) || !String.IsNullOrEmpty(emailTbx.Text))
            {

                if (!isEditMode)
                {
                    bool success = Teacher_Class.AddTeacher(fullNameTbx.Text, phoneTbx.Text, emailTbx.Text);
                    if (success)
                    {
                        MessageBox.Show("Преподователь успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось добавить преподователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bool success = Teacher_Class.UpdateTeacher(currentTeacherId, fullNameTbx.Text, phoneTbx.Text, emailTbx.Text);
                    if (success)
                    {
                        MessageBox.Show("Преподователь успешно изменен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось изменить преподователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пожалуйста заполните необходимые поля", "Заполнение полей", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
