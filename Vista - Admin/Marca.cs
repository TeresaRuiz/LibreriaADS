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
    public partial class Marca : UserControl
    {
        bool avisoMostrado = false;
        public Marca()
        {
            InitializeComponent();
        }
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void dgvmarca_SelectionChanged(object sender, EventArgs e)
        {
           
        }

       
        private void Marca_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtmarca.Clear();
        }
    }
}
