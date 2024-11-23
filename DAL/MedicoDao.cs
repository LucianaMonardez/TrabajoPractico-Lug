using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MedicoDao
    {
        public Medico GetById(int id) 
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    sqlConnection.Open();
                    string query = "SELECT * FROM MEDICO WHERE ID_MEDICO = @id";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return MedicoMapper.Map(reader);
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
    }
}
