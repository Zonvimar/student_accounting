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
    }
}
