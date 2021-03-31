namespace Kurs.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ogretmenler")]
    public partial class ogretmenler
    {
        [Key]
        public int ogretmenID { get; set; }

        [StringLength(50)]
        public string ogretmenAdi { get; set; }

        [StringLength(50)]
        public string ogretmenSoyadi { get; set; }

        public int? alanID { get; set; }

        public DateTime? kayitTarihi { get; set; }

        public int? dersID { get; set; }

        public virtual alanlar alanlar { get; set; }

        public virtual dersler dersler { get; set; }
    }
}
