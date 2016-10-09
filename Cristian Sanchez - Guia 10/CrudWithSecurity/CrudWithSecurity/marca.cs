namespace CrudWithSecurity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("marca")]
    public partial class marca
    {
        public marca()
        {
            modelos = new HashSet<modelo>();
        }

        [Key]
        public int id_marca { get; set; }

        [Column("marca")]
        [StringLength(15)]
        public string marca1 { get; set; }

        [StringLength(15)]
        public string pais { get; set; }

        public virtual ICollection<modelo> modelos { get; set; }
    }
}
