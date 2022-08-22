using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Exercise10API.Models
{
    public partial class WatchCatalogContext : DbContext
    {
        public WatchCatalogContext()
        {
        }

        public WatchCatalogContext(DbContextOptions<WatchCatalogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<WatchCatalogTable> WatchCatalogTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:timeless-exercise10-dbserver.database.windows.net,1433;Initial Catalog=Exercise10-Timeless-Db;Persist Security Info=False;User ID=Exercise10Timeless;Password=@ccenture1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WatchCatalogTable>(entity =>
            {
                entity.HasKey(e => e.WatchId);

                entity.ToTable("WatchCatalog_Table");

                entity.Property(e => e.WatchId).HasColumnName("WatchID");

                entity.Property(e => e.Caliber).HasMaxLength(100);

                entity.Property(e => e.CaseMaterial).HasMaxLength(100);

                entity.Property(e => e.Chronograph).HasMaxLength(100);

                entity.Property(e => e.FullDesc).HasMaxLength(1000);

                entity.Property(e => e.Jewel).HasMaxLength(100);

                entity.Property(e => e.Movement).HasMaxLength(100);

                entity.Property(e => e.Price).HasMaxLength(50);

                entity.Property(e => e.ProductNumber).HasMaxLength(100);

                entity.Property(e => e.ShortDesc).HasMaxLength(1000);

                entity.Property(e => e.StrapMaterial).HasMaxLength(100);

                entity.Property(e => e.WatchDiameter).HasMaxLength(50);

                entity.Property(e => e.WatchHeight).HasMaxLength(50);

                entity.Property(e => e.WatchName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WatchThickness).HasMaxLength(50);

                entity.Property(e => e.WatchWeight).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
