namespace Kurs.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dersler")]
    public partial class dersler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dersler()
        {
            dersSecimleri = new HashSet<dersSecimleri>();
            ogretmenler = new HashSet<ogretmenler>();
            sertifikalar = new HashSet<sertifikalar>();
        }

        [Key]
        public int dersID { get; set; }

        [StringLength(50)]
        public string dersAdi { get; set; }

        public int? alanID { get; set; }

        [Column(TypeName = "money")]
        public decimal? ücret { get; set; }

        public virtual alanlar alanlar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dersSecimleri> dersSecimleri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ogretmenler> ogretmenler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sertifikalar> sertifikalar { get; set; }
    }
}
