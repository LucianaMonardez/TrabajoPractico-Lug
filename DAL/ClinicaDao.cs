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
    public class ClinicaDao
    {
        public List<Clinica> ObtenerClinicas()
        {
            try
            {
                List<Clinica> clinicas = new List<Clinica>();

                using (SqlConnection conexion = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    conexion.Open();
                    string query = "SELECT ID_Clinica, Nombre, Direccion, Telefono, Mail FROM CLINICA";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Clinica cli = ClinicaMapper.Map(reader);

                                clinicas.Add(cli);
                            }
                        }
                    }
                }
                return clinicas;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Clinica GetById(int id)
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    conection.Open();
                    string query = "Select ID_Clinica, Nombre, Direccion, Telefono, Mail WHERE ID_Clinica = @ID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, conection))
                    {
                        sqlCommand.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return ClinicaMapper.Map(reader);
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
    }
}
