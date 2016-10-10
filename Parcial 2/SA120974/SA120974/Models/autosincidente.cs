namespace SA120974.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("autosincidente")]
    public partial class Autosincidente
    {
        public int id { get; set; }

        public int? idauto { get; set; }

        public int? idincidente { get; set; }

        public virtual Auto auto { get; set; }

        public virtual Incidente incidente { get; set; }
    }
}
