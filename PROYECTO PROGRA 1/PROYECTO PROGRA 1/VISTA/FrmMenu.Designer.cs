
namespace PROYECTO_PROGRA_1.VISTA
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btnRUsuario = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnBuscarDonante = new System.Windows.Forms.Button();
            this.btnSalirMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRUsuario
            // 
            this.btnRUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRUsuario.Location = new System.Drawing.Point(103, 52);
            this.btnRUsuario.Name = "btnRUsuario";
            this.btnRUsuario.Size = new System.Drawing.Size(131, 36);
            this.btnRUsuario.TabIndex = 0;
            this.btnRUsuario.Text = "Registar Usuario";
            this.btnRUsuario.UseVisualStyleBackColor = true;
            this.btnRUsuario.Click += new System.EventHandler(this.btnRUsuario_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.Location = new System.Drawing.Point(103, 120);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(131, 36);
            this.btnCitas.TabIndex = 1;
            this.btnCitas.Text = "Agendar una Cita";
            this.btnCitas.UseVisualStyleBackColor = true;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnBuscarDonante
            // 
            this.btnBuscarDonante.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDonante.Location = new System.Drawing.Point(103, 189);
            this.btnBuscarDonante.Name = "btnBuscarDonante";
            this.btnBuscarDonante.Size = new System.Drawing.Size(131, 36);
            this.btnBuscarDonante.TabIndex = 2;
            this.btnBuscarDonante.Text = "Buscar Donante";
            this.btnBuscarDonante.UseVisualStyleBackColor = true;
            this.btnBuscarDonante.Click += new System.EventHandler(this.btnBuscarDonante_Click);
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalirMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirMenu.Location = new System.Drawing.Point(210, 301);
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(100, 28);
            this.btnSalirMenu.TabIndex = 3;
            this.btnSalirMenu.Text = "SALIR";
            this.btnSalirMenu.UseVisualStyleBackColor = true;
            this.btnSalirMenu.Click += new System.EventHandler(this.btnSalirMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_PROGRA_1.Properties.Resources.banco_de_sangre_costa_rica6;
            this.pictureBox1.Location = new System.Drawing.Point(31, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CancelButton = this.btnSalirMenu;
            this.ClientSize = new System.Drawing.Size(322, 341);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalirMenu);
            this.Controls.Add(this.btnBuscarDonante);
            this.Controls.Add(this.btnCitas);
            this.Controls.Add(this.btnRUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu ";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRUsuario;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnBuscarDonante;
        private System.Windows.Forms.Button btnSalirMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}