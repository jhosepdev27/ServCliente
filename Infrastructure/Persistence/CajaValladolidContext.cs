using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrastructure.Persistence
{
    public partial class CajaValladolidContext : DbContext
    {
        public CajaValladolidContext()
        {
        }

        public CajaValladolidContext(DbContextOptions<CajaValladolidContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.CorreoElectronico).HasMaxLength(100);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.Telefono).HasMaxLength(100);
            });

            modelBuilder.Entity<Cliente>().HasQueryFilter(c => c.Estado == true);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
