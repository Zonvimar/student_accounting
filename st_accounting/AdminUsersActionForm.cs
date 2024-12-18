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
    public partial class AdminUsersActionForm : Form
    {
        private bool isEditMode;
        private int currentUserId;


        public AdminUsersActionForm(bool isEditMode, int? id_student = null)
        {
            InitializeComponent();
            LoadRoles();
            this.isEditMode = isEditMode;

            if (isEditMode)
            {
                currentUserId = id_student.GetValueOrDefault();
                actionBtn.Text = "Изменить";
                labelTop.Text = "Изменить пользователя";
                LoadUserData(currentUserId);

            }
        }

        private void LoadUserData(int id_user)
        {
            DataTable dtUser = User_Class.getUser(id_user);
            if (dtUser != null && dtUser.Rows.Count > 0)
            {
                DataRow row = dtUser.Rows[0];
                loginTbx.Text = row["login"].ToString();
                passwordTbx.Text = row["password"].ToString();
                roleCbx.SelectedValue = row["id_role"];
                entityCbx.SelectedValue = row["id_entity"];
                LoadEntityCbxData(row["id_role"].ToString(), int.Parse(row["id_entity"].ToString()));
            }
            else
            {
                MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void LoadEntityCbxData(string selectedRole, int? selectedEntity = null)
        {

            if (selectedRole == "3")
            {
                entityCbx.DataSource = null;
                entityCbx.Enabled = false;
            }
            else if (selectedRole == "1")
            {
                Student_Class.getStudents();
                entityCbx.DataSource = Student_Class.dtStudents;
                entityCbx.DisplayMember = "full_name";
                entityCbx.ValueMember = "id_student";
                entityCbx.Enabled = true;
                if (selectedEntity != null)
                {
                    entityCbx.SelectedValue = selectedEntity;
                }
            }
            else if (selectedRole == "2")
            {
                Teacher_Class.getTeachers();
                entityCbx.DataSource = Teacher_Class.dtTeachers;
                if (selectedEntity != null)
                {
                    entityCbx.SelectedValue = selectedEntity;
                }
                entityCbx.DisplayMember = "full_name";
                entityCbx.ValueMember = "id_teacher";
                entityCbx.Enabled = true;
            }
        }

        private void LoadRoles()
        {
            DataTable dtRoles = User_Class.getRoles();
            roleCbx.DataSource = dtRoles;
            roleCbx.DisplayMember = "role_name";
            roleCbx.ValueMember = "id_role";
        }

       
        private void roleCbx_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string id_role = roleCbx.SelectedValue.ToString();
            LoadEntityCbxData(id_role);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void actionBtn_Click(object sender, EventArgs e)
        {
            int id_entity = Convert.ToInt32(entityCbx.SelectedValue);
            int id_role = Convert.ToInt32(roleCbx.SelectedValue);

            if (!String.IsNullOrEmpty(entityCbx.Text) || !String.IsNullOrEmpty(roleCbx.Text) || !String.IsNullOrEmpty(loginTbx.Text) || !String.IsNullOrEmpty(passwordTbx.Text))
            {

                if (!isEditMode)
                {
                    bool success = User_Class.AddUser(loginTbx.Text, passwordTbx.Text, id_role, id_entity);
                    if (success)
                    {
                        MessageBox.Show("Пользователь успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось добавить пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bool success = User_Class.UpdateUser(currentUserId, loginTbx.Text, passwordTbx.Text, id_role, id_entity);
                    if (success)
                    {
                        MessageBox.Show("Пользователь успешно изменен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось изменить пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
