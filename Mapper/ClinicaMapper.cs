using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class ClinicaMapper
    {
        public static Clinica Map(SqlDataReader reader)
        {
            Clinica clinica = new Clinica
            {
                Id = Convert.ToInt32(reader["ID_Clinica"].ToString()),
                Nombre = reader["Nombre"].ToString(),
                Direccion = reader["Direccion"].ToString(),
                Telefono = reader["Telefono"].ToString(),
                Mail = reader["Mail"].ToString(),

            };
            return clinica;
        }
    }
}
