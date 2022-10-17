using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Logica.Repositorio
{
    public class EstudianteRepository : Repository<Estudiante>, IEstudianteRepository
    {
        private readonly ITQContext _context;

        public EstudianteRepository(ITQContext context): base(context)
        {
            _context = context;
        }

        /// <summary>
        /// Obtener los n primeros estudiantes ordenados alfabeticamente
        /// </summary>
        /// <param name="amountOfEstudiantes"></param>
        /// <returns>Retorna los n primeros estudiantes en orden alfabético</returns>
        public IEnumerable<Estudiante> GetFirtsEstudiantes(int amountOfEstudiantes)
        {
            if(amountOfEstudiantes > _context.Estudiantes.Count())
            {
                throw new IndexOutOfRangeException();
            }

            return _context.Estudiantes.OrderByDescending(e => e.Nombre).Take(amountOfEstudiantes);
        }

        public IEnumerable<Estudiante> GetAllWithCursos()
        {
            return _context.Estudiantes.Include(x => x.Cursos);
        }
    }
}
