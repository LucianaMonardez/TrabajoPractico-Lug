namespace TrabajoPractico_Lug
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            textBoxTel = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxMail = new TextBox();
            labelNombrePaciente = new Label();
            labelTelefonoP = new Label();
            labelDirecPaciente = new Label();
            labelMailPaciente = new Label();
            buttonCrearPaciente = new Button();
            buttonAgregarListaPaciente = new Button();
            dataGridViewPacientes = new DataGridView();
            ButtonCargarLista = new Button();
            buttonModPaciente = new Button();
            textBoxModPaciente = new TextBox();
            labelModPaciente = new Label();
            buttonEliminarPaciente = new Button();
            textBoxEliminarPaciente = new TextBox();
            labelEliminarPaciente = new Label();
            crearTurnoBtn = new Button();
            agendarTurnosLbl = new Label();
            dniPacienteCreacionLbl = new Label();
            medicoCreacionLbl = new Label();
            diaCreacionLbl = new Label();
            horarioLbl = new Label();
            turnoDniTxt = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            seleccionerEspecialidadLbl = new Label();
            seleccionarClinicaLbl = new Label();
            clinicaComboBox = new ComboBox();
            EspecialidadCombobox = new ComboBox();
            medicoCombobox = new ComboBox();
            horarioMedicoCombobox = new ComboBox();
            dniTxt = new TextBox();
            dniPacienteLbl = new Label();
            dataGridViewTurnos = new DataGridView();
            crearPaciente = new Label();
            pacientesLbl = new Label();
            TurnosLbl = new Label();
            idMedicoEliminacionLbl = new Label();
            textBoxEliminarTurno = new TextBox();
            cancelarTurnoBtn = new Button();
            medicosLbl = new Label();
            medicosDataGrid = new DataGridView();
            dateTimePickerDia = new DateTimePicker();
            aplicarClinicaEspBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPacientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTurnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)medicosDataGrid).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(116, 313);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(171, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxTel
            // 
            textBoxTel.Location = new Point(116, 376);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(171, 23);
            textBoxTel.TabIndex = 1;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(116, 405);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(171, 23);
            textBoxDireccion.TabIndex = 2;
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(116, 434);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(171, 23);
            textBoxMail.TabIndex = 3;
            // 
            // labelNombrePaciente
            // 
            labelNombrePaciente.AutoSize = true;
            labelNombrePaciente.Location = new Point(11, 316);
            labelNombrePaciente.Name = "labelNombrePaciente";
            labelNombrePaciente.Size = new Size(99, 15);
            labelNombrePaciente.TabIndex = 4;
            labelNombrePaciente.Text = "Nombre Paciente";
            // 
            // labelTelefonoP
            // 
            labelTelefonoP.AutoSize = true;
            labelTelefonoP.Location = new Point(38, 379);
            labelTelefonoP.Name = "labelTelefonoP";
            labelTelefonoP.Size = new Size(72, 15);
            labelTelefonoP.TabIndex = 5;
            labelTelefonoP.Text = "Tel. Paciente";
            // 
            // labelDirecPaciente
            // 
            labelDirecPaciente.AutoSize = true;
            labelDirecPaciente.Location = new Point(25, 408);
            labelDirecPaciente.Name = "labelDirecPaciente";
            labelDirecPaciente.Size = new Size(85, 15);
            labelDirecPaciente.TabIndex = 6;
            labelDirecPaciente.Text = "Direc. Paciente";
            // 
            // labelMailPaciente
            // 
            labelMailPaciente.AutoSize = true;
            labelMailPaciente.Location = new Point(32, 437);
            labelMailPaciente.Name = "labelMailPaciente";
            labelMailPaciente.Size = new Size(78, 15);
            labelMailPaciente.TabIndex = 7;
            labelMailPaciente.Text = "Mail Paciente";
            // 
            // buttonCrearPaciente
            // 
            buttonCrearPaciente.Location = new Point(116, 463);
            buttonCrearPaciente.Name = "buttonCrearPaciente";
            buttonCrearPaciente.Size = new Size(171, 34);
            buttonCrearPaciente.TabIndex = 8;
            buttonCrearPaciente.Text = "Crear Único Paciente";
            buttonCrearPaciente.UseVisualStyleBackColor = true;
            buttonCrearPaciente.Click += buttonCrearPaciente_Click;
            // 
            // buttonAgregarListaPaciente
            // 
            buttonAgregarListaPaciente.Location = new Point(116, 503);
            buttonAgregarListaPaciente.Name = "buttonAgregarListaPaciente";
            buttonAgregarListaPaciente.Size = new Size(171, 23);
            buttonAgregarListaPaciente.TabIndex = 9;
            buttonAgregarListaPaciente.Text = "Agregar Lista";
            buttonAgregarListaPaciente.UseVisualStyleBackColor = true;
            buttonAgregarListaPaciente.Click += buttonAgregarListaPaciente_Click;
            // 
            // dataGridViewPacientes
            // 
            dataGridViewPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPacientes.Location = new Point(302, 313);
            dataGridViewPacientes.Name = "dataGridViewPacientes";
            dataGridViewPacientes.Size = new Size(501, 150);
            dataGridViewPacientes.TabIndex = 10;
            // 
            // ButtonCargarLista
            // 
            ButtonCargarLista.Location = new Point(116, 532);
            ButtonCargarLista.Name = "ButtonCargarLista";
            ButtonCargarLista.Size = new Size(171, 23);
            ButtonCargarLista.TabIndex = 11;
            ButtonCargarLista.Text = "Cargar Lista";
            ButtonCargarLista.UseVisualStyleBackColor = true;
            ButtonCargarLista.Click += ButtonCargarLista_Click;
            // 
            // buttonModPaciente
            // 
            buttonModPaciente.Location = new Point(170, 563);
            buttonModPaciente.Name = "buttonModPaciente";
            buttonModPaciente.Size = new Size(117, 24);
            buttonModPaciente.TabIndex = 12;
            buttonModPaciente.Text = "Modificar Paciente";
            buttonModPaciente.UseVisualStyleBackColor = true;
            buttonModPaciente.Click += buttonModPaciente_Click;
            // 
            // textBoxModPaciente
            // 
            textBoxModPaciente.Location = new Point(118, 564);
            textBoxModPaciente.Name = "textBoxModPaciente";
            textBoxModPaciente.Size = new Size(46, 23);
            textBoxModPaciente.TabIndex = 13;
            // 
            // labelModPaciente
            // 
            labelModPaciente.AutoSize = true;
            labelModPaciente.Location = new Point(94, 567);
            labelModPaciente.Name = "labelModPaciente";
            labelModPaciente.Size = new Size(18, 15);
            labelModPaciente.TabIndex = 14;
            labelModPaciente.Text = "ID";
            // 
            // buttonEliminarPaciente
            // 
            buttonEliminarPaciente.Location = new Point(381, 469);
            buttonEliminarPaciente.Name = "buttonEliminarPaciente";
            buttonEliminarPaciente.Size = new Size(133, 23);
            buttonEliminarPaciente.TabIndex = 15;
            buttonEliminarPaciente.Text = "Eliminar Paciente";
            buttonEliminarPaciente.UseVisualStyleBackColor = true;
            buttonEliminarPaciente.Click += buttonEliminarPaciente_Click;
            // 
            // textBoxEliminarPaciente
            // 
            textBoxEliminarPaciente.Location = new Point(329, 469);
            textBoxEliminarPaciente.Name = "textBoxEliminarPaciente";
            textBoxEliminarPaciente.Size = new Size(46, 23);
            textBoxEliminarPaciente.TabIndex = 16;
            // 
            // labelEliminarPaciente
            // 
            labelEliminarPaciente.AutoSize = true;
            labelEliminarPaciente.Location = new Point(305, 473);
            labelEliminarPaciente.Name = "labelEliminarPaciente";
            labelEliminarPaciente.Size = new Size(18, 15);
            labelEliminarPaciente.TabIndex = 17;
            labelEliminarPaciente.Text = "ID";
            // 
            // crearTurnoBtn
            // 
            crearTurnoBtn.Location = new Point(94, 231);
            crearTurnoBtn.Name = "crearTurnoBtn";
            crearTurnoBtn.Size = new Size(75, 23);
            crearTurnoBtn.TabIndex = 0;
            crearTurnoBtn.Text = "Agendar turno";
            crearTurnoBtn.UseVisualStyleBackColor = true;
            crearTurnoBtn.Click += crearTurnoBtn_Click;
            // 
            // agendarTurnosLbl
            // 
            agendarTurnosLbl.AutoSize = true;
            agendarTurnosLbl.Location = new Point(23, 62);
            agendarTurnosLbl.Name = "agendarTurnosLbl";
            agendarTurnosLbl.Size = new Size(87, 15);
            agendarTurnosLbl.TabIndex = 1;
            agendarTurnosLbl.Text = "Agendar turno:";
            // 
            // dniPacienteCreacionLbl
            // 
            dniPacienteCreacionLbl.AutoSize = true;
            dniPacienteCreacionLbl.Location = new Point(23, 100);
            dniPacienteCreacionLbl.Name = "dniPacienteCreacionLbl";
            dniPacienteCreacionLbl.Size = new Size(76, 15);
            dniPacienteCreacionLbl.TabIndex = 2;
            dniPacienteCreacionLbl.Text = "Dni paciente:";
            // 
            // medicoCreacionLbl
            // 
            medicoCreacionLbl.AutoSize = true;
            medicoCreacionLbl.Location = new Point(23, 134);
            medicoCreacionLbl.Name = "medicoCreacionLbl";
            medicoCreacionLbl.Size = new Size(50, 15);
            medicoCreacionLbl.TabIndex = 3;
            medicoCreacionLbl.Text = "Medico:";
            // 
            // diaCreacionLbl
            // 
            diaCreacionLbl.AutoSize = true;
            diaCreacionLbl.Location = new Point(23, 163);
            diaCreacionLbl.Name = "diaCreacionLbl";
            diaCreacionLbl.Size = new Size(27, 15);
            diaCreacionLbl.TabIndex = 4;
            diaCreacionLbl.Text = "Dia:";
            // 
            // horarioLbl
            // 
            horarioLbl.AutoSize = true;
            horarioLbl.Location = new Point(23, 191);
            horarioLbl.Name = "horarioLbl";
            horarioLbl.Size = new Size(50, 15);
            horarioLbl.TabIndex = 5;
            horarioLbl.Text = "Horario:";
            // 
            // turnoDniTxt
            // 
            turnoDniTxt.Location = new Point(128, 92);
            turnoDniTxt.Name = "turnoDniTxt";
            turnoDniTxt.Size = new Size(121, 23);
            turnoDniTxt.TabIndex = 6;
            // 
            // seleccionerEspecialidadLbl
            // 
            seleccionerEspecialidadLbl.AutoSize = true;
            seleccionerEspecialidadLbl.Location = new Point(316, 18);
            seleccionerEspecialidadLbl.Name = "seleccionerEspecialidadLbl";
            seleccionerEspecialidadLbl.Size = new Size(138, 15);
            seleccionerEspecialidadLbl.TabIndex = 7;
            seleccionerEspecialidadLbl.Text = "Seleccionar especialidad:";
            // 
            // seleccionarClinicaLbl
            // 
            seleccionarClinicaLbl.AutoSize = true;
            seleccionarClinicaLbl.Location = new Point(23, 18);
            seleccionarClinicaLbl.Name = "seleccionarClinicaLbl";
            seleccionarClinicaLbl.Size = new Size(107, 15);
            seleccionarClinicaLbl.TabIndex = 8;
            seleccionarClinicaLbl.Text = "Seleccionar clinica:";
            // 
            // clinicaComboBox
            // 
            clinicaComboBox.FormattingEnabled = true;
            clinicaComboBox.Location = new Point(150, 10);
            clinicaComboBox.Name = "clinicaComboBox";
            clinicaComboBox.Size = new Size(121, 23);
            clinicaComboBox.TabIndex = 9;
            // 
            // EspecialidadCombobox
            // 
            EspecialidadCombobox.FormattingEnabled = true;
            EspecialidadCombobox.Location = new Point(470, 10);
            EspecialidadCombobox.Name = "EspecialidadCombobox";
            EspecialidadCombobox.Size = new Size(121, 23);
            EspecialidadCombobox.TabIndex = 10;
            // 
            // medicoCombobox
            // 
            medicoCombobox.FormattingEnabled = true;
            medicoCombobox.Location = new Point(128, 126);
            medicoCombobox.Name = "medicoCombobox";
            medicoCombobox.Size = new Size(121, 23);
            medicoCombobox.TabIndex = 11;
            medicoCombobox.SelectedIndexChanged += ActualizarDropDownHoraMedico;
            // 
            // horarioMedicoCombobox
            // 
            horarioMedicoCombobox.FormattingEnabled = true;
            horarioMedicoCombobox.Location = new Point(128, 188);
            horarioMedicoCombobox.Name = "horarioMedicoCombobox";
            horarioMedicoCombobox.Size = new Size(121, 23);
            horarioMedicoCombobox.TabIndex = 13;
            // 
            // dniTxt
            // 
            dniTxt.Location = new Point(116, 342);
            dniTxt.Name = "dniTxt";
            dniTxt.Size = new Size(171, 23);
            dniTxt.TabIndex = 18;
            // 
            // dniPacienteLbl
            // 
            dniPacienteLbl.AutoSize = true;
            dniPacienteLbl.Location = new Point(32, 345);
            dniPacienteLbl.Name = "dniPacienteLbl";
            dniPacienteLbl.Size = new Size(76, 15);
            dniPacienteLbl.TabIndex = 19;
            dniPacienteLbl.Text = "Dni paciente:";
            // 
            // dataGridViewTurnos
            // 
            dataGridViewTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTurnos.Location = new Point(302, 80);
            dataGridViewTurnos.Name = "dataGridViewTurnos";
            dataGridViewTurnos.Size = new Size(491, 163);
            dataGridViewTurnos.TabIndex = 20;
            // 
            // crearPaciente
            // 
            crearPaciente.AutoSize = true;
            crearPaciente.Location = new Point(13, 290);
            crearPaciente.Name = "crearPaciente";
            crearPaciente.Size = new Size(86, 15);
            crearPaciente.TabIndex = 21;
            crearPaciente.Text = "Crear paciente:";
            // 
            // pacientesLbl
            // 
            pacientesLbl.AutoSize = true;
            pacientesLbl.Location = new Point(302, 290);
            pacientesLbl.Name = "pacientesLbl";
            pacientesLbl.Size = new Size(60, 15);
            pacientesLbl.TabIndex = 22;
            pacientesLbl.Text = "Pacientes:";
            // 
            // TurnosLbl
            // 
            TurnosLbl.AutoSize = true;
            TurnosLbl.Location = new Point(302, 62);
            TurnosLbl.Name = "TurnosLbl";
            TurnosLbl.Size = new Size(46, 15);
            TurnosLbl.TabIndex = 23;
            TurnosLbl.Text = "Turnos:";
            // 
            // idMedicoEliminacionLbl
            // 
            idMedicoEliminacionLbl.AutoSize = true;
            idMedicoEliminacionLbl.Location = new Point(302, 256);
            idMedicoEliminacionLbl.Name = "idMedicoEliminacionLbl";
            idMedicoEliminacionLbl.Size = new Size(18, 15);
            idMedicoEliminacionLbl.TabIndex = 25;
            idMedicoEliminacionLbl.Text = "ID";
            // 
            // textBoxEliminarTurno
            // 
            textBoxEliminarTurno.Location = new Point(329, 249);
            textBoxEliminarTurno.Name = "textBoxEliminarTurno";
            textBoxEliminarTurno.Size = new Size(46, 23);
            textBoxEliminarTurno.TabIndex = 26;
            // 
            // cancelarTurnoBtn
            // 
            cancelarTurnoBtn.Location = new Point(395, 249);
            cancelarTurnoBtn.Name = "cancelarTurnoBtn";
            cancelarTurnoBtn.Size = new Size(133, 23);
            cancelarTurnoBtn.TabIndex = 27;
            cancelarTurnoBtn.Text = "Cancelar turno";
            cancelarTurnoBtn.UseVisualStyleBackColor = true;
            cancelarTurnoBtn.Click += cancelarTurnoBtn_Click;
            // 
            // medicosLbl
            // 
            medicosLbl.AutoSize = true;
            medicosLbl.Location = new Point(823, 62);
            medicosLbl.Name = "medicosLbl";
            medicosLbl.Size = new Size(55, 15);
            medicosLbl.TabIndex = 28;
            medicosLbl.Text = "Medicos:";
            // 
            // medicosDataGrid
            // 
            medicosDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            medicosDataGrid.Location = new Point(823, 80);
            medicosDataGrid.Name = "medicosDataGrid";
            medicosDataGrid.Size = new Size(375, 383);
            medicosDataGrid.TabIndex = 29;
            // 
            // dateTimePickerDia
            // 
            dateTimePickerDia.Location = new Point(128, 159);
            dateTimePickerDia.Name = "dateTimePickerDia";
            dateTimePickerDia.Size = new Size(121, 23);
            dateTimePickerDia.TabIndex = 30;
            // 
            // aplicarClinicaEspBtn
            // 
            aplicarClinicaEspBtn.Location = new Point(611, 10);
            aplicarClinicaEspBtn.Name = "aplicarClinicaEspBtn";
            aplicarClinicaEspBtn.Size = new Size(75, 23);
            aplicarClinicaEspBtn.TabIndex = 31;
            aplicarClinicaEspBtn.Text = "Aplicar";
            aplicarClinicaEspBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 599);
            Controls.Add(aplicarClinicaEspBtn);
            Controls.Add(dateTimePickerDia);
            Controls.Add(medicosDataGrid);
            Controls.Add(medicosLbl);
            Controls.Add(cancelarTurnoBtn);
            Controls.Add(textBoxEliminarTurno);
            Controls.Add(idMedicoEliminacionLbl);
            Controls.Add(TurnosLbl);
            Controls.Add(pacientesLbl);
            Controls.Add(crearPaciente);
            Controls.Add(dataGridViewTurnos);
            Controls.Add(dniPacienteLbl);
            Controls.Add(dniTxt);
            Controls.Add(labelEliminarPaciente);
            Controls.Add(textBoxEliminarPaciente);
            Controls.Add(buttonEliminarPaciente);
            Controls.Add(labelModPaciente);
            Controls.Add(textBoxModPaciente);
            Controls.Add(buttonModPaciente);
            Controls.Add(ButtonCargarLista);
            Controls.Add(dataGridViewPacientes);
            Controls.Add(buttonAgregarListaPaciente);
            Controls.Add(buttonCrearPaciente);
            Controls.Add(labelMailPaciente);
            Controls.Add(labelDirecPaciente);
            Controls.Add(labelTelefonoP);
            Controls.Add(labelNombrePaciente);
            Controls.Add(textBoxMail);
            Controls.Add(textBoxDireccion);
            Controls.Add(textBoxTel);
            Controls.Add(textBoxName);
            Controls.Add(horarioMedicoCombobox);
            Controls.Add(medicoCombobox);
            Controls.Add(EspecialidadCombobox);
            Controls.Add(clinicaComboBox);
            Controls.Add(seleccionarClinicaLbl);
            Controls.Add(seleccionerEspecialidadLbl);
            Controls.Add(turnoDniTxt);
            Controls.Add(horarioLbl);
            Controls.Add(diaCreacionLbl);
            Controls.Add(medicoCreacionLbl);
            Controls.Add(dniPacienteCreacionLbl);
            Controls.Add(agendarTurnosLbl);
            Controls.Add(crearTurnoBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPacientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTurnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)medicosDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxTel;
        private TextBox textBoxDireccion;
        private TextBox textBoxMail;
        private Label labelNombrePaciente;
        private Label labelTelefonoP;
        private Label labelDirecPaciente;
        private Label labelMailPaciente;
        private Button buttonCrearPaciente;
        private Button buttonAgregarListaPaciente;
        private DataGridView dataGridViewPacientes;
        private Button ButtonCargarLista;
        private Button buttonModPaciente;
        private TextBox textBoxModPaciente;
        private Label labelModPaciente;
        private Button buttonEliminarPaciente;
        private TextBox textBoxEliminarPaciente;
        private Label labelEliminarPaciente;

        private Button crearTurnoBtn;
        private Label agendarTurnosLbl;
        private Label dniPacienteCreacionLbl;
        private Label medicoCreacionLbl;
        private Label diaCreacionLbl;
        private Label horarioLbl;
        private TextBox turnoDniTxt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label seleccionerEspecialidadLbl;
        private Label seleccionarClinicaLbl;
        private ComboBox clinicaComboBox;
        private ComboBox EspecialidadCombobox;
        private ComboBox medicoCombobox;
        private ComboBox horarioMedicoCombobox;
        private TextBox dniTxt;
        private Label dniPacienteLbl;
        private DataGridView dataGridViewTurnos;
        private Label crearPaciente;
        private Label pacientesLbl;
        private Label TurnosLbl;
        private Label idMedicoEliminacionLbl;
        private TextBox textBoxEliminarTurno;
        private Button cancelarTurnoBtn;
        private Label medicosLbl;
        private DataGridView medicosDataGrid;
        private DateTimePicker dateTimePickerDia;
        private Button aplicarClinicaEspBtn;
    }
}
