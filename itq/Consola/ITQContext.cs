using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Consola
{
    public class ITQContext: DbContext
    {
        // Tipos
        public enum DBTipo { dbItqSqlServer, dbItqMySql, dbItqPostgres, dbItqMemoria }
        // Atributos
        private string connDbItq;
        // Propiedades
        public DbSet<Periodo> Periodos { get; set; }
        public DbSet<Curso> Cursos{ get; set; }
        public DbSet<Estudiante> Estudiantes{ get; set; }
        // Constructor
        public ITQContext(DbContextOptions<ITQContext> options):base(options)
        {
            Init();
        }
        public ITQContext(DBTipo dbTipo)
        {
            this.connDbItq = ConfigurationManager.ConnectionStrings[dbTipo.ToString()].ConnectionString;
            Init();
        }
        // Métodos
        // Configuración de la conección
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(connDbItq);
            }
        }
        // Acciones de inicialización
        private void Init()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
