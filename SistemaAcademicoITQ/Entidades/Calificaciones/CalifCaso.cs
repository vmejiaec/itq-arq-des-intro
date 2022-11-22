
namespace Entidades.Calificaciones
{
    public class CalifCaso
    {
        public int CalifCasoId { get; set; }
        
        // Relaciones
        // - TipoCalif
        public CalifTipo CalifTipo { get; set; }
        public int CalifTipoId { get; set; }
        // - CasoNota
        public List<CasoNota> CasoNotas { get; set; }
    }
}
