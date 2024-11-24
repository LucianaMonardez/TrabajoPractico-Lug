using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class MedicoBusiness
    {
        private MedicoDao _medicoDao = new MedicoDao();

        public List<Medico> ObtenerMedicosEspecialidad(int especialidadId) 
        {
            List<Medico> medicos = _medicoDao.Medicos.Where(medico => medico.IdEspecialidad == especialidadId).ToList();

            if (!medicos.Any())
                throw new Exception("No se encontraron medicos para la especialidad seleccionada");

            return medicos;
        }
        public List<TimeSpan> ObtenerHorarioMedico(int id) 
        {
            Medico medico = _medicoDao.GetById(id) ??
                throw new Exception("El medico no existe en el sistema");

            if (medico.HoraDesde >= medico.HoraHasta)
                throw new Exception("Ocurrio un error: La hora de inicio debe ser menor que la hora de fin");

            TimeSpan duracionTurno = TimeSpan.FromMinutes(30);
            TimeSpan horaDesde = new TimeSpan(medico.HoraDesde, 0, 0);
            TimeSpan turnoFinal = new TimeSpan(medico.HoraHasta, 0, 0);

            List<TimeSpan> turnos = new List<TimeSpan>();

            for (TimeSpan horaActual = horaDesde; horaActual < turnoFinal; horaActual += duracionTurno)
            {
                turnos.Add(horaActual);
            }

            return turnos;

        }
    }
}
