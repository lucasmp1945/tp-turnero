using System.Drawing;

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


        public frmPrincipal()
        {
            InitializeComponent();
            visorClinica.Show();
            visorGuardia.Show();
            visorPediatria.Show();  

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
                    break;
                case "Pediatría":
                    esperaPediatria.Insertar(nuevo.dni, nuevo.nombre, nuevo.apellido);
                    esperaPediatria.Listar(lstPediatria);
                    break;
                case "Guardia":
                    esperaGuardia.Insertar(nuevo.dni, nuevo.nombre, nuevo.apellido);
                    esperaGuardia.Listar(lstGuardia);
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
                vigente = true
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
                    visorClinica.llamaPaciente(esperaClinicaMedica.inicio);
                    esperaClinicaMedica.Eliminar();
                    esperaClinicaMedica.Listar(lstClinica);

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
                    visorPediatria.llamaPaciente(esperaPediatria.inicio);
                    esperaPediatria.Eliminar();
                    esperaPediatria.Listar(lstPediatria);
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
                    visorGuardia.llamaPaciente(esperaGuardia.inicio);
                    esperaGuardia.Eliminar();
                    esperaGuardia.Listar(lstGuardia);

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

    }
}