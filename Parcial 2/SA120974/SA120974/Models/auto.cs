namespace SA120974.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("autos")]
    public partial class Auto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Auto()
        {
            autosincidentes = new HashSet<Autosincidente>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string placa { get; set; }

        [Required]
        [StringLength(45)]
        public string modelo { get; set; }

        [Required]
        [StringLength(40)]
        public string color { get; set; }

        [Required]
        [StringLength(45)]
        public string marca { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autosincidente> autosincidentes { get; set; }
    }
}
