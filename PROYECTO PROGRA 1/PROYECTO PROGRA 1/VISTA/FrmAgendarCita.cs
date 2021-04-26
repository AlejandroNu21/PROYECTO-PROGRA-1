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
    public partial class FrmAgendarCita : Form
    {
        public FrmAgendarCita()
        {
            InitializeComponent();
        }

        private void btnAceptarNombre_Click(object sender, EventArgs e)
        {
            FrmAgendarCitas2 FechaCita = new FrmAgendarCitas2();
       
            FechaCita.Show();
            this.Hide();
        }
    }
}
