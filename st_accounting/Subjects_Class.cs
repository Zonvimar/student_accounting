using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st_accounting
{
    internal class Subjects_Class : DBconnection
    {
        static public DataTable dtSubjects = new DataTable();


        static public void getSubjects()
        {
            try
            {
                msCommand.CommandText = @"
                    SELECT 
                        *
                    FROM 
                        subjects";
                dtSubjects.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtSubjects);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных (предметы)", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
