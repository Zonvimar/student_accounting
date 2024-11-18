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
    public partial class LoginForm : Form
    {
        static public string loginActive;
        static public string whois;

        public LoginForm()
        {
            InitializeComponent();
            DBconnection.ConnectionDB();
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(loginTextBox.Text) || !String.IsNullOrEmpty(passwordTextBox.Text))
            {
                Login_Class.Authorization(loginTextBox.Text, passwordTextBox.Text);
                if (Login_Class.role != null && Login_Class.id_entity != null)
                {
                    loginActive = loginTextBox.Text;
                    string full_name = Login_Class.AuthorizationName(Login_Class.id_entity, Login_Class.role);
                    Login_Class.full_name = full_name;
                    MessageBox.Show(Login_Class.role + " " + full_name + ", добро пожаловать!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    switch (Login_Class.role)
                    {
                        case "Студент":
                            //this.Hide();
                            //StudentMenuForm studentMenuForm = new StudentMenuForm();
                            //studentMenuForm.Show();
                            break;
                        case "Преподаватель":
                            //this.Hide();
                            //TeacherMenuForm teacherMenuForm = new TeacherMenuForm();
                            //teacherMenuForm.Show();
                            break;
                        case "Администратор":
                            //this.Hide();
                            //AdminMenuForm adminMenuForm = new AdminMenuForm();
                            //adminMenuForm.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Аккаунт не найден!", "Проверьте введеные данные!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все необзодимые поля!", "Заполнение полей", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
