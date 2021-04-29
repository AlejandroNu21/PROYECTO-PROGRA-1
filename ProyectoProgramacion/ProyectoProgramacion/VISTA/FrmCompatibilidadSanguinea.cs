using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion.VISTA
{
    public partial class FrmCompatibilidadSanguinea : Form
    {
        public FrmCompatibilidadSanguinea()
        {
            InitializeComponent();
        }

        private void btnSalirTipoSangre_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }
    }
}
