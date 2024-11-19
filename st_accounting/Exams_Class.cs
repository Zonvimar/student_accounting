using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st_accounting
{
    internal class Exams_Class : DBconnection
    {
        static public DataTable dtExams = new DataTable();

        static public void getExams(string query)
        {
            try
            {
                msCommand.CommandText = query;
                dtExams.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtExams);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных (экзамены)", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public object getExam(int id_exam)
        {
            try
            {
                msCommand.CommandText = @"SELECT * FROM exams WHERE id_exam = '" + id_exam + "'";
                msDataAdapter.SelectCommand = msCommand;
                DataTable result = new DataTable();
                msDataAdapter.Fill(result);

                if (result.Rows.Count > 0)
                {
                    return result.Rows[0];
                }

                return null;
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных (экзамены)", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
