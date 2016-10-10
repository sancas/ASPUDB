namespace SA120974.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Asturias : DbContext
    {
        public Asturias()
            : base("name=Asturias")
        {
        }

        public virtual DbSet<Auto> autos { get; set; }
        public virtual DbSet<Autosincidente> autosincidentes { get; set; }
        public virtual DbSet<Incidente> incidentes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>()
                .Property(e => e.placa)
                .IsUnicode(false);

            modelBuilder.Entity<Auto>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Auto>()
                .Property(e => e.color)
                .IsUnicode(false);

            modelBuilder.Entity<Auto>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Auto>()
                .HasMany(e => e.autosincidentes)
                .WithOptional(e => e.auto)
                .HasForeignKey(e => e.idauto);

            modelBuilder.Entity<Incidente>()
                .Property(e => e.lugar)
                .IsUnicode(false);

            modelBuilder.Entity<Incidente>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Incidente>()
                .HasMany(e => e.autosincidentes)
                .WithOptional(e => e.incidente)
                .HasForeignKey(e => e.idincidente);
        }
    }
}
