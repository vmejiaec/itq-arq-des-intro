using Dominio;

namespace Entidades
{
    public class Periodo : IEntidad
    {
        // Propiedades
        public int Id { get; set; }
        public string Descripcion { get; set; }
        // Navegación
        public List<Curso> Cursos { get; set; }
        // Constructor
        public Periodo()
        {
            this.Cursos = new List<Curso>();
        }
    }
}