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
            ((System.ComponentModel.ISupportInitialize)dataGridViewPacientes).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(110, 199);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(171, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxTel
            // 
            textBoxTel.Location = new Point(110, 228);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(171, 23);
            textBoxTel.TabIndex = 1;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(110, 257);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(171, 23);
            textBoxDireccion.TabIndex = 2;
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(110, 286);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(171, 23);
            textBoxMail.TabIndex = 3;
            // 
            // labelNombrePaciente
            // 
            labelNombrePaciente.AutoSize = true;
            labelNombrePaciente.Location = new Point(5, 202);
            labelNombrePaciente.Name = "labelNombrePaciente";
            labelNombrePaciente.Size = new Size(99, 15);
            labelNombrePaciente.TabIndex = 4;
            labelNombrePaciente.Text = "Nombre Paciente";
            // 
            // labelTelefonoP
            // 
            labelTelefonoP.AutoSize = true;
            labelTelefonoP.Location = new Point(32, 231);
            labelTelefonoP.Name = "labelTelefonoP";
            labelTelefonoP.Size = new Size(72, 15);
            labelTelefonoP.TabIndex = 5;
            labelTelefonoP.Text = "Tel. Paciente";
            // 
            // labelDirecPaciente
            // 
            labelDirecPaciente.AutoSize = true;
            labelDirecPaciente.Location = new Point(19, 260);
            labelDirecPaciente.Name = "labelDirecPaciente";
            labelDirecPaciente.Size = new Size(85, 15);
            labelDirecPaciente.TabIndex = 6;
            labelDirecPaciente.Text = "Direc. Paciente";
            // 
            // labelMailPaciente
            // 
            labelMailPaciente.AutoSize = true;
            labelMailPaciente.Location = new Point(26, 289);
            labelMailPaciente.Name = "labelMailPaciente";
            labelMailPaciente.Size = new Size(78, 15);
            labelMailPaciente.TabIndex = 7;
            labelMailPaciente.Text = "Mail Paciente";
            // 
            // buttonCrearPaciente
            // 
            buttonCrearPaciente.Location = new Point(110, 315);
            buttonCrearPaciente.Name = "buttonCrearPaciente";
            buttonCrearPaciente.Size = new Size(171, 34);
            buttonCrearPaciente.TabIndex = 8;
            buttonCrearPaciente.Text = "Crear Único Paciente";
            buttonCrearPaciente.UseVisualStyleBackColor = true;
            buttonCrearPaciente.Click += buttonCrearPaciente_Click;
            // 
            // buttonAgregarListaPaciente
            // 
            buttonAgregarListaPaciente.Location = new Point(110, 355);
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
            dataGridViewPacientes.Location = new Point(287, 199);
            dataGridViewPacientes.Name = "dataGridViewPacientes";
            dataGridViewPacientes.Size = new Size(501, 150);
            dataGridViewPacientes.TabIndex = 10;
            // 
            // ButtonCargarLista
            // 
            ButtonCargarLista.Location = new Point(110, 384);
            ButtonCargarLista.Name = "ButtonCargarLista";
            ButtonCargarLista.Size = new Size(171, 23);
            ButtonCargarLista.TabIndex = 11;
            ButtonCargarLista.Text = "Cargar Lista";
            ButtonCargarLista.UseVisualStyleBackColor = true;
            ButtonCargarLista.Click += ButtonCargarLista_Click;
            // 
            // buttonModPaciente
            // 
            buttonModPaciente.Location = new Point(164, 415);
            buttonModPaciente.Name = "buttonModPaciente";
            buttonModPaciente.Size = new Size(117, 24);
            buttonModPaciente.TabIndex = 12;
            buttonModPaciente.Text = "Modificar Paciente";
            buttonModPaciente.UseVisualStyleBackColor = true;
            buttonModPaciente.Click += buttonModPaciente_Click;
            // 
            // textBoxModPaciente
            // 
            textBoxModPaciente.Location = new Point(112, 416);
            textBoxModPaciente.Name = "textBoxModPaciente";
            textBoxModPaciente.Size = new Size(46, 23);
            textBoxModPaciente.TabIndex = 13;
            // 
            // labelModPaciente
            // 
            labelModPaciente.AutoSize = true;
            labelModPaciente.Location = new Point(88, 419);
            labelModPaciente.Name = "labelModPaciente";
            labelModPaciente.Size = new Size(18, 15);
            labelModPaciente.TabIndex = 14;
            labelModPaciente.Text = "ID";
            // 
            // buttonEliminarPaciente
            // 
            buttonEliminarPaciente.Location = new Point(363, 355);
            buttonEliminarPaciente.Name = "buttonEliminarPaciente";
            buttonEliminarPaciente.Size = new Size(133, 23);
            buttonEliminarPaciente.TabIndex = 15;
            buttonEliminarPaciente.Text = "Eliminar Paciente";
            buttonEliminarPaciente.UseVisualStyleBackColor = true;
            buttonEliminarPaciente.Click += buttonEliminarPaciente_Click;
            // 
            // textBoxEliminarPaciente
            // 
            textBoxEliminarPaciente.Location = new Point(311, 355);
            textBoxEliminarPaciente.Name = "textBoxEliminarPaciente";
            textBoxEliminarPaciente.Size = new Size(46, 23);
            textBoxEliminarPaciente.TabIndex = 16;
            // 
            // labelEliminarPaciente
            // 
            labelEliminarPaciente.AutoSize = true;
            labelEliminarPaciente.Location = new Point(287, 359);
            labelEliminarPaciente.Name = "labelEliminarPaciente";
            labelEliminarPaciente.Size = new Size(18, 15);
            labelEliminarPaciente.TabIndex = 17;
            labelEliminarPaciente.Text = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 481);
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
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPacientes).EndInit();
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
    }
}
