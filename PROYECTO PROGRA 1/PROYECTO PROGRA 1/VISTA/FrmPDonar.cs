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
    public partial class FrmPDonar : Form
    {
        public FrmPDonar()
        {
            InitializeComponent();
        }

        private void btnSalirPDonar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}