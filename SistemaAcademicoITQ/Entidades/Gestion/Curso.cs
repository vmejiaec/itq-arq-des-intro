﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Gestion
{
    public enum JornadaTipo { Diurno, Nocturno, Ejecutivo}

    public class Curso
    {
        public int CursoId { get; set; }
        public string Nombre { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }

        public JornadaTipo Jornada { get; set; }

        // Relación con la carrera
        public int CarreraId { get; set; }
        public Carrera Carrera { get; set; }
        // Relación con el Período
        public Periodo Periodo { get; set; }
        public int PeriodoId { get; set; }
        // Relación con Materia
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
        // Relación con Matrícula
        public List<Matricula_Det> Matricula_Dets { get; set; }
    }
}
