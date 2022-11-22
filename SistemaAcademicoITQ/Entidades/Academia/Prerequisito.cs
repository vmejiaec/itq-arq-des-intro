namespace Entidades.Academia
{
    public class Prerequisito
    {
        public int MallaId { get; set; }
        public int MateriaId { get; set; }
        // Relaciones
        public Malla Malla { get; set; }
        public Materia Materia { get; set; }
    }
}
