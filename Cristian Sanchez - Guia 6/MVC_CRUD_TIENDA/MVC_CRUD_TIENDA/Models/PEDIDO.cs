namespace MVC_CRUD_TIENDA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PEDIDOS")]
    public partial class PEDIDO
    {
        public PEDIDO()
        {
            LINEAPEDIDOS = new HashSet<LINEAPEDIDO>();
        }

        [Key]
        public int ID_PEDIDO { get; set; }

        [Column(TypeName = "date")]
        public DateTime FECHACREACION { get; set; }

        public int ID_CLIENTE { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        public virtual ICollection<LINEAPEDIDO> LINEAPEDIDOS { get; set; }
    }
}
