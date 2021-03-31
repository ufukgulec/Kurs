namespace Kurs.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ogrenciler")]
    public partial class ogrenciler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ogrenciler()
        {
            dersSecimleri = new HashSet<dersSecimleri>();
            sertifikalar = new HashSet<sertifikalar>();
        }

        [Key]
        public int ogrenciID { get; set; }

        [StringLength(50)]
        public string ogrenciAdi { get; set; }

        [StringLength(50)]
        public string ogrenciSoyadi { get; set; }

        public DateTime? kayitTarihi { get; set; }

        [StringLength(80)]
        public string ogrenciEposta { get; set; }

        [StringLength(11)]
        public string ogrenciTel { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dogumTarihi { get; set; }

        public int? veliID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dersSecimleri> dersSecimleri { get; set; }

        public virtual veliler veliler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sertifikalar> sertifikalar { get; set; }
    }
}
