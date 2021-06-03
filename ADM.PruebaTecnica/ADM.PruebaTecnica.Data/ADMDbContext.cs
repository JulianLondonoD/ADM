using ADM.PruebaTecnica.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ADM.PruebaTecnica.Data
{
    public class ADMDbContext : DbContext
    {
        public ADMDbContext(DbContextOptions<ADMDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaEntity>()
                       .ToTable("Categorias")
                       .HasKey(c => c.IdCategoria);
            
        }

        public DbSet<CategoriaEntity> Categorias { get; set; }
    }
}
