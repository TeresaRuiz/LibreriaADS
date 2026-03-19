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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario dao = new Usuario();

            string usuario = txtUsuario.Text;
            string clave = txtContrasena.Text;

            string[] datos = dao.Login(usuario, clave);

            if (datos != null)
            {
                string nombre = datos[0];
                string rol = datos[1];

                MessageBox.Show("Bienvenido, " + nombre);

                this.Hide();

                if (rol == "1") // ADMIN
                {
                    FormPrincipalAdmin admin = new FormPrincipalAdmin();
                    admin.Show();
                }
                else // CLIENTE
                {
                    FormPrincipalCliente cliente = new FormPrincipalCliente();
                    cliente.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void RegistrarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistroCliente cliente = new FormRegistroCliente();
            cliente.Show();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            creditos.Show();
            this.Hide();
        }
    }
}
