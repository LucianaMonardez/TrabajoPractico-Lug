using Business;
using Entity;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabajoPractico_Lug
{
    public partial class Form1 : Form
    {
        private PacienteBusiness pacienteBusiness = new PacienteBusiness();
        private TurnoBusiness _turnoBusiness = new TurnoBusiness();
        private List<Paciente> borradorPacientes = new List<Paciente>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarTurnoGrid();
        }

        #region ABM

        private void crearTurnoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Turno turno = ObtenerTurnoForm();
                _turnoBusiness.CrearTurno(turno, turnoDniTxt.Text);
                MessageBox.Show("Turno creado exitosamente");
                ReinciciarTextTurno();
                ActualizarTurnoGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrio un error al intentar agendar el turno: {ex.Message}");
            }

        }

        private void cancelarTurnoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _turnoBusiness.EliminarTurno(textBoxEliminarTurno.Text);
                ActualizarTurnoGrid();
                MessageBox.Show("Turno creado exitosamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrio un error al intentar agendar el turno: {ex.Message}");
            }
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
        #endregion




        #region UTILS
        private void ValidarDiaDatePickerTurno()
        {
            // Verificar si el día seleccionado es sábado o domingo
            if (dateTimePickerDia.Value.DayOfWeek == DayOfWeek.Saturday || dateTimePickerDia.Value.DayOfWeek == DayOfWeek.Sunday)
                throw new Exception("No se pueden seleccionar sábados ni domingos.");
        }

        private void ActualizarTurnoGrid()
        {
            dataGridViewTurnos.DataSource = null;
            dataGridViewTurnos.DataSource = _turnoBusiness.ObtenerTurnosDto();

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

        private void ReinciciarTextTurno()
        {
            turnoDniTxt.Clear();
        }

        private Turno ObtenerTurnoForm()
        {
            if (string.IsNullOrEmpty(turnoDniTxt.Text))
                throw new Exception("El campo dni no puede estar vacio");
            ValidarDiaDatePickerTurno();

            if (medicoCombobox.SelectedItem == null)
                throw new Exception("Debe seleccionar un medico para el turno");

            if (horarioMedicoCombobox.SelectedItem == null)
                throw new Exception("Debe seleccionar un horario para el turno");


            return new Turno(dateTimePickerDia.Value + TimeSpan.Parse(horarioMedicoCombobox.SelectedItem.ToString()),
                Convert.ToInt32(medicoCombobox.SelectedValue));
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

        #endregion

    }
}
