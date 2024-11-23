using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class TurnoMapper
    {
        public static Turno Map(SqlDataReader reader)
        {
            return new Turno(reader.GetInt32(0),
                reader.GetDateTime(2),
                reader.GetDateTime(1),
                reader.GetInt32(3),
                reader.GetInt32(4),
                reader.GetInt32(5));
        }
    }
}
