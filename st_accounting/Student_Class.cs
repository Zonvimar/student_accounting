using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st_accounting
{
    internal class Student_Class: DBconnection
    {
        static public DataTable dtExams = new DataTable();

        static public void getStudentExams(string id_student)
        {
            try
            {
                msCommand.CommandText = @"SELECT * FROM exams WHERE id_student='" + id_student + "'";
                dtExams.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtExams);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
