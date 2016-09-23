namespace EjemploWebGrid.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class autos : DbContext
    {
        public autos()
            : base("name=autos")
        {
        }

        public virtual DbSet<marca> marca { get; set; }
        public virtual DbSet<modelos> modelos { get; set; }
        public virtual DbSet<repuestos> repuestos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<marca>()
                .Property(e => e.marca1)
                .IsUnicode(false);

            modelBuilder.Entity<marca>()
                .Property(e => e.pais)
                .IsUnicode(false);

            modelBuilder.Entity<modelos>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<modelos>()
                .Property(e => e.combustible)
                .IsUnicode(false);

            modelBuilder.Entity<modelos>()
                .Property(e => e.precio)
                .HasPrecision(10, 4);

            modelBuilder.Entity<modelos>()
                .Property(e => e.year_modelo)
                .IsUnicode(false);

            modelBuilder.Entity<repuestos>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<repuestos>()
                .Property(e => e.precio)
                .HasPrecision(10, 4);
        }
    }
}
