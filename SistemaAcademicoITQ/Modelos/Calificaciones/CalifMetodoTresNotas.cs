namespace Modelos.Calificaciones
{
    public class CalifMetodoTresNotas : ICalifMetodo
    {
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }
        public decimal Nota1Peso { get; set; }
        public decimal Nota2Peso { get; set; }
        public decimal Nota3Peso { get; set; }
        public decimal Promedio { get; set; }
        public string PromedioDesc { get; set; }
        public decimal Recuperacion { get; set; }
        public decimal NotaFinal { get; set; }
        public string NotaFinalDesc { get; set; }


    }
}
