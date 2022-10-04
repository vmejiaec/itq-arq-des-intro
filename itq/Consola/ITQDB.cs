using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Consola
{
    public static class ITQDB
    {
        // Métodos
        public static DbContextOptions<ITQContext> getItqDb()
        {
            string? dbTipo = ConfigurationManager.AppSettings[AppConfig.ParametroTipo.DBTipo.ToString()];
            string sqlConn = ConfigurationManager.ConnectionStrings[dbTipo].ConnectionString;

            // Construye la conección acorde con el tipo
            DbContextOptions<ITQContext> contextOptions;
            switch (dbTipo)
            {
                case nameof(ITQContext.DBTipo.dbItqSqlServer):
                    contextOptions = new DbContextOptionsBuilder<ITQContext>()
                        .UseSqlServer(sqlConn)
                        .Options;
                    break;
                case nameof(ITQContext.DBTipo.dbItqPostgres):
                    contextOptions = new DbContextOptionsBuilder<ITQContext>()
                        .UseNpgsql(sqlConn)
                        .Options;
                    break;
                case nameof(ITQContext.DBTipo.dbItqMySql):
                    contextOptions = new DbContextOptionsBuilder<ITQContext>()
                        .UseMySQL(sqlConn)
                        .Options;
                    break;
                default: // Por defecto usa la memoria como base de datos
                    contextOptions = new DbContextOptionsBuilder<ITQContext>()
                        .UseInMemoryDatabase(sqlConn)
                        .Options;
                    break;
            }
            return contextOptions;
        }
        
    }
}
