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
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
        public int IdAdministrativo { get; set; }

        public Turno(int id, DateTime fechaTurno, DateTime fechaAsignacion, int idPaciente, int idMedico, int idAdministrativo)
        {
            Id = id;
            FechaTurno = fechaTurno;
            FechaAsignacion = fechaAsignacion;
            IdPaciente = idPaciente;
            IdMedico = idMedico;
            IdAdministrativo = idAdministrativo;
        }

        public Turno(DateTime fechaTurno, int idMedico)
        {
            FechaTurno = fechaTurno;
            IdMedico = idMedico;
        }
    }
}
