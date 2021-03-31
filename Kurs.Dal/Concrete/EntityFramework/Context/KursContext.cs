using Kurs.Entities.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
namespace Kurs.Dal.Concrete.EntityFramework.Context
{
    public partial class KursContext : DbContext
    {
        public KursContext() : base("name=KursContext")
        {
        }

        public virtual DbSet<alanlar> alanlar { get; set; }
        public virtual DbSet<dersler> dersler { get; set; }
        public virtual DbSet<dersSecimleri> dersSecimleri { get; set; }
        public virtual DbSet<odemeler> odemeler { get; set; }
        public virtual DbSet<ogrenciler> ogrenciler { get; set; }
        public virtual DbSet<ogretmenler> ogretmenler { get; set; }
        public virtual DbSet<ödemeSekli> ödemeSekli { get; set; }
        public virtual DbSet<sertifikalar> sertifikalar { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<veliler> veliler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<alanlar>()
                .Property(e => e.alanAdi)
                .IsUnicode(false);

            modelBuilder.Entity<dersler>()
                .Property(e => e.dersAdi)
                .IsUnicode(false);

            modelBuilder.Entity<dersler>()
                .Property(e => e.ücret)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ogrenciler>()
                .Property(e => e.ogrenciAdi)
                .IsUnicode(false);

            modelBuilder.Entity<ogrenciler>()
                .Property(e => e.ogrenciSoyadi)
                .IsUnicode(false);

            modelBuilder.Entity<ogrenciler>()
                .Property(e => e.ogrenciEposta)
                .IsUnicode(false);

            modelBuilder.Entity<ogrenciler>()
                .Property(e => e.ogrenciTel)
                .IsUnicode(false);

            modelBuilder.Entity<ogretmenler>()
                .Property(e => e.ogretmenAdi)
                .IsUnicode(false);

            modelBuilder.Entity<ogretmenler>()
                .Property(e => e.ogretmenSoyadi)
                .IsUnicode(false);

            modelBuilder.Entity<ödemeSekli>()
                .Property(e => e.tür)
                .IsUnicode(false);

            modelBuilder.Entity<veliler>()
                .Property(e => e.veliAdi)
                .IsUnicode(false);

            modelBuilder.Entity<veliler>()
                .Property(e => e.veliSoyadi)
                .IsUnicode(false);

            modelBuilder.Entity<veliler>()
                .Property(e => e.veliTel)
                .IsUnicode(false);
        }
    }
}
