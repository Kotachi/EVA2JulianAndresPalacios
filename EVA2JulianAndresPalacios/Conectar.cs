using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EVA2JulianAndresPalacios
{
    class Conectar
    {
        SqlConnection conex;
        SqlCommand comand;

        public void conexion()
        {
            conex = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\hp\\Desktop\\CODIGOS FUENTE\\EVA2JulianAndresPalacios\\EVA2JulianAndresPalacios\\IPLEONES.mdf; Integrated Security = True");
            conex.Open();
            MessageBox.Show("Conectado");
            conex.Close();
        }
        
    }
}
