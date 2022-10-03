using Dominio;

namespace Entidades
{
    public class Estudiante : IEntidad
    {
        // Propiedades
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        // Navegacion
        public List<Curso> Cursos { get; set; }
        // Constructor
        public Estudiante()
        {
            Cursos = new List<Curso>();
        }
    }
}