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
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public int HoraDesde { get; set; }
        public int HoraHasta { get; set; }
        public int IdEspecialidad { get; set; }
        public Especialidad Especialidad { get; set; }
        public List<Turno> TurnoList { get; set; }

        public Medico(int id, string nombre, int dni, int nroMatricula, string mail, string telefono, int horaDesde, int horaHasta, int idEspecialidad)
        {
            Id = id;
            Nombre = nombre;
            Dni = dni;
            NroMatricula = nroMatricula;
            Mail = mail;
            Telefono = telefono;
            HoraDesde = horaDesde;
            HoraHasta = horaHasta;
            IdEspecialidad = idEspecialidad;
        }
    }
}
