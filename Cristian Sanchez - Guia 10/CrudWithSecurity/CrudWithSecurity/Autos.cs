namespace CrudWithSecurity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Autos : DbContext
    {
        public Autos()
            : base("name=Autos")
        {
        }

        public virtual DbSet<marca> marcas { get; set; }
        public virtual DbSet<modelo> modelos { get; set; }
        public virtual DbSet<repuesto> repuestos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<marca>()
                .Property(e => e.marca1)
                .IsUnicode(false);

            modelBuilder.Entity<marca>()
                .Property(e => e.pais)
                .IsUnicode(false);

            modelBuilder.Entity<modelo>()
                .Property(e => e.modelo1)
                .IsUnicode(false);

            modelBuilder.Entity<modelo>()
                .Property(e => e.combustible)
                .IsUnicode(false);

            modelBuilder.Entity<modelo>()
                .Property(e => e.precio)
                .HasPrecision(10, 4);

            modelBuilder.Entity<modelo>()
                .Property(e => e.year_modelo)
                .IsUnicode(false);

            modelBuilder.Entity<repuesto>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<repuesto>()
                .Property(e => e.precio)
                .HasPrecision(10, 4);
        }
    }
}
