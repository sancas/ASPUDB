namespace EjemploWebGrid.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class modelos
    {
        public modelos()
        {
            repuestos = new HashSet<repuestos>();
        }

        [Key]
        public int id_modelos { get; set; }

        [StringLength(15)]
        public string modelo { get; set; }

        public int? asientos { get; set; }

        [StringLength(10)]
        public string combustible { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? precio { get; set; }

        [StringLength(4)]
        public string year_modelo { get; set; }

        public int? id_marca { get; set; }

        public virtual marca marca { get; set; }

        public virtual ICollection<repuestos> repuestos { get; set; }
    }
}
