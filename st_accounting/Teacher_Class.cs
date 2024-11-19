using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st_accounting
{
    class Teacher_Class : DBconnection
    {
        static public DataTable dtSubjects = new DataTable();

        static public void getTeacherSubjects(string id_teacher)
        {
            try
            {
                msCommand.CommandText = @"
                    SELECT 
                        subject_name
                    FROM 
                        subjects
                    WHERE 
                        subjects.id_teacher = '" + id_teacher + "'";
                dtSubjects.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtSubjects);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
