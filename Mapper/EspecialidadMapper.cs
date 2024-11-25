using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class EspecialidadMapper
    {
        public static Especialidad Map(SqlDataReader reader, Clinica cli)
        {
            Especialidad especialidad = new Especialidad
            {
                Id = Convert.ToInt32(reader["ID_Especialidad"].ToString()),
                Descripcion = reader["Descripcion"].ToString(),
                IdClinica = Convert.ToInt32(reader["ID_Clinica"].ToString()),
                Clinica = cli
            };
            return especialidad;
        }
    }
}
