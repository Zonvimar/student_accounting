using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st_accounting
{
    internal class Student_Class: DBconnection
    {
        static public DataTable dtExams = new DataTable();
        static public DataTable dtStudents = new DataTable();

        static public void getStudentExams(string id_student)
        {
            try
            {
                msCommand.CommandText = @"
                    SELECT 
                        exams.id_exam, 
                        subjects.subject_name, 
                        control_types.control_type_name, 
                        exams.date, 
                        exams.grade 
                    FROM 
                        exams
                    INNER JOIN 
                        students ON exams.id_student = students.id_student
                    INNER JOIN 
                        subjects ON exams.id_subject = subjects.id_subject
                    INNER JOIN 
                        control_types ON exams.id_control_type = control_types.id_control_type
                    WHERE 
                        exams.id_student = '" + id_student + "'"; 
                dtExams.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtExams);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public void getStudentsByQuery(string query)
        {
            try
            {
                msCommand.CommandText = query;
                dtStudents.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtStudents);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных (студенты)", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static public void getStudents()
        {
            try
            {
                msCommand.CommandText = @"SELECT * FROM students;";
                dtStudents.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtStudents);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных (студенты)", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public void getStudentsWithBadGrades()
        {
            try
            {
                msCommand.CommandText = @"
                    SELECT 
                        f.faculty_name,
                        s.specialty_name,
                        g.course,
                        g.group_number,
                        st.full_name,
                        COUNT(e.grade) AS grade_count
                    FROM 
                        students st
                    INNER JOIN 
                        groups g ON st.id_group = g.id_group
                    INNER JOIN 
                        specialties s ON g.id_specialty = s.id_specialty
                    INNER JOIN 
                        faculties f ON s.id_faculty = f.id_faculty
                    INNER JOIN 
                        exams e ON st.id_student = e.id_student
                    WHERE 
                        e.grade = '2'
                    GROUP BY 
                        f.faculty_name, 
                        s.specialty_name, 
                        g.course, 
                        g.group_number, 
                        st.full_name
                    ORDER BY 
                        g.course, 
                        g.group_number, 
                        st.full_name;";

                msDataAdapter.SelectCommand = msCommand;
                    dtStudents.Clear();
                    msDataAdapter.Fill(dtStudents);
            }
            catch
            {
                MessageBox.Show($"Ошибка при получении данных студентов", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        static public void getStudentsWithGoodGrades()
        {
            try
            {
                msCommand.CommandText = @"
                    SELECT 
                        f.faculty_name AS faculty_name,
                        g.group_number AS group_name,
                        g.course AS course,
                        s.full_name AS student_name
                    FROM 
                        students s
                    JOIN 
                        groups g ON s.id_group = g.id_group
                    JOIN 
                        specialties sp ON g.id_specialty = sp.id_specialty
                    JOIN 
                        faculties f ON sp.id_faculty = f.id_faculty
                    JOIN 
                        exams e ON s.id_student = e.id_student
                    GROUP BY 
                        f.faculty_name, g.group_number, g.course, s.id_student, s.full_name
                    HAVING 
                        MIN(e.grade) >= 4
                    ORDER BY 
                        f.faculty_name, g.group_number, g.course, s.full_name;";

                msDataAdapter.SelectCommand = msCommand;
                dtStudents.Clear();
                msDataAdapter.Fill(dtStudents);
            }
            catch
            {
                MessageBox.Show($"Ошибка при получении данных студентов", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static bool AddStudent(string student_id_number, string full_name, string sex, int id_group, DateTime date_birth)
        {
            try
            {
                string formattedDate = date_birth.ToString("yyyy-MM-dd");

                msCommand.CommandText = @"INSERT INTO students (student_id_number, full_name, sex, id_group, date_birth)
                                  VALUES (@student_id_number, @full_name, @sex, @id_group, @date_birth)";
                msCommand.Parameters.Clear();
                msCommand.Parameters.AddWithValue("@student_id_number", student_id_number);
                msCommand.Parameters.AddWithValue("@full_name", full_name);
                msCommand.Parameters.AddWithValue("@sex", sex);
                msCommand.Parameters.AddWithValue("@id_group", id_group);
                msCommand.Parameters.AddWithValue("@date_birth", formattedDate);

                int rowsAffected = msCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch
            {
                MessageBox.Show($"Ошибка при добавлении студента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool UpdateStudent(int id_student, string student_id_number, string full_name, string sex, int id_group, DateTime date_birth)
        {
            try
            {

                string formattedDate = date_birth.ToString("yyyy-MM-dd");

                msCommand.CommandText = @"UPDATE students 
                                  SET student_id_number = @student_id_number,
                                      full_name = @full_name,
                                      sex = @sex,
                                      id_group = @id_group,
                                      date_birth = @date_birth
                                  WHERE id_student = @id_student";
                msCommand.Parameters.Clear();
                msCommand.Parameters.AddWithValue("@id_student", id_student);
                msCommand.Parameters.AddWithValue("@student_id_number", student_id_number);
                msCommand.Parameters.AddWithValue("@full_name", full_name);
                msCommand.Parameters.AddWithValue("@sex", sex);
                msCommand.Parameters.AddWithValue("@id_group", id_group);
                msCommand.Parameters.AddWithValue("@date_birth", formattedDate);
                int rowsAffected = msCommand.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch
            {
                MessageBox.Show($"Ошибка при изменении студента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
