namespace EjemploWebGrid.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class repuestos
    {
        [Key]
        public int id_rep { get; set; }

        [StringLength(40)]
        public string nombre { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? precio { get; set; }

        public int? descuento { get; set; }

        public int? id_modelos { get; set; }

        public virtual modelos modelos { get; set; }
    }
}
