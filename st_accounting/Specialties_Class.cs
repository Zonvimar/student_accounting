using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st_accounting
{
    internal class Specialties_Class: DBconnection
    {
        static public DataTable dtSpecialties = new DataTable();

        static public void getSpecilatiesByFaculty(int id_faculty)
        {
            try
            {
                msCommand.CommandText = @"
                    SELECT 
                        *
                    FROM 
                        specialties
                    WHERE 
                        id_faculty = '" + id_faculty + "'";
                dtSpecialties.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtSpecialties);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных (специальности)", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
