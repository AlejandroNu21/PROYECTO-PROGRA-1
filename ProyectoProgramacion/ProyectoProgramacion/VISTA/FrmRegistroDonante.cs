﻿using ProyectoProgramacion.MODEL;
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
    public partial class FrmRegistroDonante : Form
    {
        public object Dim { get; private set; }

        public FrmRegistroDonante()
        {
            InitializeComponent();
        }
        void Carga()
        {
            drgregistrodonante.Rows.Clear();

        }

        void Clear()
        {
            txtNombreDonante.Clear();
        }

        private void FrmRegistroUsuario_Load(object sender, EventArgs e)
        {
            using (DATOSPROYECTOEntities db = new DATOSPROYECTOEntities())

            
            {
                var Lista = db.Tbl_UserList1.ToList();

                foreach (var iteracion in Lista)
                {
                    btnAceptarUsuario.Enabled = false;
                    drgregistrodonante.Rows.Add(iteracion.Id, iteracion.NombreDonante, iteracion.Direccion, iteracion.Telefono, iteracion.Edad, iteracion.GrupoSanguineo);
                }
            }            
        }


    

        private void btnSalirUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String Id = drgregistrodonante.CurrentRow.Cells[0].Value.ToString();
            String NombreDonante = drgregistrodonante.CurrentRow.Cells[1].Value.ToString();
            String Direccion = drgregistrodonante.CurrentRow.Cells[2].Value.ToString();
            String Telefono = drgregistrodonante.CurrentRow.Cells[3].Value.ToString();
            String Edad = drgregistrodonante.CurrentRow.Cells[4].Value.ToString();
            String GrupoSanguineo = drgregistrodonante.CurrentRow.Cells[5].Value.ToString();


            txtId.Text = Id;
            txtNombreDonante.Text = NombreDonante;
            txtDireccion.Text = Direccion;
            txtTelefono.Text = Telefono;
            txtEdad.Text = Edad;
            CmbGrupoSanguineo.Text = GrupoSanguineo;
        }

        private void btnAceptarUsuario_Click(object sender, EventArgs e)
        {
            {
                using (DATOSPROYECTOEntities db = new DATOSPROYECTOEntities())
                {
                    Tbl_UserList1 userList = new Tbl_UserList1();

                    userList.NombreDonante = txtNombreDonante.Text;
                    userList.Direccion = txtDireccion.Text;
                    userList.Edad = Convert.ToInt32(txtEdad.Text);
                    userList.Telefono = Convert.ToInt32(txtTelefono.Text);
                    userList.GrupoSanguineo = CmbGrupoSanguineo.Text;
                    db.Tbl_UserList1.Add(userList);
                    db.SaveChanges();
                }
            }

        }

        private void txtNombreDonante_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void lblGrupoSanguineo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private class Public
        {
        }
    }
}