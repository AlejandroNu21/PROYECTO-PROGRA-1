
namespace PROYECTO_PROGRA_1.VISTA
{
    partial class FrmBuscarDonante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarDonante));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDonanteaBuscar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDonanteaBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminarDonante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(3, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre_de_Donante";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Direccion";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefono";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Edad";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Grupo_Sanguineo";
            this.Column6.Name = "Column6";
            // 
            // lblDonanteaBuscar
            // 
            this.lblDonanteaBuscar.AutoSize = true;
            this.lblDonanteaBuscar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonanteaBuscar.Location = new System.Drawing.Point(304, 50);
            this.lblDonanteaBuscar.Name = "lblDonanteaBuscar";
            this.lblDonanteaBuscar.Size = new System.Drawing.Size(219, 18);
            this.lblDonanteaBuscar.TabIndex = 1;
            this.lblDonanteaBuscar.Text = "Ingrese Donante a Buscar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(429, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDonanteaBuscar
            // 
            this.txtDonanteaBuscar.Location = new System.Drawing.Point(270, 103);
            this.txtDonanteaBuscar.Name = "txtDonanteaBuscar";
            this.txtDonanteaBuscar.Size = new System.Drawing.Size(274, 20);
            this.txtDonanteaBuscar.TabIndex = 3;
            // 
            // btnEliminarDonante
            // 
            this.btnEliminarDonante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminarDonante.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDonante.Location = new System.Drawing.Point(213, 352);
            this.btnEliminarDonante.Name = "btnEliminarDonante";
            this.btnEliminarDonante.Size = new System.Drawing.Size(141, 40);
            this.btnEliminarDonante.TabIndex = 4;
            this.btnEliminarDonante.Text = "ELIMINAR";
            this.btnEliminarDonante.UseVisualStyleBackColor = false;
            // 
            // FrmBuscarDonante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(774, 418);
            this.Controls.Add(this.btnEliminarDonante);
            this.Controls.Add(this.txtDonanteaBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDonanteaBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBuscarDonante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Donantes";
            this.Load += new System.EventHandler(this.FrmBuscarDonante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDonanteaBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDonanteaBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnEliminarDonante;
    }
}