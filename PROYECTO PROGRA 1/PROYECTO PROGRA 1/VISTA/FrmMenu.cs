﻿using System;
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
        }

        private void btnRUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("<>-- BIENVENIDO--<>");
            FrmRUsuario Donante = new FrmRUsuario();
            Donante.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("<>-- BIENVENIDO --<>");
            FrmAgendarCita Citas = new FrmAgendarCita();
            Citas.Show();
        }

        private void btnBuscarDonante_Click(object sender, EventArgs e)
        {
            MessageBox.Show("<>-- BIENVENIDO --<>");
            FrmBuscarDonante Busqueda = new FrmBuscarDonante();
            Busqueda.Show();
        }
    }
}
