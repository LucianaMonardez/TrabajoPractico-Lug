﻿using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ClinicaBusiness
    {
        private ClinicaDao clinicaDao = new ClinicaDao();
        public List<Clinica> ObtenerClinicas()
        {
            try
            {
                return clinicaDao.ObtenerClinicas();
            }
            catch (Exception ex) 
            {
                throw;
            }

            /*
            //TODO sacar esto y retornar informacion de ClinicaDao, llenando una lista en memoria
            List<Clinica> clinicasMock = new List<Clinica>();
            clinicasMock.Add(new Clinica(1, "Clinica cardiologica", null, 0, null));
            clinicasMock.Add(new Clinica(2, "Centro de nefrologia", null, 0, null));
            clinicasMock.Add(new Clinica(3, "Centro de gastroenterologia", null, 0, null));

            return clinicasMock;
            */
        }
    }
}
