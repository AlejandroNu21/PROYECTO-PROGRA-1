﻿using System;
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
    public partial class FrmRegistroDonante : Form
    {
        public FrmRegistroDonante()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }
    }
}
