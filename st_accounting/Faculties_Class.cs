using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st_accounting
{
    internal class Faculties_Class: DBconnection
    {
        static public DataTable dtFaculties = new DataTable();

        static public void getFaculties()
        {
            try
            {
                msCommand.CommandText = @"
                    SELECT 
                        *
                    FROM 
                        faculties";
                dtFaculties.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtFaculties);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных (факультеты)", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
