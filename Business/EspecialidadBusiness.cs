using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class EspecialidadBusiness
    {
        private EspecialidadDao especialidadDao = new EspecialidadDao();
        public List<Especialidad> ObtenerEspecialidadesPorClinica(int clincaId) 
        {
            try
            {
                
                List<Especialidad> especialidad = especialidadDao.Especialidades.Where(especialidad => especialidad.IdClinica == clincaId).ToList();
                return especialidad;
            }
            catch (Exception ex) 
            {
                throw;
            }
            /*
            //TODO sacar esto y retornar informacion de EspecialidadDao, lista en memoria y filtrando por clinicaId
            List<Especialidad> especialidadMock = new List<Especialidad>();
            especialidadMock.Add(new Especialidad(1, "Cardiologia", 1, null));
            especialidadMock.Add(new Especialidad(3, "Gastroenterologia", 2, null));

            return especialidadMock.Where(esp => esp.IdClinica == clincaId).ToList();
            */
        }
    }
}
