using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st_accounting
{
    internal class Groups_Class : DBconnection
    {
        static public DataTable dtGroups = new DataTable();

        static public void getGroupsBySpecialty(int id_specialty)
        {
            try
            {
                msCommand.CommandText = @"
                    SELECT 
                        *
                    FROM 
                        groups
                    WHERE 
                        id_specialty = '" + id_specialty + "'";
                dtGroups.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtGroups);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных (группы)", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
