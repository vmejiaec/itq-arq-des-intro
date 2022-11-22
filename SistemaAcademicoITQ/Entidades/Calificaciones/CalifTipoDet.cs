using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Calificaciones
{
    public class CalifTipoDet
    {
        public int CalifTipoDetId { get; set; }
        public string Nombre { get; set; }
        public decimal Peso { get; set; }
        public int Orden { get; set; }
        public decimal ValorMinimo { get; set; }
        public bool Calculado { get; set; }
        // Relaciones
        public CalifTipo CalifTipo { get; set; }
        public int CalifTipoId { get; set; }
    }
}
