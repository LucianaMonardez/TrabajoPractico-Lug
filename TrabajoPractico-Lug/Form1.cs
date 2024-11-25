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
        private MedicoBusiness _medicoBusiness = new MedicoBusiness();
        private EspecialidadBusiness _especialidadBusiness = new EspecialidadBusiness();
        private ClinicaBusiness _clinicaBusiness = new ClinicaBusiness();
        private List<Paciente> borradorPacientes = new List<Paciente>();
        private List<Clinica> listaClinicas = new List<Clinica>();
        public Form1()
        {
            InitializeComponent();

        }

        private void PreCargarClases()
        {
            EspecialidadCombobox.ValueMember = "Id";
            EspecialidadCombobox.DisplayMember = "Descripcion";
            EspecialidadCombobox.DataSource = _especialidadBusiness.ObtenerEspecialidadesPorClinica(1);
            medicoCombobox.ValueMember = "Id";
            medicoCombobox.DisplayMember = "Nombre";
            medicoCombobox.DataSource = _medicoBusiness.ObtenerMedicosEspecialidad(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarTurnoGrid(null);
            ActualizarGridPaciente();
            ObtenerClinicaCombobox();
            PreCargarClases();
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
                ActualizarTurnoGrid(null);
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
                ActualizarTurnoGrid(null);
                MessageBox.Show("Turno cancelado exitosamente");
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
                pacienteBusiness.Update(Convert.ToInt32(textBoxModPaciente.Text), textBoxName.Text, textBoxTel.Text, textBoxDireccion.Text, textBoxMail.Text, dniTxt.Text);
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
                _turnoBusiness.EliminarTurnoPorPaciente(Convert.ToInt32(textBoxEliminarPaciente.Text));
                pacienteBusiness.DeleteById(Convert.ToInt32(textBoxEliminarPaciente.Text));
                ActualizarGridPaciente();
                ActualizarTurnoGrid(null);
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

        private void ActualizarTurnoGrid(int? clinicaId)
        {
            dataGridViewTurnos.DataSource = null;
            dataGridViewTurnos.DataSource = clinicaId == null ?  _turnoBusiness.ObtenerTurnosDto() : _turnoBusiness.ObtenerTurnosDtoPorClinica((int) clinicaId);

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
            dniTxt.Text = "";
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


            return new Turno(dateTimePickerDia.Value.Date + TimeSpan.Parse(horarioMedicoCombobox.SelectedItem.ToString()),
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

        private void ObtenerClinicaCombobox() 
        {
            clinicaComboBox.DataSource = _clinicaBusiness.ObtenerClinicas();
            clinicaComboBox.DisplayMember = "Nombre";
            clinicaComboBox.ValueMember = "Id";
        }

        private void ActualizarDropDownHoraMedico(object sender, EventArgs e)
        {
            if (medicoCombobox.SelectedItem == null)
            {
                horarioMedicoCombobox.DataSource = null;
                return;
            }

            if (medicoCombobox.SelectedItem is Medico medicoSeleccionado)
            {
                int idMedico = medicoSeleccionado.Id;

                List<TimeSpan> horario = _medicoBusiness.ObtenerHorarioMedico(idMedico);
                List<string> turnosFormateados = horario.Select(t => t.ToString(@"hh\:mm")).ToList();

                horarioMedicoCombobox.DataSource = turnosFormateados;

            }
            else
            {
                MessageBox.Show("No se seleccionó un médico.");
            }

        }

        private void ActualizarComboBoxMedico(object sender, EventArgs e)
        {
            try
            {
                int idEspecialidad = ValidarEspecialidadSeleccionada();

                if (idEspecialidad == 0)
                    return;

                List<Medico> medicos = _medicoBusiness.ObtenerMedicosEspecialidad(idEspecialidad);
                //if (!medicos.Any())
                //    throw new Exception("No se encontraron medicos para la especialidad seleccionada");

                medicoCombobox.DataSource = medicos;
                medicoCombobox.DisplayMember = "Nombre";
                medicoCombobox.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                medicoCombobox.DataSource = null;
                MessageBox.Show(ex.Message);
            }
        }

        private int ValidarEspecialidadSeleccionada() 
        {
            if (EspecialidadCombobox.SelectedItem == null)
            {
                medicoCombobox.DataSource = null;
                return 0;
            }

            int idEspecialidad = 0;
            if (EspecialidadCombobox.SelectedItem is Especialidad especialidadSeleccionada)
            {
                idEspecialidad = especialidadSeleccionada.Id;
            }

            if (idEspecialidad == 0)
                MessageBox.Show("Por favor, seleccione una especialidad");

            return idEspecialidad;
        }

        private void aplicarClinicaEspBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Llenar grid medicos por clinica
                int id = ValidarClinicaSeleccionada();
                ActualizarTurnoGrid(id);
                CargarEspecialidadCombobox();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private int ValidarClinicaSeleccionada()
        {
            if (clinicaComboBox.SelectedItem == null)
                throw new Exception("Ocurrio un error, comuniquese con el administrador");

            int id = ObtenerIdClinica();
            if (id == 0)
                MessageBox.Show("Por favor, seleccione una clinica");

            return id;
        }
        private void CargarMedicosCombobox()
        {
            medicoCombobox.DataSource = null;
            List<Medico> medicos = _medicoBusiness.ObtenerMedicosEspecialidad(Convert.ToInt32(EspecialidadCombobox.SelectedValue));

            if (medicos.Count == 0)
                throw new Exception("No se encontraron Medicos con la especialidad seleccionada");
        
            medicoCombobox.DataSource = medicos;
            medicoCombobox.DisplayMember = "Nombre";
            medicoCombobox.ValueMember = "Id";
        }
        private void CargarEspecialidadCombobox() 
        {
            int id = ObtenerIdClinica();
            EspecialidadCombobox.DataSource = null;

            List<Especialidad> especialidades = _especialidadBusiness.ObtenerEspecialidadesPorClinica(id);

            if (!especialidades.Any())
                throw new Exception("No se encontraron especialidades en la clinica seleccionada");

            EspecialidadCombobox.DataSource = especialidades;
            EspecialidadCombobox.DisplayMember = "Descripcion";
            EspecialidadCombobox.ValueMember = "Id";
            CargarMedicosCombobox();
        }

        private int ObtenerIdClinica() 
        {
            int id = 0;
            if (clinicaComboBox.SelectedItem is Clinica clinicaSeleccionada)
            {
                id = clinicaSeleccionada.Id;
            }
            return id;
        }


        #endregion



    }
}
