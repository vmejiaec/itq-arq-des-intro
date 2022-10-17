using Dominio.Entidades;

namespace Logica.Repositorio
{
    public interface IEstudianteRepository: IRepository<Estudiante>
    {
        IEnumerable<Estudiante> GetFirtsEstudiantes(int amountOfEstudiantes);
    }
}
