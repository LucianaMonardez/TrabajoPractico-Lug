using Entity;
using Mapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TurnoDao
    {
        public void CrearTurno(Turno turno) 
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    sqlConnection.Open();

                    string query = "INSERT INTO TURNO(FECHA_ASIGNACION, FECHA_TURNO, ID_PACIENTE, ID_ADMINISTRATIVO, ID_MEDICO) " +
                        "VALUES(@fecha_asignacion, @fecha_turno, @id_paciente, @id_administrativo, id_medico)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@fecha_turno", turno.FechaTurno);
                        sqlCommand.Parameters.AddWithValue("@fecha_asignacion", turno.FechaAsignacion);
                        sqlCommand.Parameters.AddWithValue("@id_paciente", turno.IdPaciente);
                        sqlCommand.Parameters.AddWithValue("@id_administrativo", turno.IdAdministrativo);
                        sqlCommand.Parameters.AddWithValue("@id_medico", turno.IdMedico);
                        sqlCommand.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<Turno> GetTurnosById(int id)
        {
            try
            {
                List<Turno> turnos = new List<Turno>();
                using (SqlConnection conection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    conection.Open();
                    string query = "Select ID_Turno, Fecha_Asignacion, Fecha_Turno, ID_Paciente, ID_Administrativo, ID_Medico FROM TURNO WHERE ID_Paciente = @ID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, conection))
                    {
                        sqlCommand.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //turnos.Add(TurnoMapper.Map(reader));
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
