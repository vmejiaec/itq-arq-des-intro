
namespace Dominio.Entidades
{
    public class Curso: IEntidad
    {
        // Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        // Navegación
        public List<Estudiante> Estudiantes { get; set; }
        // Constructor
        public Curso()
        {
            this.Estudiantes = new List<Estudiante>();
        }
        // Métodos
    }
}