namespace TrabajoPractico_Lug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarComponentes();
        }

        private void crearTurnoBtn_Click(object sender, EventArgs e)
        {

        }

        private void CargarComponentes() 
        {
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            diaCombobox.Items.AddRange(dias);
        }
    }
}
