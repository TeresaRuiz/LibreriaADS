namespace LibreriaADS
{
    partial class CATEGORÍA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CATEGORÍA));
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvcategoria = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btneliminar.Location = new System.Drawing.Point(717, 79);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(183, 36);
            this.btneliminar.TabIndex = 15;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnactualizar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnactualizar.Location = new System.Drawing.Point(717, 131);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(183, 36);
            this.btnactualizar.TabIndex = 14;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btncrear
            // 
            this.btncrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncrear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btncrear.Location = new System.Drawing.Point(55, 193);
            this.btncrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(94, 41);
            this.btncrear.TabIndex = 13;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = false;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // txtcategoria
            // 
            this.txtcategoria.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtcategoria.Location = new System.Drawing.Point(55, 131);
            this.txtcategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(364, 39);
            this.txtcategoria.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre de la categoría";
            // 
            // dgvcategoria
            // 
            this.dgvcategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategoria.Location = new System.Drawing.Point(30, 262);
            this.dgvcategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvcategoria.Name = "dgvcategoria";
            this.dgvcategoria.RowHeadersWidth = 62;
            this.dgvcategoria.RowTemplate.Height = 28;
            this.dgvcategoria.Size = new System.Drawing.Size(870, 266);
            this.dgvcategoria.TabIndex = 10;
            this.dgvcategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcategoria_CellContentClick);
            this.dgvcategoria.SelectionChanged += new System.EventHandler(this.dgvcategoria_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(386, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 41);
            this.label2.TabIndex = 9;
            this.label2.Text = "CATEGORÍA";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Location = new System.Drawing.Point(716, 177);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(184, 39);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // CATEGORÍA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvcategoria);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CATEGORÍA";
            this.Size = new System.Drawing.Size(947, 575);
            this.Load += new System.EventHandler(this.Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvcategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
    }
}