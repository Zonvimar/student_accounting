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
        static public DataTable dtTeachers = new DataTable();


        static public void getTeachers()
        {
            try
            {
                msCommand.CommandText = @"
                    SELECT 
                        *
                    FROM 
                        teachers";
                dtTeachers.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtTeachers);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных (преподователи)", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public DataTable getTeachersById(int id_teacher)
        {
            try
            {
                msCommand.CommandText = @"
                    SELECT 
                        *
                    FROM 
                        teachers
                    WHERE
                        id_teacher = '" + id_teacher + "'";
                msDataAdapter.SelectCommand = msCommand;
                DataTable result = new DataTable();
                msDataAdapter.Fill(result);
                return result;

            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных (преподователь)", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

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




        public static bool AddTeacher(string full_name, string phone, string email)
        {
            try
            {
                msCommand.CommandText = @"INSERT INTO teachers (full_name, phone, email)
                                  VALUES (@full_name, @phone, @email)";
                msCommand.Parameters.Clear();
                msCommand.Parameters.AddWithValue("@email", email);
                msCommand.Parameters.AddWithValue("@full_name", full_name);
                msCommand.Parameters.AddWithValue("@phone", phone);

                int rowsAffected = msCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch
            {
                MessageBox.Show($"Ошибка при добавлении преподователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool UpdateTeacher(int id_teacher, string full_name, string phone, string email)
        {
            try
            {
                msCommand.CommandText = @"UPDATE teachers 
                                  SET email = @email,
                                      full_name = @full_name,
                                      phone = @phone
                                  WHERE id_teacher = @id_teacher";
                msCommand.Parameters.Clear();
                msCommand.Parameters.AddWithValue("@id_teacher", id_teacher);
                msCommand.Parameters.AddWithValue("@email", email);
                msCommand.Parameters.AddWithValue("@full_name", full_name);
                msCommand.Parameters.AddWithValue("@phone", phone);
                int rowsAffected = msCommand.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch
            {
                MessageBox.Show($"Ошибка при изменении преподователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
