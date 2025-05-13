using System.Drawing;
using System.Windows.Forms;

namespace IE1
{
    public partial class frmPrincipal : Form
    {

        Cola esperaClinicaMedica = new Cola();
        Cola esperaPediatria = new Cola();
        Cola esperaGuardia = new Cola();

        frmClinica visorClinica = new frmClinica();
        frmGuardia visorGuardia = new frmGuardia();
        frmPediatría visorPediatria = new frmPediatría();

        private Paciente pacienteSeleccionado;


        public frmPrincipal()
        {
            InitializeComponent();
            visorClinica.Show();
            visorGuardia.Show();
            visorPediatria.Show();
            restaurar();

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!validarCamposPaciente()) return;
            if (cmbEspecialidad.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una especialidad.");
                return;
            }


            string especialidad = cmbEspecialidad.SelectedItem.ToString();
            Paciente nuevo = crearObjPaciente();

            switch (especialidad)
            {
                case "Clínica":
                    esperaClinicaMedica.Insertar(nuevo.dni, nuevo.nombre, nuevo.apellido);
                    esperaClinicaMedica.Listar(lstClinica);
                    backup();
                    break;
                case "Pediatría":
                    esperaPediatria.Insertar(nuevo.dni, nuevo.nombre, nuevo.apellido);
                    esperaPediatria.Listar(lstPediatria);
                    backup();
                    break;
                case "Guardia":
                    esperaGuardia.Insertar(nuevo.dni, nuevo.nombre, nuevo.apellido);
                    esperaGuardia.Listar(lstGuardia);
                    backup();
                    break;
                default:
                    MessageBox.Show("Especialidad no reconocida.");
                    return;
            }

            MessageBox.Show($"Paciente insertado en la cola de {especialidad}.");

            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
        }


        private Paciente crearObjPaciente()
        {
            return new Paciente(txtDNI.Text, txtNombre.Text, txtApellido.Text)
            {
                estado = "En espera"
            };
        }

