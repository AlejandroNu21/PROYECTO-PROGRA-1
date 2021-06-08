
namespace ProyectoProgramacion.VISTA
{
    partial class FrmCompatibilidadSanguinea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompatibilidadSanguinea));
            this.btnSalirTipoSangre = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTipoSangre = new System.Windows.Forms.Label();
            this.CmbTipoSangre = new System.Windows.Forms.ComboBox();
            this.btnCompatibilidadSanguinea = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirTipoSangre
            // 
            this.btnSalirTipoSangre.Location = new System.Drawing.Point(478, 356);
            this.btnSalirTipoSangre.Name = "btnSalirTipoSangre";
            this.btnSalirTipoSangre.Size = new System.Drawing.Size(108, 42);
            this.btnSalirTipoSangre.TabIndex = 0;
            this.btnSalirTipoSangre.Text = "SALIR";
            this.btnSalirTipoSangre.UseVisualStyleBackColor = true;
            this.btnSalirTipoSangre.Click += new System.EventHandler(this.btnSalirTipoSangre_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(23, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(563, 137);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblTipoSangre
            // 
            this.lblTipoSangre.AutoSize = true;
            this.lblTipoSangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoSangre.Location = new System.Drawing.Point(86, 41);
            this.lblTipoSangre.Name = "lblTipoSangre";
            this.lblTipoSangre.Size = new System.Drawing.Size(172, 16);
            this.lblTipoSangre.TabIndex = 2;
            this.lblTipoSangre.Text = "Ingrese Tipo de Sangre";
            // 
            // CmbTipoSangre
            // 
            this.CmbTipoSangre.FormattingEnabled = true;
            this.CmbTipoSangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.CmbTipoSangre.Location = new System.Drawing.Point(89, 82);
            this.CmbTipoSangre.Name = "CmbTipoSangre";
            this.CmbTipoSangre.Size = new System.Drawing.Size(169, 21);
            this.CmbTipoSangre.TabIndex = 3;
            // 
            // btnCompatibilidadSanguinea
            // 
            this.btnCompatibilidadSanguinea.Location = new System.Drawing.Point(300, 103);
            this.btnCompatibilidadSanguinea.Name = "btnCompatibilidadSanguinea";
            this.btnCompatibilidadSanguinea.Size = new System.Drawing.Size(79, 27);
            this.btnCompatibilidadSanguinea.TabIndex = 4;
            this.btnCompatibilidadSanguinea.Text = "BUSCAR";
            this.btnCompatibilidadSanguinea.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Paciente";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Grupo Sanguíneo";
            this.Column3.Name = "Column3";
            // 
            // FrmCompatibilidadSanguinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 419);
            this.Controls.Add(this.btnCompatibilidadSanguinea);
            this.Controls.Add(this.CmbTipoSangre);
            this.Controls.Add(this.lblTipoSangre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalirTipoSangre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCompatibilidadSanguinea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compatibilidad Sanguinea";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirTipoSangre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTipoSangre;
        private System.Windows.Forms.ComboBox CmbTipoSangre;
        private System.Windows.Forms.Button btnCompatibilidadSanguinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}