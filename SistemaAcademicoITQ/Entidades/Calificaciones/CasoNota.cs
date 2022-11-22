namespace Entidades.Calificaciones
{
    public class CasoNota
    {
        public int CasoNotaId { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorPonderado { get; set; }
        public string? Observacion { get; set; }
        // Relaciones
        // - CalifCaso
        public CalifCaso CalifCaso { get; set; }
        public int CalifCasoId { get; set; }
        // - CalifTipoDet
        public CalifTipoDet CalifTipoDet { get; set; }
        public int CalifTipoDetId { get; set; }
    }
}
