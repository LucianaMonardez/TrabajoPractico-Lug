using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Especialidad
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int IdClinica { get; set; }
        public Clinica Clinica { get; set; }

        public Especialidad(int id, string descripcion, int idClinica, Clinica clinica)
        {
            Id = id;
            Descripcion = descripcion;
            IdClinica = idClinica;
            Clinica = clinica;
        }
    }
}
