using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PacienteDao
    {
        private TurnoDao turnoDao = new TurnoDao();

        public Paciente GetByDni(int dni) 
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    sqlConnection.Open();
                    string query = "SELECT * FROM PACIENTE WHERE DNI = @dni";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@dni", dni);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return PacienteMapper.Map(reader);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void CargarPaciente(Paciente pac)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    conexion.Open();

                    string query = "INSERT INTO PACIENTE(Nombre, DNI, Telefono, Direccion, Mail) VALUES(@nom,@dni,@tel,@dir,@mail)";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@nom", pac.Nombre);
                        command.Parameters.AddWithValue("@dni", pac.DNI);
                        command.Parameters.AddWithValue("@tel", pac.Telefono);
                        command.Parameters.AddWithValue("@dir", pac.Direccion);
                        command.Parameters.AddWithValue("@mail", pac.Mail);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<Paciente> GetAll()
        {
            try
            {
                List<Paciente> pacientes = new List<Paciente>();

                using (SqlConnection conexion = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    conexion.Open();
                    string query = "SELECT ID_Paciente, Nombre, Telefono, Direccion, Mail FROM PACIENTE";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idPaciente = Convert.ToInt32(reader["ID_Paciente"].ToString());
                                List<Turno> turnos = turnoDao.GetTurnosByPacienteId(idPaciente);
                                Paciente pac = PacienteMapper.Map(reader, turnos);

                                pacientes.Add(pac);
                            }
                        }
                    }
                }
                return pacientes;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Paciente GetById(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    conexion.Open();
                    string query = "SELECT ID_Paciente, Nombre, Telefono, Direccion, Mail PACIENTE WHERE ID_Paciente = @ID";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                List<Turno> turnos = turnoDao.GetTurnosByPacienteId(id);
                                Paciente paciente = PacienteMapper.Map(reader, turnos);

                                return paciente;
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

        public void Update(Paciente paciente)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    conexion.Open();

                    string query = "UPDATE PACIENTE SET Nombre = @nombre, Telefono = @tel, Direccion = @dir, Mail = @mail WHERE ID_Paciente = @id";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@id", paciente.Id);
                        command.Parameters.AddWithValue("@nombre", paciente.Nombre);
                        command.Parameters.AddWithValue("@tel", paciente.Telefono);
                        command.Parameters.AddWithValue("@dir", paciente.Direccion);
                        command.Parameters.AddWithValue("@mail", paciente.Mail);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteById(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    conexion.Open();

                    string query = "DELETE FROM PACIENTE WHERE ID_Paciente = @id";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
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
