using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class PacienteMapper
    {
        public static Paciente Map(SqlDataReader reader)
        {
            Paciente paciente = new Paciente
            {
                Id = Convert.ToInt32(reader["ID_Paciente"].ToString()),
                DNI = Convert.ToInt32(reader["DNI"].ToString()),
                Nombre = reader["Nombre"].ToString(),
                Telefono = reader["Telefono"].ToString(),
                Direccion = reader["Direccion"].ToString(),
                Mail = reader["Mail"].ToString(),
            };
            return paciente;
        }
        public static Paciente Map(SqlDataReader reader, List<Turno> turnos)
        {
            Paciente paciente = new Paciente
            {
                Id = Convert.ToInt32(reader["ID_Paciente"].ToString()),
                DNI = Convert.ToInt32(reader["DNI"].ToString()),
                Nombre = reader["Nombre"].ToString(),
                Telefono = reader["Telefono"].ToString(),
                Direccion = reader["Direccion"].ToString(),
                Mail = reader["Mail"].ToString(),
            };
            return paciente;
        }
    }
}
