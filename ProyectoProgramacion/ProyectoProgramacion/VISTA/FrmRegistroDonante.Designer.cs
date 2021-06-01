
namespace ProyectoProgramacion.VISTA
{
    partial class FrmRegistroDonante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroDonante));
            this.btnAceptarUsuario = new System.Windows.Forms.Button();
            this.btnSalirUsuario = new System.Windows.Forms.Button();
            this.drgregistrodonante = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombreDonante = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblNombreDonante = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblGrupoSanguineo = new System.Windows.Forms.Label();
            this.CmbGrupoSanguineo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnbuscarfoto = new System.Windows.Forms.Button();
            this.btneliminarfoto = new System.Windows.Forms.Button();
            this.rdbmasculino = new System.Windows.Forms.RadioButton();
            this.rdbfemenino = new System.Windows.Forms.RadioButton();
            this.grpgenero = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.drgregistrodonante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpgenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptarUsuario
            // 
            this.btnAceptarUsuario.Location = new System.Drawing.Point(272, 402);
            this.btnAceptarUsuario.Name = "btnAceptarUsuario";
            this.btnAceptarUsuario.Size = new System.Drawing.Size(112, 36);
            this.btnAceptarUsuario.TabIndex = 17;
            this.btnAceptarUsuario.Text = "Aceptar";
            this.btnAceptarUsuario.UseVisualStyleBackColor = true;
            this.btnAceptarUsuario.Click += new System.EventHandler(this.btnAceptarUsuario_Click);
            // 
            // btnSalirUsuario
            // 
            this.btnSalirUsuario.Location = new System.Drawing.Point(466, 402);
            this.btnSalirUsuario.Name = "btnSalirUsuario";
            this.btnSalirUsuario.Size = new System.Drawing.Size(112, 36);
            this.btnSalirUsuario.TabIndex = 18;
            this.btnSalirUsuario.Text = "SALIR";
            this.btnSalirUsuario.UseVisualStyleBackColor = true;
            this.btnSalirUsuario.Click += new System.EventHandler(this.btnSalirUsuario_Click);
            // 
            // drgregistrodonante
            // 
            this.drgregistrodonante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drgregistrodonante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drgregistrodonante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drgregistrodonante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.drgregistrodonante.Location = new System.Drawing.Point(68, 246);
            this.drgregistrodonante.Name = "drgregistrodonante";
            this.drgregistrodonante.Size = new System.Drawing.Size(650, 150);
            this.drgregistrodonante.TabIndex = 11;
            this.drgregistrodonante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Donante";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dirección";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Teléfono";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Edad";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Grupo Sanguíneo";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Género";
            this.Column7.Name = "Column7";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(81, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Id:";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(106, 25);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(180, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "0000";
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtNombreDonante
            // 
            this.txtNombreDonante.Location = new System.Drawing.Point(106, 51);
            this.txtNombreDonante.Name = "txtNombreDonante";
            this.txtNombreDonante.Size = new System.Drawing.Size(180, 20);
            this.txtNombreDonante.TabIndex = 2;
            this.txtNombreDonante.TextChanged += new System.EventHandler(this.txtNombreDonante_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(106, 103);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(180, 50);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(106, 77);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(180, 20);
            this.txtEdad.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(106, 160);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // lblNombreDonante
            // 
            this.lblNombreDonante.AutoSize = true;
            this.lblNombreDonante.Location = new System.Drawing.Point(53, 58);
            this.lblNombreDonante.Name = "lblNombreDonante";
            this.lblNombreDonante.Size = new System.Drawing.Size(47, 13);
            this.lblNombreDonante.TabIndex = 16;
            this.lblNombreDonante.Text = "Nombre:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(48, 106);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 14;
            this.lblDireccion.Text = "Dirección:";
            this.lblDireccion.Click += new System.EventHandler(this.lblDireccion_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(65, 84);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 15;
            this.lblEdad.Text = "Edad:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(51, 163);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblGrupoSanguineo
            // 
            this.lblGrupoSanguineo.AutoSize = true;
            this.lblGrupoSanguineo.Location = new System.Drawing.Point(7, 195);
            this.lblGrupoSanguineo.Name = "lblGrupoSanguineo";
            this.lblGrupoSanguineo.Size = new System.Drawing.Size(95, 13);
            this.lblGrupoSanguineo.TabIndex = 12;
            this.lblGrupoSanguineo.Text = "Grupo Sanguíneo:";
            this.lblGrupoSanguineo.Click += new System.EventHandler(this.lblGrupoSanguineo_Click);
            // 
            // CmbGrupoSanguineo
            // 
            this.CmbGrupoSanguineo.FormattingEnabled = true;
            this.CmbGrupoSanguineo.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.CmbGrupoSanguineo.Location = new System.Drawing.Point(106, 187);
            this.CmbGrupoSanguineo.Name = "CmbGrupoSanguineo";
            this.CmbGrupoSanguineo.Size = new System.Drawing.Size(121, 21);
            this.CmbGrupoSanguineo.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(647, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(311, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnbuscarfoto
            // 
            this.btnbuscarfoto.Location = new System.Drawing.Point(376, 185);
            this.btnbuscarfoto.Name = "btnbuscarfoto";
            this.btnbuscarfoto.Size = new System.Drawing.Size(30, 23);
            this.btnbuscarfoto.TabIndex = 7;
            this.btnbuscarfoto.Text = "...";
            this.btnbuscarfoto.UseVisualStyleBackColor = true;
            // 
            // btneliminarfoto
            // 
            this.btneliminarfoto.Location = new System.Drawing.Point(421, 185);
            this.btneliminarfoto.Name = "btneliminarfoto";
            this.btneliminarfoto.Size = new System.Drawing.Size(30, 23);
            this.btneliminarfoto.TabIndex = 8;
            this.btneliminarfoto.Text = "X";
            this.btneliminarfoto.UseVisualStyleBackColor = true;
            // 
            // rdbmasculino
            // 
            this.rdbmasculino.AutoSize = true;
            this.rdbmasculino.Checked = true;
            this.rdbmasculino.Location = new System.Drawing.Point(18, 11);
            this.rdbmasculino.Name = "rdbmasculino";
            this.rdbmasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbmasculino.TabIndex = 0;
            this.rdbmasculino.TabStop = true;
            this.rdbmasculino.Text = "Masculino";
            this.rdbmasculino.UseVisualStyleBackColor = true;
            // 
            // rdbfemenino
            // 
            this.rdbfemenino.AutoSize = true;
            this.rdbfemenino.Location = new System.Drawing.Point(18, 34);
            this.rdbfemenino.Name = "rdbfemenino";
            this.rdbfemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbfemenino.TabIndex = 1;
            this.rdbfemenino.Text = "Femenino";
            this.rdbfemenino.UseVisualStyleBackColor = true;
            // 
            // grpgenero
            // 
            this.grpgenero.Controls.Add(this.rdbfemenino);
            this.grpgenero.Controls.Add(this.rdbmasculino);
            this.grpgenero.Location = new System.Drawing.Point(486, 58);
            this.grpgenero.Name = "grpgenero";
            this.grpgenero.Size = new System.Drawing.Size(115, 77);
            this.grpgenero.TabIndex = 9;
            this.grpgenero.TabStop = false;
            this.grpgenero.Text = "Genero";
            // 
            // FrmRegistroDonante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpgenero);
            this.Controls.Add(this.btneliminarfoto);
            this.Controls.Add(this.btnbuscarfoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CmbGrupoSanguineo);
            this.Controls.Add(this.lblGrupoSanguineo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombreDonante);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombreDonante);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.drgregistrodonante);
            this.Controls.Add(this.btnSalirUsuario);
            this.Controls.Add(this.btnAceptarUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistroDonante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuario";
            this.Load += new System.EventHandler(this.FrmRegistroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drgregistrodonante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpgenero.ResumeLayout(false);
            this.grpgenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarUsuario;
        private System.Windows.Forms.Button btnSalirUsuario;
        private System.Windows.Forms.DataGridView drgregistrodonante;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombreDonante;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblNombreDonante;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblGrupoSanguineo;
        private System.Windows.Forms.ComboBox CmbGrupoSanguineo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btneliminarfoto;
        private System.Windows.Forms.Button btnbuscarfoto;
        private System.Windows.Forms.GroupBox grpgenero;
        private System.Windows.Forms.RadioButton rdbfemenino;
        private System.Windows.Forms.RadioButton rdbmasculino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}