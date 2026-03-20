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
    public partial class Inicio : UserControl
    {
        public Inicio()
        {
            InitializeComponent();
            CargarEstadisticas();
        }
        private void CargarEstadisticas()
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


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarEstadisticas();
            MessageBox.Show("Estadísticas actualizadas",
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            CargarEstadisticas();
            MessageBox.Show("Estadísticas actualizadas",
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
