using DAL;
using Entity;
using Mapper.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TurnoBusiness
    {
        public TurnoDao _turnoDao = new TurnoDao();
        public PacienteDao _pacienteDao = new PacienteDao();

        public List<Turno> ObtenerTurnos() 
        {
            try
            {
                return _turnoDao.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TurnoDto> ObtenerTurnosDto() 
        {
            try
            {
                return _turnoDao.GetAllTurnosDto();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void CrearTurno(Turno turno, string dniPaciente)
        {
            try
            {
                if (!int.TryParse(dniPaciente, out int idNumerico))
                    throw new Exception("El campo dni debe ser numérico.");

                if (dniPaciente.Length >= 7 && dniPaciente.Length <= 8)
                    throw new Exception("La longitud del campo dni debe ser mayor de 6 y menor de 9");

                if (turno.FechaTurno < DateTime.Now.AddDays(2))
                    throw new Exception("Los turnos solo se pueden asignar con al menos 48 horas de anticipacion. Por favor, seleccione otra fecha.");

                Paciente paciente = _pacienteDao.GetByDni(Convert.ToInt32(dniPaciente)) ??
                    throw new Exception($"No existe paciente con el dni {dniPaciente} en el sistema");

                turno.IdPaciente = paciente.Id;

                //TODO Ver el set administrativo
                turno.IdAdministrativo = 1;

                _turnoDao.CreateTurno(turno);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void EliminarTurno(string id) 
        {
            try
            {
                if (String.IsNullOrEmpty(id))
                    throw new Exception("Debe insertar un valor en el campo id a eliminar.");

                if (!int.TryParse(id, out int idNumerico))
                    throw new Exception("El campo id debe ser numérico.");

                Turno turno = _turnoDao.GetById(Convert.ToInt32(id)) ??
                    throw new Exception($"No existe el turno con el id {id} en el sistema");

                _turnoDao.DeleteTurno(Convert.ToInt32(id));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
