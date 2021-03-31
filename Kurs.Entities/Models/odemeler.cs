namespace Kurs.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("odemeler")]
    public partial class odemeler
    {
        [Key]
        public int odemeID { get; set; }

        public int? veliID { get; set; }

        public int? sekilID { get; set; }

        public virtual ödemeSekli ödemeSekli { get; set; }

        public virtual veliler veliler { get; set; }
    }
}
