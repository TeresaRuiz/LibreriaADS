using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaADS
{
    internal class Usuario
    {
        public bool ExisteAdministrador()
        {
            Conexion conexion = new Conexion();
            SqlConnection cn = conexion.AbrirConexion();

            string query = "SELECT COUNT(*) FROM usuarios u " +
                           "INNER JOIN roles_usuarios r ON u.id_rol_usuario = r.id_rol_usuario " +
                           "WHERE r.nombre_rol = 'Administrador'";

            SqlCommand cmd = new SqlCommand(query, cn);
            int cantidad = (int)cmd.ExecuteScalar();

            conexion.CerrarConexion(cn);

            if (cantidad > 0)
                return true;
            else
                return false;
        }

        public void Registrar(string nombre, string telefono, string direccion, string usuario, string clave, int rol)
        {
            Conexion conexion = new Conexion();
            SqlConnection cn = conexion.AbrirConexion();

            string claveHash = Seguridad.Hash(clave);

            string query = "INSERT INTO usuarios (nombre, telefono, direccion, usuario, clave, id_rol_usuario) " +
                           "VALUES (@nombre, @telefono, @direccion, @usuario, @clave, @rol)";

            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@clave", claveHash);
            cmd.Parameters.AddWithValue("@rol", rol);

            cmd.ExecuteNonQuery();

            conexion.CerrarConexion(cn);
        }
        public string[] Login(string usuario, string clave)
        {
            Conexion conexion = new Conexion();
            SqlConnection cn = conexion.AbrirConexion();

            string claveHash = Seguridad.Hash(clave);

            string query = "SELECT nombre, id_rol_usuario FROM usuarios " +
                           "WHERE usuario = @usuario AND clave = @clave";

            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@clave", claveHash);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string nombre = reader["nombre"].ToString();
                string rol = reader["id_rol_usuario"].ToString();

                conexion.CerrarConexion(cn);

                return new string[] { nombre, rol };
            }
            else
            {
                conexion.CerrarConexion(cn);
                return null;
            }
        }
    }
}
