namespace LibreriaADS
{
    partial class Carga
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carga));
            this.bar_progres = new System.Windows.Forms.ProgressBar();
            this.hide = new System.Windows.Forms.Timer(this.components);
            this.animation = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar_progres
            // 
            this.bar_progres.BackColor = System.Drawing.Color.White;
            this.bar_progres.ForeColor = System.Drawing.Color.White;
            this.bar_progres.Location = new System.Drawing.Point(210, 449);
            this.bar_progres.Name = "bar_progres";
            this.bar_progres.Size = new System.Drawing.Size(678, 17);
            this.bar_progres.Step = 1;
            this.bar_progres.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.bar_progres.TabIndex = 2;
            // 
            // hide
            // 
            this.hide.Interval = 30;
            this.hide.Tick += new System.EventHandler(this.hide_Tick);
            // 
            // animation
            // 
            this.animation.Interval = 30;
            this.animation.Tick += new System.EventHandler(this.animation_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(909, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Carga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1070, 573);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bar_progres);
            this.Name = "Carga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librería";
            this.Load += new System.EventHandler(this.Carga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar bar_progres;
        private System.Windows.Forms.Timer hide;
        private System.Windows.Forms.Timer animation;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

