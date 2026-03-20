namespace LibreriaADS
{
    partial class Marca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marca));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvmarca = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.btncrear = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmarca)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(400, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "MARCAS";
            // 
            // dgvmarca
            // 
            this.dgvmarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmarca.Location = new System.Drawing.Point(36, 258);
            this.dgvmarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvmarca.Name = "dgvmarca";
            this.dgvmarca.RowHeadersWidth = 62;
            this.dgvmarca.RowTemplate.Height = 28;
            this.dgvmarca.Size = new System.Drawing.Size(855, 258);
            this.dgvmarca.TabIndex = 3;
            this.dgvmarca.SelectionChanged += new System.EventHandler(this.dgvmarca_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(63, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de la marca";
            // 
            // txtmarca
            // 
            this.txtmarca.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtmarca.Location = new System.Drawing.Point(60, 135);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(347, 39);
            this.txtmarca.TabIndex = 5;
            this.txtmarca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btncrear
            // 
            this.btncrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncrear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btncrear.Location = new System.Drawing.Point(36, 200);
            this.btncrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(133, 38);
            this.btncrear.TabIndex = 6;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = false;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnactualizar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnactualizar.Location = new System.Drawing.Point(634, 132);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(219, 42);
            this.btnactualizar.TabIndex = 7;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btneliminar.Location = new System.Drawing.Point(634, 80);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(219, 42);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Location = new System.Drawing.Point(634, 178);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(219, 42);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvmarca);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Marca";
            this.Size = new System.Drawing.Size(947, 575);
            this.Load += new System.EventHandler(this.Marca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvmarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}