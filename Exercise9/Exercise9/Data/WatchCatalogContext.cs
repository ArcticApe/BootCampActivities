using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Exercise9.Models
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

        public virtual DbSet<WatchCatalog> WatchCatalog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:fy2203appdevsqlserverjec.database.windows.net,1433;Initial Catalog=MVC_WatchCatalogforExercise9;Persist Security Info=False;User ID=FY2203AppDev;Password=@ccenture1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WatchCatalog>(entity =>
            {
                entity.HasKey(e => e.WatchId)
                    .HasName("PK__WatchCat__3BA3DA83B0D1FA1D");

                entity.Property(e => e.WatchId).HasColumnName("WatchID");

                entity.Property(e => e.Caliber).HasMaxLength(50);

                entity.Property(e => e.CaseMaterial).HasMaxLength(50);

                entity.Property(e => e.Chronograph).HasMaxLength(50);

                entity.Property(e => e.FullDesc).HasMaxLength(150);

                entity.Property(e => e.Jewel).HasMaxLength(50);

                entity.Property(e => e.Movement).HasMaxLength(50);

                entity.Property(e => e.ShortDesc).HasMaxLength(50);

                entity.Property(e => e.StrapMaterial).HasMaxLength(50);

                entity.Property(e => e.WatchName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
