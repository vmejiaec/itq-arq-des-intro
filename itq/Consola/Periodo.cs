public class Periodo
{
    // Propiedades
    public int PeriodoId { get; set; }
    public string Descripcion { get; set; }
    // Navegación
    public List<Curso> ListaCursos { get; set; }
    // Constructor
    public Periodo()
    {
        this.ListaCursos = new List<Curso>();
    }
}