using Logica.Repositorio;
using Persistencia;

namespace Logica.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ITQContext _context;
        public IEstudianteRepository Estudiantes { get; }

        public UnitOfWork(ITQContext context)
        {
            _context = context;
            Estudiantes = new EstudianteRepository(_context);
        }
        
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
