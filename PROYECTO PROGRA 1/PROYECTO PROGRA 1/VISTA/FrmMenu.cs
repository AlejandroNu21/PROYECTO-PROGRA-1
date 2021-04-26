using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PROGRA_1.VISTA
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btnRUsuario_Click(object sender, EventArgs e)
        {
            
            FrmRUsuario Donante = new FrmRUsuario();
            Donante.Show();
            this.Hide();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            
            FrmAgendarCita Citas = new FrmAgendarCita();
            Citas.Show();
            this.Hide();
        }

        private void btnBuscarDonante_Click(object sender, EventArgs e)
        {
           
            FrmBuscarDonante Busqueda = new FrmBuscarDonante();
            Busqueda.Show();
            this.Hide();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void requisitosParaDonacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRequisitos Requisitos = new FrmRequisitos();
            Requisitos.Show();
            this.Hide();
        }

        private void porqueDonarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPDonar InfoDonacion = new FrmPDonar();
            InfoDonacion.Show();
            this.Hide();
        }

        private void btnCSanguinea_Click(object sender, EventArgs e)
        {
            FrmCompatibilidad Compatibilidad = new FrmCompatibilidad();
            Compatibilidad.Show();
            this.Hide();
        }
    }
}
