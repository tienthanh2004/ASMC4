using App_Data_ClassLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabC4.Configurations
{
    internal class SanPhamChiTietConfigs : IEntityTypeConfiguration<SanPhamChiTiet>
    {
        public void Configure(EntityTypeBuilder<SanPhamChiTiet> builder)
        {
            builder.ToTable("SanPhamChiTiet");
            builder.HasKey(p => p.IDSPCT);
            builder.Property(p => p.TenSPCT).HasColumnName("TenSPCT").HasColumnType("Nvarchar(max)").IsRequired();
            builder.Property(p => p.LoaiSP).HasColumnName("LoaiSP").HasColumnType("Nvarchar(max)").IsRequired();
            builder.Property(p => p.SoLuong).HasColumnName("SoLuong").HasColumnType("int").IsRequired();
            builder.Property(p => p.GiaSP).HasColumnName("GiaSP").HasColumnType("float").IsRequired();
            builder.Property(p => p.MaSale).HasColumnName("MaSale").HasColumnType("uniqueidentifier");

        }
    }
}
