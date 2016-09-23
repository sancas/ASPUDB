namespace MVC_CRUD_TIENDA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLIENTES")]
    public partial class CLIENTE
    {
        public CLIENTE()
        {
            PEDIDOS = new HashSet<PEDIDO>();
        }

        [Key]
        public int ID_CLIENTE { get; set; }

        [Required]
        [StringLength(45)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(45)]
        public string APELLIDO { get; set; }

        public int EDAD { get; set; }

        public virtual ICollection<PEDIDO> PEDIDOS { get; set; }
    }
}
