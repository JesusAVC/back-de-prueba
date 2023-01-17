using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class _dbContext: DbContext
    {
        #region configuration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationBuilder configurationBuild = new ConfigurationBuilder();
            //    configurationBuild = configurationBuild.SetBasePath(Directory.GetCurrentDirectory());
            configurationBuild = configurationBuild.AddJsonFile("appsettings.json");
            IConfiguration configurationFile = configurationBuild.Build();

            // Leemos el archivo de configuración.
            optionsBuilder.EnableSensitiveDataLogging();
            string conneccion = configurationFile.GetConnectionString("DbGasper");
            optionsBuilder.UseSqlServer(conneccion);
        }
        #endregion

        #region Tablas

        public DbSet<ProveedorModel> proveedor { get; set; }
        public DbSet<CategoriaModel> categoria { get; set; }
        public DbSet<MarcaModel> marca { get; set; }
        public DbSet<DetalleIngresoModel> detalleingreso { get; set; }
        public DbSet<ProductoModel> producto { get; set; }
        public DbSet<ClienteModel> cliente { get; set; }
        public DbSet<IngresoModel> ingreso { get; set; }
        public DbSet<RolModel> rol { get; set; }
        public DbSet<UsuarioModel> usuario { get; set; }
        public DbSet<VentaModel> venta { get; set; }
        public DbSet<DetalleVentaModel> detalleventa { get; set; }

        #endregion
    }
}
