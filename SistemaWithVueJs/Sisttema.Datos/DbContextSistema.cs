using Microsoft.EntityFrameworkCore;
using Sistema.Entidades.Almacen;
using Sisttema.Datos.Mapping.Almacen;

namespace Sisttema.Datos
{
    public class DbContextSistema : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        public DbContextSistema(DbContextOptions<DbContextSistema> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());
        }
    }
}