        private bool validarCamposPaciente()
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                cmbEspecialidad.SelectedItem == null)
            {
                MessageBox.Show("Complete todos los campos y seleccione una especialidad.");
                return false;
            }

            return true;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (optClinica.Checked)
            {
                if (esperaClinicaMedica.inicio != null)
                {
                    backup();
                    visorClinica.llamaPaciente(esperaClinicaMedica.inicio);
                    esperaClinicaMedica.Eliminar();
                    esperaClinicaMedica.Listar(lstClinica);
                    List<string> lista = esperaClinicaMedica.devolverRegistros();
                    visorClinica.mostrarProximos(lista);

                }
                else
                {
                    MessageBox.Show("No hay pacientes en Clínica Médica.");
                }
            }
            else if (optPediatria.Checked)
            {
                if (esperaPediatria.inicio != null)
                {
                    backup();
                    visorPediatria.llamaPaciente(esperaPediatria.inicio);
                    esperaPediatria.Eliminar();
                    esperaPediatria.Listar(lstPediatria);
                    List<string> lista = esperaPediatria.devolverRegistros();
                    visorPediatria.mostrarProximos(lista);
                }
                else
                {
                    MessageBox.Show("No hay pacientes en Pediatría.");
                }
            }
            else if (optGuardia.Checked)
            {
                if (esperaGuardia.inicio != null)
                {
                    backup();
                    visorGuardia.llamaPaciente(esperaGuardia.inicio);
                    esperaGuardia.Eliminar();
                    esperaGuardia.Listar(lstGuardia);
                    List<string> lista = esperaGuardia.devolverRegistros();
                    visorGuardia.mostrarProximos(lista);

                }
                else
                {
                    MessageBox.Show("No hay pacientes en Guardia.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una especialidad.");
            }
        }


        public void backup()
        {
            List<string> listaClinica = esperaClinicaMedica.devolverRegistros(false);
            using (StreamWriter escribir = File.CreateText("backup_clinica.txt"))
            {
                foreach (string registro in listaClinica)
                {
                    escribir.WriteLine(registro);
                }
            }

            List<string> listaPediatria = esperaPediatria.devolverRegistros(false);
            using (StreamWriter escribir = File.CreateText("backup_pediatria.txt"))
            {
                foreach (string registro in listaPediatria)
                {
                    escribir.WriteLine(registro);
                }
            }

            List<string> listaGuardia = esperaGuardia.devolverRegistros(false);
            using (StreamWriter escribir = File.CreateText("backup_guardia.txt"))
            {
                foreach (string registro in listaGuardia)
                {
                    escribir.WriteLine(registro);
                }
            }
        }


        public void restaurar()
        {
            restaurarDesdeArchivo("backup_clinica.txt", esperaClinicaMedica, lstClinica);
            restaurarDesdeArchivo("backup_pediatria.txt", esperaPediatria, lstPediatria);
            restaurarDesdeArchivo("backup_guardia.txt", esperaGuardia, lstGuardia);
        }

        private void restaurarDesdeArchivo(string archivo, Cola cola, ListBox lista)
        {
            if (!File.Exists(archivo)) return;

            using (StreamReader leer = File.OpenText(archivo))
            {
                string registro = leer.ReadLine();
                while (registro != null)
                {
                    string[] campos = registro.Split(',');

                    if (campos.Length >= 4)
                    {
                        string dni = campos[0].Trim();
                        string nombre = campos[1].Trim();
                        string apellido = campos[2].Trim();
                        string estado = campos[3].Trim();

                        if (estado != "Eliminado")
                        {
                            Paciente p = new Paciente(dni, nombre, apellido);
                            p.estado = estado;
                            cola.InsertarExistente(p);
                        }
                    }

                    registro = leer.ReadLine();
                }
            }

            cola.Listar(lista);
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pacienteSeleccionado != null)
            {
                pacienteSeleccionado.estado = "Eliminado";
                esperaClinicaMedica.Listar(lstClinica);
                esperaPediatria.Listar(lstPediatria);
                esperaGuardia.Listar(lstGuardia);
                MessageBox.Show("Paciente marcado como eliminado.");
                backup();
                limpiar();
            }
            else
            {
                MessageBox.Show("Seleccione un paciente con doble clic.");
            }
        }


        private void limpiar()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            cmbEspecialidad.SelectedIndex = -1;
            pacienteSeleccionado = null;
        }

        private void lstClinica_DoubleClick(object sender, EventArgs e)
        {
            if (lstClinica.SelectedItem == null) return;

            string itemSeleccionado = lstClinica.SelectedItem.ToString();
            string dniSeleccionado = itemSeleccionado.Split('-')[0].Trim();

            Paciente aux = esperaClinicaMedica.inicio;
            while (aux != null)
            {
                if (aux.dni == dniSeleccionado)
                {
                    pacienteSeleccionado = aux;
                    txtDNI.Text = aux.dni;
                    txtNombre.Text = aux.nombre;
                    txtApellido.Text = aux.apellido;
                    cmbEspecialidad.SelectedItem = "Clínica";
                    break;
                }
                aux = aux.siguiente;
            }
        }

        private void lstPediatria_DoubleClick(object sender, EventArgs e)
        {
            if (lstPediatria.SelectedItem == null) return;

            string itemSeleccionado = lstPediatria.SelectedItem.ToString();
            string dniSeleccionado = itemSeleccionado.Split('-')[0].Trim();

            Paciente aux = esperaPediatria.inicio;
            while (aux != null)
            {
                if (aux.dni == dniSeleccionado)
                {
                    pacienteSeleccionado = aux;
                    txtDNI.Text = aux.dni;
                    txtNombre.Text = aux.nombre;
                    txtApellido.Text = aux.apellido;
                    cmbEspecialidad.SelectedItem = "Pediatría";
                    break;
                }
                aux = aux.siguiente;
            }
        }

        private void lstGuardia_DoubleClick(object sender, EventArgs e)
        {
            if (lstGuardia.SelectedItem == null) return;

            string itemSeleccionado = lstGuardia.SelectedItem.ToString();
            string dniSeleccionado = itemSeleccionado.Split('-')[0].Trim();

            Paciente aux = esperaGuardia.inicio;
            while (aux != null)
            {
                if (aux.dni == dniSeleccionado)
                {
                    pacienteSeleccionado = aux;
                    txtDNI.Text = aux.dni;
                    txtNombre.Text = aux.nombre;
                    txtApellido.Text = aux.apellido;
                    cmbEspecialidad.SelectedItem = "Guardia";
                    break;
                }
                aux = aux.siguiente;
            }
        }

    }
}