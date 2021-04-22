
namespace PROYECTO_PROGRA_1.VISTA
{
    partial class FrmAgendarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendarCita));
            this.btnAceptarNombre = new System.Windows.Forms.Button();
            this.txtIngresarN = new System.Windows.Forms.TextBox();
            this.lblIngresarN = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptarNombre
            // 
            this.btnAceptarNombre.Location = new System.Drawing.Point(165, 148);
            this.btnAceptarNombre.Name = "btnAceptarNombre";
            this.btnAceptarNombre.Size = new System.Drawing.Size(128, 47);
            this.btnAceptarNombre.TabIndex = 0;
            this.btnAceptarNombre.Text = "ACEPTAR";
            this.btnAceptarNombre.UseVisualStyleBackColor = true;
            this.btnAceptarNombre.Click += new System.EventHandler(this.btnAceptarNombre_Click);
            // 
            // txtIngresarN
            // 
            this.txtIngresarN.Location = new System.Drawing.Point(106, 112);
            this.txtIngresarN.Name = "txtIngresarN";
            this.txtIngresarN.Size = new System.Drawing.Size(240, 20);
            this.txtIngresarN.TabIndex = 1;
            // 
            // lblIngresarN
            // 
            this.lblIngresarN.AutoSize = true;
            this.lblIngresarN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarN.Location = new System.Drawing.Point(147, 69);
            this.lblIngresarN.Name = "lblIngresarN";
            this.lblIngresarN.Size = new System.Drawing.Size(169, 19);
            this.lblIngresarN.TabIndex = 2;
            this.lblIngresarN.Text = "INGRESE SU NOMBRE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_PROGRA_1.Properties.Resources._0sagree;
            this.pictureBox1.Location = new System.Drawing.Point(329, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(454, 312);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIngresarN);
            this.Controls.Add(this.txtIngresarN);
            this.Controls.Add(this.btnAceptarNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgendarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarNombre;
        private System.Windows.Forms.TextBox txtIngresarN;
        private System.Windows.Forms.Label lblIngresarN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}