
public class Curso
{
    // Propiedades
    public int Id { get; set; }
    public string Nombre { get; set; }
    // Navegación
    public List<Estudiante> ListaEstudiantes { get; set; }
    // Constructor
    public Curso()
    {
        this.ListaEstudiantes = new List<Estudiante>();
    }
    // Métodos
}