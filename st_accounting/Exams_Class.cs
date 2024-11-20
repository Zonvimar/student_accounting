using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st_accounting
{
    internal class Exams_Class : DBconnection
    {
        static public DataTable dtExams = new DataTable();
        static public DataTable dtExamTypes = new DataTable();

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

        static public void getExamTypes()
        {
            try
            {
                msCommand.CommandText = @"SELECT * FROM control_types";
                dtExamTypes.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtExamTypes);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных (типы контроля)", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public DataTable getExam(int id_exam)
        {
            try
            {
                msCommand.CommandText = @"SELECT * FROM exams WHERE id_exam = '" + id_exam + "'";
                msDataAdapter.SelectCommand = msCommand;
                DataTable result = new DataTable();
                msDataAdapter.Fill(result);
                return result;

            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных (экзамены)", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static bool AddExam(int id_student, int id_subject, int id_control_type, DateTime examDate, string grade)
        {
            try
            {
                string formattedDate = examDate.ToString("yyyy-MM-dd");

                msCommand.CommandText = @"INSERT INTO exams (id_student, id_subject, id_control_type, date, grade)
                                  VALUES (@id_student, @id_subject, @id_control_type, @date, @grade)";
                msCommand.Parameters.Clear();
                msCommand.Parameters.AddWithValue("@id_student", id_student);
                msCommand.Parameters.AddWithValue("@id_subject", id_subject);
                msCommand.Parameters.AddWithValue("@id_control_type", id_control_type);
                msCommand.Parameters.AddWithValue("@date", formattedDate);
                msCommand.Parameters.AddWithValue("@grade", grade);

                int rowsAffected = msCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch
            {
                MessageBox.Show($"Ошибка при добавлении экзамена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool UpdateExam(int id_exam, int id_student, int id_subject, int id_control_type, DateTime examDate, string grade)
        {
            try
            {

                string formattedDate = examDate.ToString("yyyy-MM-dd");

                msCommand.CommandText = @"UPDATE exams 
                                  SET id_student = @id_student,
                                      id_subject = @id_subject,
                                      id_control_type = @id_control_type,
                                      date = @date,
                                      grade = @grade
                                  WHERE id_exam = @id_exam";
                msCommand.Parameters.Clear();
                msCommand.Parameters.AddWithValue("@id_exam", id_exam);
                msCommand.Parameters.AddWithValue("@id_student", id_student);
                msCommand.Parameters.AddWithValue("@id_subject", id_subject);
                msCommand.Parameters.AddWithValue("@id_control_type", id_control_type);
                msCommand.Parameters.AddWithValue("@date", formattedDate);
                msCommand.Parameters.AddWithValue("@grade", grade);
                int rowsAffected = msCommand.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch
            {
                MessageBox.Show($"Ошибка при обновлении экзамена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public void DeleteExam(string id_exam)
        {
            try
            {
                msCommand.CommandText = @"DELETE FROM exams WHERE id_exam = '" + id_exam + "';";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
