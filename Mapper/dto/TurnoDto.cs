﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper.dto
{
    public class TurnoDto
    {
        public int IdTurno { get; set; }
        public string FechaTurno { get; set; }
        public string HoraTurno { get; set; }
        public string Paciente { get; set; }
        public int Dni { get; set; }
        public string Medico { get; set; }
        public string Especialidad { get; set; }
        public string Clinica { get; set; }

        public TurnoDto(int idTurno, string fechaTurno, string horaTurno, string paciente, int dni, string medico, string especialidad, string clinica)
        {
            IdTurno = idTurno;
            FechaTurno = fechaTurno;
            HoraTurno = horaTurno;
            Paciente = paciente;
            Dni = dni;
            Medico = medico;
            Especialidad = especialidad;
            Clinica = clinica;
        }
    }
}
