
namespace ProyectoProgramacion.VISTA
{
    partial class FrmBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBienvenida));
            this.btnIngresarBienvenida = new System.Windows.Forms.Button();
            this.btnSalirBienvenida = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.pbsangre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbsangre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarBienvenida
            // 
            this.btnIngresarBienvenida.Location = new System.Drawing.Point(124, 255);
            this.btnIngresarBienvenida.Name = "btnIngresarBienvenida";
            this.btnIngresarBienvenida.Size = new System.Drawing.Size(119, 43);
            this.btnIngresarBienvenida.TabIndex = 0;
            this.btnIngresarBienvenida.Text = "INGRESAR";
            this.btnIngresarBienvenida.UseVisualStyleBackColor = true;
            this.btnIngresarBienvenida.Click += new System.EventHandler(this.btnIngresarBienvenida_Click);
            // 
            // btnSalirBienvenida
            // 
            this.btnSalirBienvenida.Location = new System.Drawing.Point(315, 255);
            this.btnSalirBienvenida.Name = "btnSalirBienvenida";
            this.btnSalirBienvenida.Size = new System.Drawing.Size(119, 43);
            this.btnSalirBienvenida.TabIndex = 1;
            this.btnSalirBienvenida.Text = "SALIR";
            this.btnSalirBienvenida.UseVisualStyleBackColor = true;
            this.btnSalirBienvenida.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(181, 217);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(189, 13);
            this.lblBienvenida.TabIndex = 3;
            this.lblBienvenida.Text = "BIENVENIDO A NUESTRO SISTEMA";
            // 
            // pbsangre
            // 
            this.pbsangre.Image = ((System.Drawing.Image)(resources.GetObject("pbsangre.Image")));
            this.pbsangre.Location = new System.Drawing.Point(114, 47);
            this.pbsangre.Name = "pbsangre";
            this.pbsangre.Size = new System.Drawing.Size(329, 151);
            this.pbsangre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsangre.TabIndex = 2;
            this.pbsangre.TabStop = false;
            // 
            // FrmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 331);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.pbsangre);
            this.Controls.Add(this.btnSalirBienvenida);
            this.Controls.Add(this.btnIngresarBienvenida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.FrmBienvenida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbsangre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarBienvenida;
        private System.Windows.Forms.Button btnSalirBienvenida;
        private System.Windows.Forms.PictureBox pbsangre;
        private System.Windows.Forms.Label lblBienvenida;
    }
}