namespace LibreriaADS
{
    partial class InicioCliente
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelTotalCompras = new System.Windows.Forms.Panel();
            this.lblTotalComprasTitulo = new System.Windows.Forms.Label();
            this.lblTotalComprasValor = new System.Windows.Forms.Label();
            this.panelTotalGastado = new System.Windows.Forms.Panel();
            this.lblTotalGastadoTitulo = new System.Windows.Forms.Label();
            this.lblTotalGastadoValor = new System.Windows.Forms.Label();
            this.panelEstadoCompras = new System.Windows.Forms.Panel();
            this.lblEstadoComprasTitulo = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lblConfirmadas = new System.Windows.Forms.Label();
            this.lblEntregadas = new System.Windows.Forms.Label();
            this.lblCanceladas = new System.Windows.Forms.Label();
            this.dgvUltimasCompras = new System.Windows.Forms.DataGridView();
            this.lblUltimasCompras = new System.Windows.Forms.Label();
            this.dgvProductosFavoritos = new System.Windows.Forms.DataGridView();
            this.lblProductosFavoritos = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panelTotalCompras.SuspendLayout();
            this.panelTotalGastado.SuspendLayout();
            this.panelEstadoCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimasCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosFavoritos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(28, 29);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 62);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "👋 Bienvenido a tu panel";
            // 
            // panelTotalCompras
            // 
            this.panelTotalCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panelTotalCompras.Controls.Add(this.lblTotalComprasTitulo);
            this.panelTotalCompras.Controls.Add(this.lblTotalComprasValor);
            this.panelTotalCompras.Location = new System.Drawing.Point(30, 123);
            this.panelTotalCompras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTotalCompras.Name = "panelTotalCompras";
            this.panelTotalCompras.Size = new System.Drawing.Size(271, 154);
            this.panelTotalCompras.TabIndex = 1;
            // 
            // lblTotalComprasTitulo
            // 
            this.lblTotalComprasTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalComprasTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTotalComprasTitulo.Location = new System.Drawing.Point(15, 15);
            this.lblTotalComprasTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalComprasTitulo.Name = "lblTotalComprasTitulo";
            this.lblTotalComprasTitulo.Size = new System.Drawing.Size(330, 46);
            this.lblTotalComprasTitulo.TabIndex = 0;
            this.lblTotalComprasTitulo.Text = "🛍️ Total compras";
            // 
            // lblTotalComprasValor
            // 
            this.lblTotalComprasValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalComprasValor.ForeColor = System.Drawing.Color.White;
            this.lblTotalComprasValor.Location = new System.Drawing.Point(-26, 65);
            this.lblTotalComprasValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalComprasValor.Name = "lblTotalComprasValor";
            this.lblTotalComprasValor.Size = new System.Drawing.Size(330, 77);
            this.lblTotalComprasValor.TabIndex = 1;
            this.lblTotalComprasValor.Text = "0";
            this.lblTotalComprasValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTotalGastado
            // 
            this.panelTotalGastado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panelTotalGastado.Controls.Add(this.lblTotalGastadoTitulo);
            this.panelTotalGastado.Controls.Add(this.lblTotalGastadoValor);
            this.panelTotalGastado.Location = new System.Drawing.Point(332, 124);
            this.panelTotalGastado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTotalGastado.Name = "panelTotalGastado";
            this.panelTotalGastado.Size = new System.Drawing.Size(314, 154);
            this.panelTotalGastado.TabIndex = 2;
            // 
            // lblTotalGastadoTitulo
            // 
            this.lblTotalGastadoTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalGastadoTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTotalGastadoTitulo.Location = new System.Drawing.Point(15, 15);
            this.lblTotalGastadoTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalGastadoTitulo.Name = "lblTotalGastadoTitulo";
            this.lblTotalGastadoTitulo.Size = new System.Drawing.Size(330, 46);
            this.lblTotalGastadoTitulo.TabIndex = 0;
            this.lblTotalGastadoTitulo.Text = "💳 Total gastado";
            // 
            // lblTotalGastadoValor
            // 
            this.lblTotalGastadoValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalGastadoValor.ForeColor = System.Drawing.Color.White;
            this.lblTotalGastadoValor.Location = new System.Drawing.Point(4, 61);
            this.lblTotalGastadoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalGastadoValor.Name = "lblTotalGastadoValor";
            this.lblTotalGastadoValor.Size = new System.Drawing.Size(330, 77);
            this.lblTotalGastadoValor.TabIndex = 1;
            this.lblTotalGastadoValor.Text = "$0.00";
            this.lblTotalGastadoValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelEstadoCompras
            // 
            this.panelEstadoCompras.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelEstadoCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEstadoCompras.Controls.Add(this.lblEstadoComprasTitulo);
            this.panelEstadoCompras.Controls.Add(this.lblPendientes);
            this.panelEstadoCompras.Controls.Add(this.lblConfirmadas);
            this.panelEstadoCompras.Controls.Add(this.lblEntregadas);
            this.panelEstadoCompras.Controls.Add(this.lblCanceladas);
            this.panelEstadoCompras.Location = new System.Drawing.Point(674, 123);
            this.panelEstadoCompras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelEstadoCompras.Name = "panelEstadoCompras";
            this.panelEstadoCompras.Size = new System.Drawing.Size(358, 153);
            this.panelEstadoCompras.TabIndex = 3;
            // 
            // lblEstadoComprasTitulo
            // 
            this.lblEstadoComprasTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEstadoComprasTitulo.Location = new System.Drawing.Point(15, 8);
            this.lblEstadoComprasTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoComprasTitulo.Name = "lblEstadoComprasTitulo";
            this.lblEstadoComprasTitulo.Size = new System.Drawing.Size(390, 31);
            this.lblEstadoComprasTitulo.TabIndex = 0;
            this.lblEstadoComprasTitulo.Text = "📊 Estado de tus compras";
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
            // dgvUltimasCompras
            // 
            this.dgvUltimasCompras.AllowUserToAddRows = false;
            this.dgvUltimasCompras.AllowUserToDeleteRows = false;
            this.dgvUltimasCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUltimasCompras.BackgroundColor = System.Drawing.Color.White;
            this.dgvUltimasCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUltimasCompras.Location = new System.Drawing.Point(75, 351);
            this.dgvUltimasCompras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUltimasCompras.Name = "dgvUltimasCompras";
            this.dgvUltimasCompras.ReadOnly = true;
            this.dgvUltimasCompras.RowHeadersWidth = 62;
            this.dgvUltimasCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUltimasCompras.Size = new System.Drawing.Size(427, 313);
            this.dgvUltimasCompras.TabIndex = 5;
            // 
            // lblUltimasCompras
            // 
            this.lblUltimasCompras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUltimasCompras.Location = new System.Drawing.Point(30, 308);
            this.lblUltimasCompras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUltimasCompras.Name = "lblUltimasCompras";
            this.lblUltimasCompras.Size = new System.Drawing.Size(472, 38);
            this.lblUltimasCompras.TabIndex = 4;
            this.lblUltimasCompras.Text = "🕒 Tus últimas compras";
            // 
            // dgvProductosFavoritos
            // 
            this.dgvProductosFavoritos.AllowUserToAddRows = false;
            this.dgvProductosFavoritos.AllowUserToDeleteRows = false;
            this.dgvProductosFavoritos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosFavoritos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductosFavoritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosFavoritos.Location = new System.Drawing.Point(557, 351);
            this.dgvProductosFavoritos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProductosFavoritos.Name = "dgvProductosFavoritos";
            this.dgvProductosFavoritos.ReadOnly = true;
            this.dgvProductosFavoritos.RowHeadersWidth = 62;
            this.dgvProductosFavoritos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosFavoritos.Size = new System.Drawing.Size(436, 313);
            this.dgvProductosFavoritos.TabIndex = 7;
            // 
            // lblProductosFavoritos
            // 
            this.lblProductosFavoritos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductosFavoritos.ForeColor = System.Drawing.Color.Crimson;
            this.lblProductosFavoritos.Location = new System.Drawing.Point(512, 308);
            this.lblProductosFavoritos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductosFavoritos.Name = "lblProductosFavoritos";
            this.lblProductosFavoritos.Size = new System.Drawing.Size(481, 38);
            this.lblProductosFavoritos.TabIndex = 6;
            this.lblProductosFavoritos.Text = "❤️ Tus productos favoritos";
            this.lblProductosFavoritos.Click += new System.EventHandler(this.lblProductosFavoritos_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(807, 29);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(225, 62);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "🔄 Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // InicioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvProductosFavoritos);
            this.Controls.Add(this.lblProductosFavoritos);
            this.Controls.Add(this.dgvUltimasCompras);
            this.Controls.Add(this.lblUltimasCompras);
            this.Controls.Add(this.panelEstadoCompras);
            this.Controls.Add(this.panelTotalGastado);
            this.Controls.Add(this.panelTotalCompras);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InicioCliente";
            this.Size = new System.Drawing.Size(1065, 719);
            this.Load += new System.EventHandler(this.InicioCliente_Load);
            this.panelTotalCompras.ResumeLayout(false);
            this.panelTotalGastado.ResumeLayout(false);
            this.panelEstadoCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimasCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosFavoritos)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelTotalCompras;
        private System.Windows.Forms.Label lblTotalComprasTitulo;
        private System.Windows.Forms.Label lblTotalComprasValor;
        private System.Windows.Forms.Panel panelTotalGastado;
        private System.Windows.Forms.Label lblTotalGastadoTitulo;
        private System.Windows.Forms.Label lblTotalGastadoValor;
        private System.Windows.Forms.Panel panelEstadoCompras;
        private System.Windows.Forms.Label lblEstadoComprasTitulo;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblConfirmadas;
        private System.Windows.Forms.Label lblEntregadas;
        private System.Windows.Forms.Label lblCanceladas;
        private System.Windows.Forms.Label lblUltimasCompras;
        private System.Windows.Forms.DataGridView dgvUltimasCompras;
        private System.Windows.Forms.Label lblProductosFavoritos;
        private System.Windows.Forms.DataGridView dgvProductosFavoritos;
        private System.Windows.Forms.Button btnActualizar;
    }
}