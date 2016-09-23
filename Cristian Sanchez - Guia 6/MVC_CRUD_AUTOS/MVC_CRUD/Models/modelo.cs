namespace MVC_CRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("modelos")]
    public partial class modelo
    {
        public modelo()
        {
            repuestos = new HashSet<repuesto>();
        }

        [Key]
        public int id_modelos { get; set; }

        [Column("modelo")]
        [StringLength(15)]
        public string modelo1 { get; set; }

        public int? asientos { get; set; }

        [StringLength(10)]
        public string combustible { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? precio { get; set; }

        [StringLength(4)]
        public string year_modelo { get; set; }

        public int? id_marca { get; set; }

        public virtual marca marca { get; set; }

        public virtual ICollection<repuesto> repuestos { get; set; }
    }
}
