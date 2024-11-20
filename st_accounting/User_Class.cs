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
            //try
            //{
                msCommand.CommandText = @"
                    SELECT 
                        entrance.id_entrance,
                        entrance.login,
                        entrance.password,
                        roles.role_name,
                        entrance.date_last_login                      
                    FROM 
                        entrance
                    INNER JOIN 
                        roles ON entrance.id_role = roles.id_role";
                msDataAdapter.SelectCommand = msCommand;
                dtUsers.Clear();
                msDataAdapter.Fill(dtUsers);
            //}
            //catch
            //{
            //    MessageBox.Show($"Ошибка при получении данных пользователей", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

    }
}
