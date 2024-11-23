using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TurnoDao
    {
        public List<Turno> GetTurnosById(int id)
        {
            try
            {
                List<Turno> turnos = new List<Turno>();
                using (SqlConnection conection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    conection.Open();
                    string query = "Select ID_Turno, Fecha, Hora, ID_Paciente, ID_Administrativo, ID_Medico, FROM TURNO WHERE ID_Paciente = @ID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, conection))
                    {
                        sqlCommand.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                turnos.Add(TurnoMapper.Map(reader));
                            }
                        }
                    }
                }
                return turnos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
