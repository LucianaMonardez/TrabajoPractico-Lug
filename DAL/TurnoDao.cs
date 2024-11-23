using Entity;
using Mapper;
using Mapper.dto;
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
        public void CreateTurno(Turno turno) 
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    sqlConnection.Open();

                    string query = "INSERT INTO TURNO(FECHA_ASIGNACION, FECHA_TURNO, ID_PACIENTE, ID_ADMINISTRATIVO, ID_MEDICO) " +
                        "VALUES(@fecha_asignacion, @fecha_turno, @id_paciente, @id_administrativo, @id_medico)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@fecha_turno", turno.FechaTurno);
                        sqlCommand.Parameters.AddWithValue("@fecha_asignacion", DateTime.Now);
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

        public Turno GetById(int id) 
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    sqlConnection.Open();
                    string query = "SELECT * FROM TURNO WHERE ID_TURNO = @id";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return TurnoMapper.Map(reader);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public List<Turno> GetAll() 
        {
            List<Turno> turnos = new List<Turno>();
            using (SqlConnection conection = new SqlConnection(ConnectionUtils.GetConnectionString()))
            {
                conection.Open();
                string query = "Select ID_Turno, Fecha_Asignacion, Fecha_Turno, ID_Paciente, ID_Administrativo, ID_Medico FROM TURNO";
                using (SqlCommand sqlCommand = new SqlCommand(query, conection))
                {
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

        public List<TurnoDto> GetAllTurnosDto() 
        {
            List<TurnoDto> turnos = new List<TurnoDto>();
            using (SqlConnection conection = new SqlConnection(ConnectionUtils.GetConnectionString()))
            {
                conection.Open();
                string query = "SELECT " +
                 "t.ID_TURNO ,t.FECHA_TURNO, p.NOMBRE AS Nombre_Paciente, p.DNI, " +
                 "m.NOMBRE AS Nombre_Medico, esp.Descripcion, c.NOMBRE AS Nombre_Clinica " +
                 "FROM TURNO t " +
                 "INNER JOIN PACIENTE p " +
                 "ON p.ID_PACIENTE = t.ID_PACIENTE " +
                 "INNER JOIN MEDICO m " +
                 "ON m.ID_MEDICO = t.ID_MEDICO " +
                 "INNER JOIN ESPECIALIDAD esp " +
                 "ON esp.ID_ESPECIALIDAD = m.ID_ESPECIALIDAD " +
                 "INNER JOIN CLINICA c " +
                 "ON esp.ID_CLINICA = c.ID_CLINICA " +
                 "ORDER BY t.FECHA_TURNO DESC;";
                using (SqlCommand sqlCommand = new SqlCommand(query, conection))
                {
                    //sqlCommand.Parameters.AddWithValue("@id", clinicaId);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            turnos.Add(TurnoDtoMapper.Map(reader));
                        }
                    }
                }
            }
            return turnos;
        }

        public List<Turno> GetTurnosByPacienteId(int id)
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

        public void DeleteTurno(int id) 
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    sqlConnection.Open();

                    string query = "DELETE FROM TURNO WHERE ID_TURNO = @id";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@id", id);
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
