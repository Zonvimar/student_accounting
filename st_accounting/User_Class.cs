using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st_accounting
{
    internal class User_Class : DBconnection
    {
        static public DataTable dtUsers = new DataTable();


        static public void getUsers()
        {
            try
            {
                msCommand.CommandText = @"
                    SELECT 
                        entrance.id_entrance,
                        entrance.login,
                        entrance.password,
                        roles.role_name,
                        entrance.id_role,
                        entrance.date_last_login,
                        entrance.id_entity
                    FROM 
                        entrance
                    INNER JOIN 
                        roles ON entrance.id_role = roles.id_role";
                msDataAdapter.SelectCommand = msCommand;
                dtUsers.Clear();
                msDataAdapter.Fill(dtUsers);
            }
            catch
            {
                MessageBox.Show($"Ошибка при получении данных пользователей", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public DataTable getUser(int id_entrance)
        {
            try
            {
                msCommand.CommandText = @"
                    SELECT 
                        entrance.login,
                        entrance.password,
                        entrance.id_role,
                        entrance.id_entity
                    FROM 
                        entrance
                    WHERE
                        id_entrance = '" + id_entrance + "'";
                msDataAdapter.SelectCommand = msCommand;
                DataTable result = new DataTable();
                msDataAdapter.Fill(result);
                return result;
            }
            catch
            {
                MessageBox.Show($"Ошибка при получении данных пользователя", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        
        static public DataTable getRoles()
        {
            try
            {
                msCommand.CommandText = @"
                    SELECT 
                        *
                    FROM 
                        roles";
                msDataAdapter.SelectCommand = msCommand;
                DataTable result = new DataTable();
                msDataAdapter.Fill(result);
                return result;
            }
            catch
            {
                MessageBox.Show($"Ошибка при получении данных ролей", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public static bool AddUser(string login, string password, int id_role, int id_entity)
        {
            try
            {
                msCommand.CommandText = @"INSERT INTO entrance (login, password, id_role, id_entity)
                                  VALUES (@login, @password, @id_role, @id_entity)";
                msCommand.Parameters.Clear();
                msCommand.Parameters.AddWithValue("@login", login);
                msCommand.Parameters.AddWithValue("@password", password);
                msCommand.Parameters.AddWithValue("@id_role", id_role);
                msCommand.Parameters.AddWithValue("@id_entity", id_entity);

                int rowsAffected = msCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch
            {
                MessageBox.Show($"Ошибка при добавлении пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool UpdateUser(int id_user, string login, string password, int id_role, int id_entity)
        {
            try
            {
                msCommand.CommandText = @"UPDATE entrance 
                                  SET login = @login,
                                      password = @password,
                                      id_role = @id_role,
                                      id_entity = @id_entity
                                  WHERE id_entrance = @id_user";
                msCommand.Parameters.Clear();
                msCommand.Parameters.AddWithValue("@id_user", id_user);
                msCommand.Parameters.AddWithValue("@login", login);
                msCommand.Parameters.AddWithValue("@password", password);
                msCommand.Parameters.AddWithValue("@id_role", id_role);
                msCommand.Parameters.AddWithValue("@id_entity", id_entity);
                int rowsAffected = msCommand.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch
            {
                MessageBox.Show($"Ошибка при изменении пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
