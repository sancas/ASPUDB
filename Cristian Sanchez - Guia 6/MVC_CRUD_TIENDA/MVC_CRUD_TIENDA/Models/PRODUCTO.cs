namespace MVC_CRUD_TIENDA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUCTOS")]
    public partial class PRODUCTO
    {
        public PRODUCTO()
        {
            LINEAPEDIDOS = new HashSet<LINEAPEDIDO>();
        }

        [Key]
        public int ID_PRODUCTO { get; set; }

        [Required]
        [StringLength(120)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(255)]
        public string DESCRIPCION { get; set; }

        public virtual ICollection<LINEAPEDIDO> LINEAPEDIDOS { get; set; }
    }
}
