using Entity;
using Mapper.dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class TurnoDtoMapper
    {
        public static TurnoDto Map(SqlDataReader reader) 
        {
            return new TurnoDto(reader.GetInt32(0),
               MapperFechaTurno(reader.GetDateTime(1)),
               MapperHoraTurno(reader.GetDateTime(1)),
               reader.GetString(2),
               reader.GetInt32(3),
               reader.GetString(4),
               reader.GetString(5),
               reader.GetString(6));
        }

        private static String MapperHoraTurno(DateTime dateTime)
        {
            return $"{dateTime:HH:mm}";
        }
        private static string MapperFechaTurno(DateTime dateTime)
        {
            return $"{dateTime:dd/MM/yyyy}";
        }
    }
}
