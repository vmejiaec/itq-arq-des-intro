using Logica.Repositorio;

namespace Logica.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public IEstudianteRepository Estudiantes { get; }
        int Complete();
    }
}
