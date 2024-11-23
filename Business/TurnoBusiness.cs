using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TurnoBusiness
    {
        public TurnoDao _turnoDao = new TurnoDao();
        public void CrearTurno(Turno turno)
        {
            try
            {
                //validar que exista paciente
                //validar que el turno del medico realmente este disponible

                _turnoDao.CrearTurno(turno);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
