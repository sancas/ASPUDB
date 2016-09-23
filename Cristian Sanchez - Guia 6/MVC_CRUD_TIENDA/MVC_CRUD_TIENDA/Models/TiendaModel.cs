namespace MVC_CRUD_TIENDA.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TiendaModel : DbContext
    {
        public TiendaModel()
            : base("name=tiendasModel")
        {
        }

        public virtual DbSet<CLIENTE> CLIENTES { get; set; }
        public virtual DbSet<LINEAPEDIDO> LINEAPEDIDOS { get; set; }
        public virtual DbSet<PEDIDO> PEDIDOS { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTOS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.APELLIDO)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.PEDIDOS)
                .WithRequired(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PEDIDO>()
                .HasMany(e => e.LINEAPEDIDOS)
                .WithRequired(e => e.PEDIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTO>()
                .HasMany(e => e.LINEAPEDIDOS)
                .WithRequired(e => e.PRODUCTO)
                .WillCascadeOnDelete(false);
        }
    }
}
