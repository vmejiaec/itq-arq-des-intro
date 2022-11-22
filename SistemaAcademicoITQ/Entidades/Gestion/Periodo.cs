﻿using System.ComponentModel.DataAnnotations;

namespace Entidades.Gestion
{
    public enum PeriodoEstado { Abierto, Cerrado}

    public class Periodo : IEntidad
    {
        public int PeriodoId { get; set; }
        public string Nombre { get; set; }
        public int Anio { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }
        
        public PeriodoEstado Estado { get; set; } // ABRierto CERrado

        // Relación con los cursos abiertos en un período
        public List<Curso> Cursos { get; set; }
        // Relación con las matrículas realizadas en un período
        public List<Matricula> Matriculas { get; set; }
    }
}
