using System.Configuration;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Consola
{
    public class ITQContext : DbContext
    {
        // Tipos
        public enum DBTipo { dbItqSqlServer, dbItqMySql, dbItqPostgres, dbItqMemoria }
        // Atributos
        private string connDbItq;
        // Propiedades
        public DbSet<Periodo> Periodos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        // Constructor
        public ITQContext(DbContextOptions<ITQContext> options) : base(options)
        {
            Init();
        }

        // Métodos
        // Acciones de inicialización
        private void Init()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        // Configurar el modelo de clases
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Estudiante>()
                .HasMany(estudiante => estudiante.Cursos)
                .WithMany(curso => curso.Estudiantes);
        }
    }
}
