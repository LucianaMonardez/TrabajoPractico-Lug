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
    public class EspecialidadDao
    {
        public List<Especialidad> Especialidades = new List<Especialidad>();
        private ClinicaDao clinicaDao = new ClinicaDao();
        public EspecialidadDao() 
        {
            Especialidades = GetAllEsp();
        }

        private List<Especialidad> GetAllEsp()
        {
            try
            {
                List<Especialidad> especialidades = new List<Especialidad>();

                using (SqlConnection conexion = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    conexion.Open();
                    string query = "SELECT ID_Especialidad, Descripcion, ID_Clinica FROM ESPECIALIDAD";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idCli = Convert.ToInt32(reader["ID_Clinica"].ToString());
                                Clinica cli = clinicaDao.GetById(idCli);
                                Especialidad esp = EspecialidadMapper.Map(reader, cli);

                                especialidades.Add(esp);
                            }
                        }
                    }
                }
                return especialidades;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
