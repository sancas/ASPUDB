namespace SA120974.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("incidente")]
    public partial class Incidente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Incidente()
        {
            autosincidentes = new HashSet<Autosincidente>();
        }

        public int id { get; set; }

        [Column(TypeName = "image")]
        public byte[] imagen { get; set; }

        [StringLength(50)]
        [Required]
        public string lugar { get; set; }

        [Required]
        public string descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autosincidente> autosincidentes { get; set; }
    }
}
