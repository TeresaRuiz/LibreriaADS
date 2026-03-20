using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaADS
{
    public partial class CATEGORÍA : UserControl
    {
        public CATEGORÍA()
        {
            InitializeComponent();
        }

        bool avisoMostrado = false;
        private void SoloLetras(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

                if (!avisoMostrado)
                {
                    MessageBox.Show("Solo se permiten letras (no números ni símbolos).",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    avisoMostrado = true;
                }
            }
            else
            {
                avisoMostrado = false;
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvcategoria.AutoGenerateColumns = false;
            dgvcategoria.Columns.Clear();

            // **ESTILOS GENERALES**
            dgvcategoria.BorderStyle = BorderStyle.None;
            dgvcategoria.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 240, 250);
            dgvcategoria.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvcategoria.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 210, 240);
            dgvcategoria.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvcategoria.BackgroundColor = Color.White;

            dgvcategoria.EnableHeadersVisualStyles = false;
            dgvcategoria.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvcategoria.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 225, 250);
            dgvcategoria.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 80, 120);
            dgvcategoria.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvcategoria.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 10, 10, 10);
            dgvcategoria.ColumnHeadersHeight = 40;

            dgvcategoria.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvcategoria.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvcategoria.DefaultCellStyle.Padding = new Padding(10, 5, 10, 5);
            dgvcategoria.RowTemplate.Height = 45;

            dgvcategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvcategoria.MultiSelect = false;
            dgvcategoria.AllowUserToAddRows = false;
            dgvcategoria.AllowUserToDeleteRows = false;
            dgvcategoria.ReadOnly = true;
            dgvcategoria.RowHeadersVisible = false;
            dgvcategoria.GridColor = Color.FromArgb(230, 220, 240);

            // **COLUMNAS**
            dgvcategoria.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id_categoria",
                HeaderText = "#",
                Name = "id_categoria",
                Width = 80
            });

            dgvcategoria.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "nombre",
                HeaderText = "Nombre de la categoría",
                Name = "nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
          
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
        }

        private void dgvcategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvcategoria_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvcategoria.SelectedRows.Count > 0)
            {
                txtcategoria.Text = dgvcategoria.SelectedRows[0].Cells["nombre"].Value?.ToString();
            }
        }

       

        private void Categoria_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtcategoria.Clear();
        }
    }
}
