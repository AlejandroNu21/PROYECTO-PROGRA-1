using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoProgramacion.VISTA
{
    public partial class FrmAgendarCitas2 : Form
    {
        private List<Donante> Donantes = new List<Donante>();
        private int indice = -1;
        public FrmAgendarCitas2()
        {
            InitializeComponent();
        }

        private void btnSalirAgendarCita2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            Donante persona = new Donante();
            persona.Nombre = txtNombre.Text;
            persona.Hora = txtHora.Text;
            persona.Fecha = txtFecha.Text;
            if(indice > -1)
            {
                Donantes[indice] = persona;
                indice = -1;
            }
            else
            {
                Donantes.Add(persona);
            }
            
            actualizaVista();
            limpiaCampos();
        }
        private void actualizaVista()
        {
            dgvagendarcitas2.DataSource = null;
            dgvagendarcitas2.DataSource = Donantes;
            dgvagendarcitas2.ClearSelection();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAgendarCitas2_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader lector = new StreamReader("Agenda.txt")
                string linea;
                while ((linea=lector.ReadLine())!=null)
                {
                    int posicion;
                    Donante persona = new Donante();
                    posicion = linea.IndexOf("|");
                    persona.Nombre = linea.Substring(0, posicion);
                    linea = linea.Substring(posicion + 1);
                    posicion = linea.IndexOf("|");
                    persona.Hora = linea.Substring(0, posicion);
                    linea = linea.Substring(posicion + 1);
                    posicion = linea.IndexOf("|");
                    persona.Fecha = linea.Substring(0, posicion);
                    linea = linea.Substring(posicion + 1);
                    posicion = linea.IndexOf("|");
                    Donantes.Add(persona)
                }
                lector.Close();
                actualizaVista();

            }
            catch (Exception ec)
            {
                Console.WriteLine("Exception: " + ec.Message);
            }
            finally
            {
                Console.WriteLine("Ejecucion finalizada");
            }
        }

        private void dgvagendarcitas2_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow renglon = dgvagendarcitas2.SelectedRows[0];
            indice = dgvagendarcitas2.Rows.IndexOf(renglon);
            Donante persona = Donantes[indice];
            txtNombre.Text = persona.Nombre;
            txtHora.Text = persona.Hora;
            txtFecha.Text = persona.Fecha;
        }
        private void limpiaCampos()
        {
            txtNombre.Text = null;
            txtHora.Text = null;
            txtFecha.Text = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(indice>-1)
            {
                Donantes.RemoveAt(indice);
                actualizaVista();
                limpiaCampos();
                indice - 1;
            }
            else
            {
                MessageBox.Show("Seleccione el registro a borrar");
            }
        }

        private void btnFijar_Click(object sender, EventArgs e)
        {
            TextWriter Escribir = new StreamWriter("Agenda.txt");
            foreach(Donante persona in Donantes)
            {
                Escribir.WriteLine(persona.Nombre+"|"+persona.Hora+"|"+persona.Fecha+"|")
            }
            Escribir.Close();
            MessageBox.Show("Donantes Guardados");
        }
    }
}
