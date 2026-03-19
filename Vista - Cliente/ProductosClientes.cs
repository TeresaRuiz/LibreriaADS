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
    public partial class ProductosClientes : UserControl
    {


        public ProductosClientes()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            InitializeComponent();
        }

        private void ProductosClientes_Load(object sender, EventArgs e)
        {
           
        }

        private void ConfigurarDataGridViewCarrito()
        {
            dgvCarrito.AutoGenerateColumns = false;
            dgvCarrito.Columns.Clear();

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreProducto",
                HeaderText = "Producto",
                Name = "colProducto",
                Width = 250
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Marca",
                HeaderText = "Marca",
                Name = "colMarca",
                Width = 120
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Talla",
                HeaderText = "Talla",
                Name = "colTalla",
                Width = 80
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Color",
                HeaderText = "Color",
                Name = "colColor",
                Width = 100
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio Unitario",
                Name = "colPrecio",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad",
                Name = "colCantidad",
                Width = 90
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Subtotal",
                HeaderText = "Subtotal",
                Name = "colSubtotal",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
        }

        private void CargarProductos()
        {
           
        }

        private void MostrarProductosEnCards()
        {
        }


        private void ActualizarCarrito()
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarProductos();
        }

        private void btnEliminarDelCarrito_Click(object sender, EventArgs e)
        {
          
        }

        private void btnVaciarCarrito_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
        }

        private void RealizarCompra(string metodoPago, string referenciaPago) // ✨ NUEVOS PARÁMETROS ✨
        {
           
        }

        private void tabCatalogo_Click(object sender, EventArgs e)
        {

        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }
        private void btnEditarCantidad_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditarCantidad_Click_1(object sender, EventArgs e)
        {
        }
    }
}
