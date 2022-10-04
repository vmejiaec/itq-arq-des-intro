using Dominio.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    internal class EstudianteRepository : IEstudianteRepository
    {
        public Task<IReadOnlyList<Estudiante>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Estudiante> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
