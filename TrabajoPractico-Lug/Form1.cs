using Business;
using Entity;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabajoPractico_Lug
{
    public partial class Form1 : Form
    {
        private PacienteBusiness pacienteBusiness = new PacienteBusiness();
        private List<Paciente> borradorPacientes = new List<Paciente>();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarComponentes();
        }

        private void crearTurnoBtn_Click(object sender, EventArgs e)
        {

        }

       

        private Paciente GetPacienteFromForm()
        {
            Paciente pac = new Paciente();
            pac.Nombre = textBoxName.Text;
            pac.DNI = Convert.ToInt32(dniTxt.Text);
            pac.Direccion = textBoxDireccion.Text;
            pac.Telefono = textBoxTel.Text;
            pac.Mail = textBoxMail.Text;
            return pac;
        }

        private void ActualizarGridPaciente()
        {
            dataGridViewPacientes.DataSource = null;
            dataGridViewPacientes.DataSource = pacienteBusiness.GetAll();
        }
        private void ReinciciarTextPacientes()
        {
            textBoxDireccion.Text = "";
            textBoxName.Text = "";
            textBoxMail.Text = "";
            textBoxTel.Text = "";
        }

        private void buttonCrearPaciente_Click(object sender, EventArgs e)
        {
            Paciente paciente = GetPacienteFromForm();
            try
            {
                pacienteBusiness.CargarPaciente(paciente);
                ActualizarGridPaciente();
                MessageBox.Show("Paciente cargado correctamente");
                ReinciciarTextPacientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAgregarListaPaciente_Click(object sender, EventArgs e)
        {
            Paciente pac = GetPacienteFromForm();
            borradorPacientes.Add(pac);
            MessageBox.Show("Paciente Agregado a la lista");
            ReinciciarTextPacientes();
        }

        private void ButtonCargarLista_Click(object sender, EventArgs e)
        {
            try
            {
                pacienteBusiness.CargarPacientesMultiples(borradorPacientes);
                borradorPacientes.Clear();
                ActualizarGridPaciente();
                MessageBox.Show("Pacientes cargados correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonModPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                pacienteBusiness.Update(Convert.ToInt32(textBoxModPaciente.Text), textBoxName.Text, textBoxTel.Text, textBoxDireccion.Text, textBoxMail.Text);
                ActualizarGridPaciente();
                MessageBox.Show("Paciente modificado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEliminarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                pacienteBusiness.DeleteById(Convert.ToInt32(textBoxEliminarPaciente.Text));
                ActualizarGridPaciente();
                MessageBox.Show("Paciente eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Utils
        private void CargarComponentes()
        {
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            diaCombobox.Items.AddRange(dias);
        }
    }
}
