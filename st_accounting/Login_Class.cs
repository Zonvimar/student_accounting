using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st_accounting
{
    internal class Login_Class : DBconnection
    {
        static public string role, full_name, id_entity;

        static public void Authorization(string login, string password)
        {
            //try
            //{
                msCommand.CommandText = @"SELECT roles.role_name, entrance.id_entity 
                          FROM roles, entrance 
                          WHERE entrance.login = '" + login + "' AND entrance.password = '" + password + @"'
                          AND entrance.id_role = roles.id_role";
                using (var reader = msCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        role = reader["role_name"].ToString();
                        id_entity = reader["id_entity"].ToString();
                    }
                    else
                    {
                        role = null;
                        full_name = null;
                        id_entity = null;
                    }
                }
            //}
            //catch
            //{
            //    role = null;
            //    MessageBox.Show("Ошибка при авторизации", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        static public string AuthorizationName(string id_entity, string role)
        {
            try
            {
                Object result;
                switch(role)
                {
                    case "Студент":
                        msCommand.CommandText = @"SELECT full_name from students WHERE id_student = '" + id_entity + "'";
                        result = msCommand.ExecuteScalar();
                        full_name = result.ToString();
                        return full_name;
                    case "Преподаватель":
                        msCommand.CommandText = @"SELECT full_name from teachers WHERE id_teacher = '" + id_entity + "'";
                        result = msCommand.ExecuteScalar();
                        full_name = result.ToString();
                        return full_name;
                    case "Админ":
                        return "";
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
