using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Console_1Excel.Models.DB
{
    public partial class PruebasContext : DbContext
    {
        public PruebasContext()
        {
        }

        public PruebasContext(DbContextOptions<PruebasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cuenta> Cuentas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-S74V9542; Database=Pruebas;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cuenta>(entity =>
            {
                entity.ToTable("CUENTAS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DETALLE");

                entity.Property(e => e.EBanco)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("E_BANCO");

                entity.Property(e => e.EEfectivo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("E_EFECTIVO");

                entity.Property(e => e.GBanco)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("G_BANCO");

                entity.Property(e => e.GEfectivo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("G_EFECTIVO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
