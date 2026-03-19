using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaADS
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario dao = new Usuario();

            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            string usuario = txtUsuario.Text;
            string clave = txtContrasena.Text;

            int rol = 1; // 1 = ADMIN (primer uso)

            dao.Registrar(nombre, telefono, direccion, usuario, clave, rol);

            MessageBox.Show("Administrador registrado");

            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }
    }
}
