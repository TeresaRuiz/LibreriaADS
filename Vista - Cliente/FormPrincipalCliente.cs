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
    public partial class FormPrincipalCliente : Form
    {
        public FormPrincipalCliente()
        {
            InitializeComponent();
        }
        private void MostrarControl(UserControl control)
        {
            panelContenido.Controls.Clear(); // Limpia lo que había antes
            control.Dock = DockStyle.Fill;   // Que ocupe todo el espacio
            panelContenido.Controls.Add(control); // Lo agrega al panel
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Mostrar el formulario de login
                FormLogin login = new FormLogin();
                login.Show();

                // Cerrar el formulario actual
                this.Hide();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MostrarControl(new InicioCliente());
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPrincipalCliente_Load(object sender, EventArgs e)
        {
            MostrarControl(new InicioCliente());
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            MostrarControl(new ProductosClientes());
        }
    }
}
