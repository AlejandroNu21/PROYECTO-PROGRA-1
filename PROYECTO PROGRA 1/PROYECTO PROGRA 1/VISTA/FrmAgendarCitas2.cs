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
    public partial class FrmAgendarCitas2 : Form
    {
        public FrmAgendarCitas2()
        {
            InitializeComponent();
        }

        private void btnRMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }

        private void FrmAgendarCitas2_Load(object sender, EventArgs e)
        {

        }
    }
}
