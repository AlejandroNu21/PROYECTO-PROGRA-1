
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btnRUsuario = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnBuscarDonante = new System.Windows.Forms.Button();
            this.btnSalirMenu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iNFORMACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requisitosParaDonacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porqueDonarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCSanguinea = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRUsuario
            // 
            this.btnRUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRUsuario.Location = new System.Drawing.Point(103, 45);
            this.btnRUsuario.Name = "btnRUsuario";
            this.btnRUsuario.Size = new System.Drawing.Size(131, 43);
            this.btnRUsuario.TabIndex = 0;
            this.btnRUsuario.Text = "Registar Usuario";
            this.btnRUsuario.UseVisualStyleBackColor = true;
            this.btnRUsuario.Click += new System.EventHandler(this.btnRUsuario_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.Location = new System.Drawing.Point(103, 115);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(131, 41);
            this.btnCitas.TabIndex = 1;
            this.btnCitas.Text = "Agendar una Cita";
            this.btnCitas.UseVisualStyleBackColor = true;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnBuscarDonante
            // 
            this.btnBuscarDonante.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDonante.Location = new System.Drawing.Point(103, 185);
            this.btnBuscarDonante.Name = "btnBuscarDonante";
            this.btnBuscarDonante.Size = new System.Drawing.Size(131, 40);
            this.btnBuscarDonante.TabIndex = 2;
            this.btnBuscarDonante.Text = "Buscar Donante";
            this.btnBuscarDonante.UseVisualStyleBackColor = true;
            this.btnBuscarDonante.Click += new System.EventHandler(this.btnBuscarDonante_Click);
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalirMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirMenu.Location = new System.Drawing.Point(237, 355);
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(100, 28);
            this.btnSalirMenu.TabIndex = 3;
            this.btnSalirMenu.Text = "SALIR";
            this.btnSalirMenu.UseVisualStyleBackColor = true;
            this.btnSalirMenu.Click += new System.EventHandler(this.btnSalirMenu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // iNFORMACIONToolStripMenuItem
            // 
            this.iNFORMACIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requisitosParaDonacionesToolStripMenuItem,
            this.porqueDonarToolStripMenuItem});
            this.iNFORMACIONToolStripMenuItem.Name = "iNFORMACIONToolStripMenuItem";
            this.iNFORMACIONToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.iNFORMACIONToolStripMenuItem.Text = "INFORMACION";
            // 
            // requisitosParaDonacionesToolStripMenuItem
            // 
            this.requisitosParaDonacionesToolStripMenuItem.Name = "requisitosParaDonacionesToolStripMenuItem";
            this.requisitosParaDonacionesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.requisitosParaDonacionesToolStripMenuItem.Text = "Requisitos para Donaciones";
            this.requisitosParaDonacionesToolStripMenuItem.Click += new System.EventHandler(this.requisitosParaDonacionesToolStripMenuItem_Click);
            // 
            // porqueDonarToolStripMenuItem
            // 
            this.porqueDonarToolStripMenuItem.Name = "porqueDonarToolStripMenuItem";
            this.porqueDonarToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.porqueDonarToolStripMenuItem.Text = "¿Porque Donar?";
            this.porqueDonarToolStripMenuItem.Click += new System.EventHandler(this.porqueDonarToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNFORMACIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(349, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnCSanguinea
            // 
            this.btnCSanguinea.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSanguinea.Location = new System.Drawing.Point(103, 243);
            this.btnCSanguinea.Name = "btnCSanguinea";
            this.btnCSanguinea.Size = new System.Drawing.Size(131, 58);
            this.btnCSanguinea.TabIndex = 6;
            this.btnCSanguinea.Text = "Compatibilidad Sanguinea";
            this.btnCSanguinea.UseVisualStyleBackColor = true;
            this.btnCSanguinea.Click += new System.EventHandler(this.btnCSanguinea_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_PROGRA_1.Properties.Resources.donar_sangre;
            this.pictureBox1.Location = new System.Drawing.Point(12, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnSalirMenu;
            this.ClientSize = new System.Drawing.Size(349, 395);
            this.Controls.Add(this.btnCSanguinea);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalirMenu);
            this.Controls.Add(this.btnBuscarDonante);
            this.Controls.Add(this.btnCitas);
            this.Controls.Add(this.btnRUsuario);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Menu";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRUsuario;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnBuscarDonante;
        private System.Windows.Forms.Button btnSalirMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNFORMACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requisitosParaDonacionesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem porqueDonarToolStripMenuItem;
        private System.Windows.Forms.Button btnCSanguinea;
    }
}