namespace LibreriaADS
{
    partial class ProductosClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCatalogo = new System.Windows.Forms.TabPage();
            this.flowProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.tabCarrito = new System.Windows.Forms.TabPage();
            this.panelTotalCarrito = new System.Windows.Forms.Panel();
            this.btnEditarCantidad = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.btnEliminarDelCarrito = new System.Windows.Forms.Button();
            this.btnVaciarCarrito = new System.Windows.Forms.Button();
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabCatalogo.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.tabCarrito.SuspendLayout();
            this.panelTotalCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabCatalogo);
            this.tabControl.Controls.Add(this.tabCarrito);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabControl.Location = new System.Drawing.Point(25, 82);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1085, 617);
            this.tabControl.TabIndex = 0;
            // 
            // tabCatalogo
            // 
            this.tabCatalogo.Controls.Add(this.flowProductos);
            this.tabCatalogo.Controls.Add(this.panelBusqueda);
            this.tabCatalogo.Location = new System.Drawing.Point(4, 39);
            this.tabCatalogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCatalogo.Name = "tabCatalogo";
            this.tabCatalogo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCatalogo.Size = new System.Drawing.Size(1077, 574);
            this.tabCatalogo.TabIndex = 0;
            this.tabCatalogo.Text = "🛍️ Catálogo de Productos";
            this.tabCatalogo.UseVisualStyleBackColor = true;
            this.tabCatalogo.Click += new System.EventHandler(this.tabCatalogo_Click);
            // 
            // flowProductos
            // 
            this.flowProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowProductos.AutoScroll = true;
            this.flowProductos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowProductos.Location = new System.Drawing.Point(4, 106);
            this.flowProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowProductos.Name = "flowProductos";
            this.flowProductos.Padding = new System.Windows.Forms.Padding(15);
            this.flowProductos.Size = new System.Drawing.Size(1065, 458);
            this.flowProductos.TabIndex = 1;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.txtBuscar);
            this.panelBusqueda.Controls.Add(this.btnBuscar);
            this.panelBusqueda.Controls.Add(this.btnLimpiarBusqueda);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusqueda.Location = new System.Drawing.Point(4, 5);
            this.panelBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1069, 92);
            this.panelBusqueda.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBuscar.Location = new System.Drawing.Point(22, 23);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(598, 39);
            this.txtBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(638, 20);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 51);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.Gray;
            this.btnLimpiarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLimpiarBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(802, 20);
            this.btnLimpiarBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(150, 51);
            this.btnLimpiarBusqueda.TabIndex = 2;
            this.btnLimpiarBusqueda.Text = "Limpiar";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // tabCarrito
            // 
            this.tabCarrito.Controls.Add(this.panelTotalCarrito);
            this.tabCarrito.Controls.Add(this.dgvCarrito);
            this.tabCarrito.Location = new System.Drawing.Point(4, 39);
            this.tabCarrito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCarrito.Name = "tabCarrito";
            this.tabCarrito.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCarrito.Size = new System.Drawing.Size(1077, 574);
            this.tabCarrito.TabIndex = 1;
            this.tabCarrito.Text = "🛒 Mi Carrito";
            this.tabCarrito.UseVisualStyleBackColor = true;
            // 
            // panelTotalCarrito
            // 
            this.panelTotalCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTotalCarrito.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTotalCarrito.Controls.Add(this.btnEditarCantidad);
            this.panelTotalCarrito.Controls.Add(this.lblTotal);
            this.panelTotalCarrito.Controls.Add(this.lblTotalValor);
            this.panelTotalCarrito.Controls.Add(this.btnEliminarDelCarrito);
            this.panelTotalCarrito.Controls.Add(this.btnVaciarCarrito);
            this.panelTotalCarrito.Controls.Add(this.btnConfirmarCompra);
            this.panelTotalCarrito.Location = new System.Drawing.Point(9, 331);
            this.panelTotalCarrito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTotalCarrito.Name = "panelTotalCarrito";
            this.panelTotalCarrito.Size = new System.Drawing.Size(1055, 226);
            this.panelTotalCarrito.TabIndex = 1;
            // 
            // btnEditarCantidad
            // 
            this.btnEditarCantidad.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEditarCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCantidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEditarCantidad.ForeColor = System.Drawing.Color.White;
            this.btnEditarCantidad.Location = new System.Drawing.Point(763, 133);
            this.btnEditarCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarCantidad.Name = "btnEditarCantidad";
            this.btnEditarCantidad.Size = new System.Drawing.Size(219, 64);
            this.btnEditarCantidad.TabIndex = 5;
            this.btnEditarCantidad.Text = "Editar Cantidad";
            this.btnEditarCantidad.UseVisualStyleBackColor = false;
            this.btnEditarCantidad.Click += new System.EventHandler(this.btnEditarCantidad_Click_1);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(22, 23);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(225, 46);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "TOTAL:";
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTotalValor.Location = new System.Drawing.Point(21, 69);
            this.lblTotalValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(450, 62);
            this.lblTotalValor.TabIndex = 1;
            this.lblTotalValor.Text = "$0.00";
            // 
            // btnEliminarDelCarrito
            // 
            this.btnEliminarDelCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarDelCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarDelCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDelCarrito.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEliminarDelCarrito.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDelCarrito.Location = new System.Drawing.Point(526, 36);
            this.btnEliminarDelCarrito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarDelCarrito.Name = "btnEliminarDelCarrito";
            this.btnEliminarDelCarrito.Size = new System.Drawing.Size(229, 77);
            this.btnEliminarDelCarrito.TabIndex = 2;
            this.btnEliminarDelCarrito.Text = "🗑️ Eliminar Item";
            this.btnEliminarDelCarrito.UseVisualStyleBackColor = false;
            this.btnEliminarDelCarrito.Click += new System.EventHandler(this.btnEliminarDelCarrito_Click);
            // 
            // btnVaciarCarrito
            // 
            this.btnVaciarCarrito.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVaciarCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciarCarrito.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnVaciarCarrito.ForeColor = System.Drawing.Color.White;
            this.btnVaciarCarrito.Location = new System.Drawing.Point(763, 36);
            this.btnVaciarCarrito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVaciarCarrito.Name = "btnVaciarCarrito";
            this.btnVaciarCarrito.Size = new System.Drawing.Size(219, 77);
            this.btnVaciarCarrito.TabIndex = 3;
            this.btnVaciarCarrito.Text = "🗑️ Vaciar Carrito";
            this.btnVaciarCarrito.UseVisualStyleBackColor = false;
            this.btnVaciarCarrito.Click += new System.EventHandler(this.btnVaciarCarrito_Click);
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarCompra.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnConfirmarCompra.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarCompra.Location = new System.Drawing.Point(341, 133);
            this.btnConfirmarCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(414, 64);
            this.btnConfirmarCompra.TabIndex = 4;
            this.btnConfirmarCompra.Text = "✅ CONFIRMAR COMPRA";
            this.btnConfirmarCompra.UseVisualStyleBackColor = false;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrito.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(9, 9);
            this.dgvCarrito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.RowHeadersWidth = 62;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.Size = new System.Drawing.Size(1055, 313);
            this.dgvCarrito.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.Location = new System.Drawing.Point(18, 23);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(1088, 54);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Bienvenido, Cliente";
            this.lblBienvenida.Click += new System.EventHandler(this.lblBienvenida_Click);
            // 
            // ProductosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductosClientes";
            this.Size = new System.Drawing.Size(1137, 720);
            this.Load += new System.EventHandler(this.ProductosClientes_Load);
            this.tabControl.ResumeLayout(false);
            this.tabCatalogo.ResumeLayout(false);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.tabCarrito.ResumeLayout(false);
            this.panelTotalCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCatalogo;
        private System.Windows.Forms.TabPage tabCarrito;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.FlowLayoutPanel flowProductos;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Panel panelTotalCarrito;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Button btnEliminarDelCarrito;
        private System.Windows.Forms.Button btnVaciarCarrito;
        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnEditarCantidad;
    }
}