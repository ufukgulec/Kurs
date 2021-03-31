namespace Kurs.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sertifikalar")]
    public partial class sertifikalar
    {
        [Key]
        public int sertifikaID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? tarih { get; set; }

        public int? ogrenciID { get; set; }

        public int? dersID { get; set; }

        public virtual dersler dersler { get; set; }

        public virtual ogrenciler ogrenciler { get; set; }
    }
}
