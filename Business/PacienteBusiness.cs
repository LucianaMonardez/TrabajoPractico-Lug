using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Business
{
    public class PacienteBusiness
    {
        private PacienteDao pacienteDao = new PacienteDao();
        public List<Paciente> GetAll()
        {
            try
            {
                return pacienteDao.GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private void ValidarPaciente(Paciente paciente)
        {
            if (paciente.Nombre.Length < 1)
            {
                throw new Exception("El nombre debe contener almenos 2 caracteres");
            }
            if(paciente.Telefono.Length < 7)
            {
                throw new Exception("El Número del paciente debe contener almenos 7 caracteres");
            }
            if(paciente.Direccion.Length < 1)
            {
                throw new Exception("La dirección debe contener almenos 2 caracteres");
            }
            if (paciente.Mail.Contains("@"))
            {
                throw new Exception("El mail debe contener una @");
            }
        }
        public void CargarPaciente(Paciente pac)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    ValidarPaciente(pac);

                    pacienteDao.CargarPaciente(pac);
                    trx.Complete();
                }
            }
            catch (Exception ex) 
            {
                throw;
            }
        }

        public void CargarPacientesMultiples(List<Paciente> pacientes)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    foreach (var pac in pacientes)
                    {
                        CargarPaciente(pac);
                    }
                    trx.Complete();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Update(int idPac, string nombre, string tel, string direccion, string mail)
        {
            try
            {
                Paciente pac = pacienteDao.GetById(idPac);

                using (TransactionScope trx = new TransactionScope())
                {
                    if (pac == null) throw new Exception("Estudiante inexistente");
                    if(nombre != string.Empty)
                    {
                        pac.Nombre = nombre;
                    }
                    if(tel != string.Empty)
                    {
                        pac.Telefono = tel;
                    }
                    if(direccion != string.Empty)
                    {
                        pac.Direccion = direccion;
                    }
                    if(mail != string.Empty)
                    {
                        pac.Mail = mail;
                    }
                    
                    ValidarPaciente(pac);

                    pacienteDao.Update(pac);
                    trx.Complete();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteById(int idPac)
        {
            try
            {
                Paciente pac = pacienteDao.GetById(idPac);

                using (TransactionScope trx = new TransactionScope())
                {
                    if (pac == null) throw new Exception("Paciente inexistente");
                    pacienteDao.DeleteById(idPac);
                    trx.Complete();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
