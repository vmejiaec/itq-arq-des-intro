using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Calificaciones
{
    public class CalifMetodoCuatroNotas : ICalifMetodo
    {
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }
        public decimal Nota1Peso { get; set; }
        public decimal Nota2Peso { get; set; }
        public decimal Nota3Peso { get; set; }
        public decimal PromedioNotas123 { get; set; }
        public string PromedioNotas123Desc { get; set; }
        public decimal Proyecto { get; set; }
        public decimal ProyectoPeso { get; set; }
        public string ProyectoDesc { get; set; }
        public decimal Recuperacion { get; set; }
        public string RecuperacionDesc { get; set; }
        public decimal NotaFinal { get; set; }
        public string NotaFinalDesc { get; set; }
    }
}
