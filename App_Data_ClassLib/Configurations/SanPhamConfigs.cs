using App_Data_ClassLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabC4.Configurations
{
    internal class SanPhamConfigs : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPham");
            builder.HasKey(p=>p.IDSP);
            builder.HasMany(p => p.SanPhamChiTiet).WithOne(p => p.SanPham).
               HasForeignKey(p => p.IDSP).HasConstraintName("FK_SanPham_SanPhamChiTiet");
            builder.Property(p=>p.TenSP).HasColumnName("TenSP").HasColumnType("Nvarchar(max)").IsRequired();
            builder.Property(p=>p.GiaSP).HasColumnName("GiaSP").HasColumnType("float").IsRequired();
            builder.Property(p=>p.SoLuongTon).HasColumnName("SoLuongTon").HasColumnType("int").IsRequired();
            builder.Property(p=>p.TrangThai).HasColumnName("TrangThai").HasColumnType("int").IsRequired();

        }
    }
}
