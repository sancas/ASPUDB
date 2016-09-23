namespace MVC_CRUD_TIENDA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LINEAPEDIDOS")]
    public partial class LINEAPEDIDO
    {
        [Key]
        public int ID_LINEAPEDIDO { get; set; }

        public int UNIDADES { get; set; }

        public int ID_PEDIDO { get; set; }

        public int ID_PRODUCTO { get; set; }

        public virtual PEDIDO PEDIDO { get; set; }

        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
