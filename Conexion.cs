using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaADS
{
    public class Conexion
    {
        public static string cadenaConexion = "Server=DESKTOP-352VPTR;Database=BD_libreria_utiles;Trusted_Connection=True;";

        public SqlConnection AbrirConexion()
        {
            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            return cn;
        }

        public void CerrarConexion(SqlConnection cn)
        {
            if (cn != null && cn.State == System.Data.ConnectionState.Open)
                cn.Close();
        }
    }
}
