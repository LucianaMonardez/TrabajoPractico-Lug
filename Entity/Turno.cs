using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Turno
    {
        public int Id { get; set; }
        public DateTime FechaTurno { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public int MyProperty { get; set; }
        public int IdMedico { get; set; }
        public int IdAdministrativo { get; set; }
    }
}
