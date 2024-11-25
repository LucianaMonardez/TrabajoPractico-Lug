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
        public List<Medico> Medicos = new List<Medico>();

        public MedicoDao()
        {
            Medicos = GetAll();
        }

        private List<Medico> GetAll() 
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    sqlConnection.Open();
                    string query = "SELECT ID_MEDICO, NOMBRE, DNI, NRO_MATRICULA, MAIL, TELEFONO, HORADESDE, ID_ESPECIALIDAD, HORAHASTA FROM MEDICO";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Medico medico = MedicoMapper.Map(reader);
                                Medicos.Add(medico);
                            }
                        }
                    }
                }
                return Medicos;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Medico GetById(int id) 
        {
            return Medicos.Where(medico => medico.Id == id).FirstOrDefault();
        }

        public Medico GetAllById(int id)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    sqlConnection.Open();
                    string query = "SELECT Nombre, ID_Especialidad, HoraDesde, HoraHasta FROM Medico WHERE ID_Especialidad = @Id";

                    using(SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        using(SqlDataReader reader = cmd.ExecuteReader())
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
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
