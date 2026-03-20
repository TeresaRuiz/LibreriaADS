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
    public partial class PantallaColor : UserControl
    {
        public PantallaColor()
        {
            InitializeComponent();
            CargarColores();
            ConfigurarDataGridView();
        }
        private void ConfigurarDataGridView()
        {
           
        }

        // ------------------- FUNCIÓN AUXILIAR PARA ESTILO UNIFORME -------------------
        private void AplicarEstiloDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 240, 250);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 210, 240);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 225, 250);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 80, 120);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 10, 10, 10);
            dgv.ColumnHeadersHeight = 40;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgv.DefaultCellStyle.Padding = new Padding(10, 5, 10, 5);
            dgv.RowTemplate.Height = 45;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.GridColor = Color.FromArgb(230, 220, 240);
        }



        private void CargarColores()
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
        }

        private void dtgvColores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvColores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea el carácter
                MessageBox.Show("Solo se permiten letras en el nombre del color.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           
        }
    }
}

