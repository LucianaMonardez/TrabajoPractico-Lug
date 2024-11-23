using Entity;
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
    }
}
