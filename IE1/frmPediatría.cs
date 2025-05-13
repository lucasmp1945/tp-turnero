using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE1
{
    public partial class frmPediatría : Form
    {

        Cola esperaPediatria = new Cola();

        public frmPediatría()
        {
            InitializeComponent();
        }

        public void llamaPaciente(Paciente llamado)
        {
            lblPaciente.Text = llamado.apellido.ToUpper() + ", " + llamado.nombre;
            lblDNI.Text = llamado.dni;
        }

        public void mostrarProximos(List<string> lista)
        {
            MessageBox.Show("fun");

            lstProximos.Items.Clear();

            if (lista.Count == 0)
            {
                lstProximos.Items.Add("No hay más pacientes.");
                return;
            }

            foreach (string item in lista)
            {
                lstProximos.Items.Add(item);
            }
        }



        public void mostrarConsultario()
        {
            Random rnd = new Random();
            lblConsultorio.Text = "PED" + rnd.Next(1, 5).ToString("000#");
        }
    }
}
