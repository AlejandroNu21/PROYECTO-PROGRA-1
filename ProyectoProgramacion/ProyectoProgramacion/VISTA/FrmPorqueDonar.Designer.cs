
namespace ProyectoProgramacion.VISTA
{
    partial class FrmPorqueDonar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPorqueDonar));
            this.btnSalirPDonar = new System.Windows.Forms.Button();
            this.rtbporquedonar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSalirPDonar
            // 
            this.btnSalirPDonar.Location = new System.Drawing.Point(675, 367);
            this.btnSalirPDonar.Name = "btnSalirPDonar";
            this.btnSalirPDonar.Size = new System.Drawing.Size(113, 41);
            this.btnSalirPDonar.TabIndex = 1;
            this.btnSalirPDonar.Text = "SALIR";
            this.btnSalirPDonar.UseVisualStyleBackColor = true;
            this.btnSalirPDonar.Click += new System.EventHandler(this.btnSalirPDonar_Click);
            // 
            // rtbporquedonar
            // 
            this.rtbporquedonar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbporquedonar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbporquedonar.ForeColor = System.Drawing.Color.Black;
            this.rtbporquedonar.Location = new System.Drawing.Point(133, 27);
            this.rtbporquedonar.Name = "rtbporquedonar";
            this.rtbporquedonar.Size = new System.Drawing.Size(547, 283);
            this.rtbporquedonar.TabIndex = 2;
            this.rtbporquedonar.Text = resources.GetString("rtbporquedonar.Text");
            this.rtbporquedonar.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // FrmPorqueDonar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.rtbporquedonar);
            this.Controls.Add(this.btnSalirPDonar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPorqueDonar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Porque Donar";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalirPDonar;
        private System.Windows.Forms.RichTextBox rtbporquedonar;
    }
}