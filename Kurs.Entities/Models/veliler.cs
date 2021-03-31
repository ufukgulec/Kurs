namespace Kurs.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("veliler")]
    public partial class veliler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public veliler()
        {
            odemeler = new HashSet<odemeler>();
            ogrenciler = new HashSet<ogrenciler>();
        }

        [Key]
        public int veliID { get; set; }

        [StringLength(50)]
        public string veliAdi { get; set; }

        [StringLength(50)]
        public string veliSoyadi { get; set; }

        [StringLength(50)]
        public string veliTel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<odemeler> odemeler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ogrenciler> ogrenciler { get; set; }
    }
}
