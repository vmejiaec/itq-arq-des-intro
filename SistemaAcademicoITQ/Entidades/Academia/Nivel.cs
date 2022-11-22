namespace Entidades.Academia
{
    public class Nivel
    {
        public Malla Malla { get; set; }
        public int MallaId { get; set; }
        public Materia Materia { get; set; }
        public int MateriaId { get; set; }
        public string Nombre { get; set; }
        public int Orden { get; set; }
    }
}
