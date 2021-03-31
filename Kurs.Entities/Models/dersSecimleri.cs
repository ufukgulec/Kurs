namespace Kurs.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dersSecimleri")]
    public partial class dersSecimleri
    {
        [Key]
        public int secimID { get; set; }

        public int? ogrenciID { get; set; }

        public int? dersID { get; set; }

        public virtual dersler dersler { get; set; }

        public virtual ogrenciler ogrenciler { get; set; }
    }
}
