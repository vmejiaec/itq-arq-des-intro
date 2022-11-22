using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Calificaciones
{
    public enum CalifMetodo { TresNotas, CuatroNotas }

    public class CalifTipo
    {
        public int CalifTipoId { get; set; }
        public string Descripcion { get; set; }
        public CalifMetodo Metodo { get; set; }

        // Relaciones
        // - TipoCalifDet
        public List<CalifTipoDet> CalifTipoDets { get; set; }
    }
}
