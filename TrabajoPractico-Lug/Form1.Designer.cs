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
            crearTurnoBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            turnoDniTxt = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label6 = new Label();
            label7 = new Label();
            clinicaComboBox = new ComboBox();
            EspecialidadCombobox = new ComboBox();
            medicoCombobox = new ComboBox();
            diaCombobox = new ComboBox();
            horarioMedicoCombobox = new ComboBox();
            SuspendLayout();
            // 
            // crearTurnoBtn
            // 
            crearTurnoBtn.Location = new Point(93, 277);
            crearTurnoBtn.Name = "crearTurnoBtn";
            crearTurnoBtn.Size = new Size(75, 23);
            crearTurnoBtn.TabIndex = 0;
            crearTurnoBtn.Text = "Agendar turno";
            crearTurnoBtn.UseVisualStyleBackColor = true;
            crearTurnoBtn.Click += crearTurnoBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 62);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "Agendar turno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 100);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Dni paciente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 142);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "Medico:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 185);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 4;
            label4.Text = "Dia:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 227);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 5;
            label5.Text = "Horario:";
            // 
            // turnoDniTxt
            // 
            turnoDniTxt.Location = new Point(128, 97);
            turnoDniTxt.Name = "turnoDniTxt";
            turnoDniTxt.Size = new Size(121, 23);
            turnoDniTxt.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(316, 18);
            label6.Name = "label6";
            label6.Size = new Size(138, 15);
            label6.TabIndex = 7;
            label6.Text = "Seleccionar especialidad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 18);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 8;
            label7.Text = "Seleccionar clinica:";
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
            medicoCombobox.Location = new Point(128, 134);
            medicoCombobox.Name = "medicoCombobox";
            medicoCombobox.Size = new Size(121, 23);
            medicoCombobox.TabIndex = 11;
            // 
            // diaCombobox
            // 
            diaCombobox.FormattingEnabled = true;
            diaCombobox.Location = new Point(128, 177);
            diaCombobox.Name = "diaCombobox";
            diaCombobox.Size = new Size(121, 23);
            diaCombobox.TabIndex = 12;
            // 
            // horarioMedicoCombobox
            // 
            horarioMedicoCombobox.FormattingEnabled = true;
            horarioMedicoCombobox.Location = new Point(128, 219);
            horarioMedicoCombobox.Name = "horarioMedicoCombobox";
            horarioMedicoCombobox.Size = new Size(121, 23);
            horarioMedicoCombobox.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(horarioMedicoCombobox);
            Controls.Add(diaCombobox);
            Controls.Add(medicoCombobox);
            Controls.Add(EspecialidadCombobox);
            Controls.Add(clinicaComboBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(turnoDniTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(crearTurnoBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button crearTurnoBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox turnoDniTxt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label6;
        private Label label7;
        private ComboBox clinicaComboBox;
        private ComboBox EspecialidadCombobox;
        private ComboBox medicoCombobox;
        private ComboBox diaCombobox;
        private ComboBox horarioMedicoCombobox;
    }
}
