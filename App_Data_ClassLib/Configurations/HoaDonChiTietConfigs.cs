using App_Data_ClassLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabC4.Configurations
{
    internal class HoaDonChiTietConfigs : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(p => p.IDHDCT);
            builder.HasOne(p => p.SanPhamChiTiets).WithMany(p => p.HoaDonChiTiets).
                HasForeignKey(p => p.IDSPCT).HasConstraintName("FK_SanPhamChiTiet_HDCT");
            builder.Property(p => p.SoLuong).HasColumnName("SoLuong").HasColumnType("int").IsRequired();
            builder.Property(p => p.GiaSP).HasColumnName("GiaSP").HasColumnType("float").IsRequired();
            builder.Property(p=>p.IDHD).HasColumnName("IDHD").HasColumnType("uniqueidentifier").IsRequired();

        }
    }
}
