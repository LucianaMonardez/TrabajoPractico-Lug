using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public int NroMatricula { get; set; }
        public string Matricula { get; set; }
        public int Telefono { get; set; }
        public DateTime HoraDesde { get; set; }
        public DateTime HoraHasta { get; set; }
        public int IdEspecialidad { get; set; }
        public Especialidad Especialidad { get; set; }
        public List<Turno> TurnoList { get; set; }
    }
}
