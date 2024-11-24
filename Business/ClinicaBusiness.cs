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
        public List<Clinica> ObtenerClinicas()
        {
            //TODO sacar esto y retornar informacion de ClinicaDao, lista en memoria
            List<Clinica> clinicasMock = new List<Clinica>();
            clinicasMock.Add(new Clinica(1, "Clinica cardiologica", null, 0, null));
            clinicasMock.Add(new Clinica(3, "Centro de gastroenterologia", null, 0, null));

            return clinicasMock;
        }
    }
}
