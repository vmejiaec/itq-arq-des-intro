﻿using Entidades.Gestion;

namespace Entidades
{
    public class Configuracion
    {
        public int CreditoMaximo { get; set; }
        public string EscuelaNombre { get; set; }
        public float NotaMinima { get; set; }
        public float PesoNota1 { get; set; }
        public float PesoNota2 { get; set; }
        public float PesoNota3 { get; set; }

        // Relación con Períodos
        public Periodo PeriodoVigente { get; set; }
        public int PeriodoVigenteId { get; set; }
    }
}
