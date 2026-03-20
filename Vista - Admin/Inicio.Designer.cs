namespace LibreriaADS
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelVentasHoy = new System.Windows.Forms.Panel();
            this.lblVentasHoyTitulo = new System.Windows.Forms.Label();
            this.lblVentasHoyValor = new System.Windows.Forms.Label();
            this.panelProductosVendidos = new System.Windows.Forms.Panel();
            this.lblProductosVendidosTitulo = new System.Windows.Forms.Label();
            this.lblProductosVendidosValor = new System.Windows.Forms.Label();
            this.panelEstadisticas = new System.Windows.Forms.Panel();
            this.lblEstadisticasTitulo = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lblConfirmadas = new System.Windows.Forms.Label();
            this.lblEntregadas = new System.Windows.Forms.Label();
            this.lblCanceladas = new System.Windows.Forms.Label();
            this.dgvTopProductos = new System.Windows.Forms.DataGridView();
            this.lblTopProductos = new System.Windows.Forms.Label();
            this.dgvBajoStock = new System.Windows.Forms.DataGridView();
            this.lblBajoStock = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panelVentasHoy.SuspendLayout();
            this.panelProductosVendidos.SuspendLayout();
            this.panelEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajoStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(28, 29);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(444, 62);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📊 Datos importantes ";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // panelVentasHoy
            // 
            this.panelVentasHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panelVentasHoy.Controls.Add(this.lblVentasHoyTitulo);
            this.panelVentasHoy.Controls.Add(this.lblVentasHoyValor);
            this.panelVentasHoy.Location = new System.Drawing.Point(30, 123);
            this.panelVentasHoy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelVentasHoy.Name = "panelVentasHoy";
            this.panelVentasHoy.Size = new System.Drawing.Size(271, 154);
            this.panelVentasHoy.TabIndex = 1;
            // 
            // lblVentasHoyTitulo
            // 
            this.lblVentasHoyTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblVentasHoyTitulo.ForeColor = System.Drawing.Color.White;
            this.lblVentasHoyTitulo.Location = new System.Drawing.Point(15, 15);
            this.lblVentasHoyTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentasHoyTitulo.Name = "lblVentasHoyTitulo";
            this.lblVentasHoyTitulo.Size = new System.Drawing.Size(330, 46);
            this.lblVentasHoyTitulo.TabIndex = 0;
            this.lblVentasHoyTitulo.Text = "💰 Ventas Hoy";
            // 
            // lblVentasHoyValor
            // 
            this.lblVentasHoyValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblVentasHoyValor.ForeColor = System.Drawing.Color.White;
            this.lblVentasHoyValor.Location = new System.Drawing.Point(-26, 65);
            this.lblVentasHoyValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentasHoyValor.Name = "lblVentasHoyValor";
            this.lblVentasHoyValor.Size = new System.Drawing.Size(330, 77);
            this.lblVentasHoyValor.TabIndex = 1;
            this.lblVentasHoyValor.Text = "$0.00";
            this.lblVentasHoyValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelProductosVendidos
            // 
            this.panelProductosVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panelProductosVendidos.Controls.Add(this.lblProductosVendidosTitulo);
            this.panelProductosVendidos.Controls.Add(this.lblProductosVendidosValor);
            this.panelProductosVendidos.Location = new System.Drawing.Point(332, 124);
            this.panelProductosVendidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelProductosVendidos.Name = "panelProductosVendidos";
            this.panelProductosVendidos.Size = new System.Drawing.Size(314, 154);
            this.panelProductosVendidos.TabIndex = 3;
            // 
            // lblProductosVendidosTitulo
            // 
            this.lblProductosVendidosTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductosVendidosTitulo.ForeColor = System.Drawing.Color.White;
            this.lblProductosVendidosTitulo.Location = new System.Drawing.Point(15, 15);
            this.lblProductosVendidosTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductosVendidosTitulo.Name = "lblProductosVendidosTitulo";
            this.lblProductosVendidosTitulo.Size = new System.Drawing.Size(330, 46);
            this.lblProductosVendidosTitulo.TabIndex = 0;
            this.lblProductosVendidosTitulo.Text = "📦 Productos Vendidos";
            // 
            // lblProductosVendidosValor
            // 
            this.lblProductosVendidosValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblProductosVendidosValor.ForeColor = System.Drawing.Color.White;
            this.lblProductosVendidosValor.Location = new System.Drawing.Point(4, 61);
            this.lblProductosVendidosValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductosVendidosValor.Name = "lblProductosVendidosValor";
            this.lblProductosVendidosValor.Size = new System.Drawing.Size(330, 77);
            this.lblProductosVendidosValor.TabIndex = 1;
            this.lblProductosVendidosValor.Text = "0";
            this.lblProductosVendidosValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelEstadisticas
            // 
            this.panelEstadisticas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelEstadisticas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEstadisticas.Controls.Add(this.lblEstadisticasTitulo);
            this.panelEstadisticas.Controls.Add(this.lblPendientes);
            this.panelEstadisticas.Controls.Add(this.lblConfirmadas);
            this.panelEstadisticas.Controls.Add(this.lblEntregadas);
            this.panelEstadisticas.Controls.Add(this.lblCanceladas);
            this.panelEstadisticas.Location = new System.Drawing.Point(674, 123);
            this.panelEstadisticas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelEstadisticas.Name = "panelEstadisticas";
            this.panelEstadisticas.Size = new System.Drawing.Size(358, 153);
            this.panelEstadisticas.TabIndex = 4;
            // 
            // lblEstadisticasTitulo
            // 
            this.lblEstadisticasTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEstadisticasTitulo.Location = new System.Drawing.Point(15, 8);
            this.lblEstadisticasTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadisticasTitulo.Name = "lblEstadisticasTitulo";
            this.lblEstadisticasTitulo.Size = new System.Drawing.Size(390, 31);
            this.lblEstadisticasTitulo.TabIndex = 0;
            this.lblEstadisticasTitulo.Text = "📋 Ventas por Estado";
            // 
            // lblPendientes
            // 
            this.lblPendientes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPendientes.Location = new System.Drawing.Point(15, 43);
            this.lblPendientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(390, 28);
            this.lblPendientes.TabIndex = 1;
            this.lblPendientes.Text = "🟠 Pendientes: 0";
            // 
            // lblConfirmadas
            // 
            this.lblConfirmadas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConfirmadas.Location = new System.Drawing.Point(15, 71);
            this.lblConfirmadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmadas.Name = "lblConfirmadas";
            this.lblConfirmadas.Size = new System.Drawing.Size(390, 28);
            this.lblConfirmadas.TabIndex = 2;
            this.lblConfirmadas.Text = "🔵 Confirmadas: 0";
            // 
            // lblEntregadas
            // 
            this.lblEntregadas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEntregadas.Location = new System.Drawing.Point(15, 98);
            this.lblEntregadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntregadas.Name = "lblEntregadas";
            this.lblEntregadas.Size = new System.Drawing.Size(390, 28);
            this.lblEntregadas.TabIndex = 3;
            this.lblEntregadas.Text = "🟢 Entregadas: 0";
            // 
            // lblCanceladas
            // 
            this.lblCanceladas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCanceladas.Location = new System.Drawing.Point(15, 126);
            this.lblCanceladas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCanceladas.Name = "lblCanceladas";
            this.lblCanceladas.Size = new System.Drawing.Size(390, 28);
            this.lblCanceladas.TabIndex = 4;
            this.lblCanceladas.Text = "🔴 Canceladas: 0";
            // 
            // dgvTopProductos
            // 
            this.dgvTopProductos.AllowUserToAddRows = false;
            this.dgvTopProductos.AllowUserToDeleteRows = false;
            this.dgvTopProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopProductos.Location = new System.Drawing.Point(75, 351);
            this.dgvTopProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTopProductos.Name = "dgvTopProductos";
            this.dgvTopProductos.ReadOnly = true;
            this.dgvTopProductos.RowHeadersWidth = 62;
            this.dgvTopProductos.Size = new System.Drawing.Size(427, 313);
            this.dgvTopProductos.TabIndex = 6;
            // 
            // lblTopProductos
            // 
            this.lblTopProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTopProductos.Location = new System.Drawing.Point(30, 308);
            this.lblTopProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopProductos.Name = "lblTopProductos";
            this.lblTopProductos.Size = new System.Drawing.Size(472, 38);
            this.lblTopProductos.TabIndex = 5;
            this.lblTopProductos.Text = "🏆 Top 10 Productos Más Vendidos";
            // 
            // dgvBajoStock
            // 
            this.dgvBajoStock.AllowUserToAddRows = false;
            this.dgvBajoStock.AllowUserToDeleteRows = false;
            this.dgvBajoStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBajoStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvBajoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBajoStock.Location = new System.Drawing.Point(557, 351);
            this.dgvBajoStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBajoStock.Name = "dgvBajoStock";
            this.dgvBajoStock.ReadOnly = true;
            this.dgvBajoStock.RowHeadersWidth = 62;
            this.dgvBajoStock.Size = new System.Drawing.Size(436, 313);
            this.dgvBajoStock.TabIndex = 8;
            // 
            // lblBajoStock
            // 
            this.lblBajoStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBajoStock.ForeColor = System.Drawing.Color.Red;
            this.lblBajoStock.Location = new System.Drawing.Point(512, 308);
            this.lblBajoStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBajoStock.Name = "lblBajoStock";
            this.lblBajoStock.Size = new System.Drawing.Size(537, 38);
            this.lblBajoStock.TabIndex = 7;
            this.lblBajoStock.Text = "⚠️ Productos con Bajo Stock (≤ 10 unidades)";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(807, 29);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(225, 62);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "🔄 Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvBajoStock);
            this.Controls.Add(this.lblBajoStock);
            this.Controls.Add(this.dgvTopProductos);
            this.Controls.Add(this.lblTopProductos);
            this.Controls.Add(this.panelEstadisticas);
            this.Controls.Add(this.panelProductosVendidos);
            this.Controls.Add(this.panelVentasHoy);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inicio";
            this.Size = new System.Drawing.Size(1065, 719);
            this.panelVentasHoy.ResumeLayout(false);
            this.panelProductosVendidos.ResumeLayout(false);
            this.panelEstadisticas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajoStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelVentasHoy;
        private System.Windows.Forms.Label lblVentasHoyTitulo;
        private System.Windows.Forms.Label lblVentasHoyValor;
        private System.Windows.Forms.Panel panelProductosVendidos;
        private System.Windows.Forms.Label lblProductosVendidosTitulo;
        private System.Windows.Forms.Label lblProductosVendidosValor;
        private System.Windows.Forms.Panel panelEstadisticas;
        private System.Windows.Forms.Label lblEstadisticasTitulo;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblConfirmadas;
        private System.Windows.Forms.Label lblEntregadas;
        private System.Windows.Forms.Label lblCanceladas;
        private System.Windows.Forms.Label lblTopProductos;
        private System.Windows.Forms.DataGridView dgvTopProductos;
        private System.Windows.Forms.Label lblBajoStock;
        private System.Windows.Forms.DataGridView dgvBajoStock;
        private System.Windows.Forms.Button btnActualizar;
    }
}