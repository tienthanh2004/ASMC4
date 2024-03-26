using App_Data_ClassLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabC4.Configurations
{
    internal class HoaDonConfigs : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(p => p.IDHD);
            builder.HasMany(p => p.HoaDonChiTiets).WithOne(p => p.HoaDons)
                   .HasForeignKey(p => p.IDHD).HasConstraintName("FK_HoaDons_HDCTS");
            builder.HasMany(p => p.PhuongThucThanhToans).WithOne(p => p.HoaDons)
                .HasForeignKey(p => p.IDPTTT).HasConstraintName("FK_PTTT_HoaDons");
            builder.Property(p=>p.DiaChi).HasColumnName("DiaChi").HasColumnType("Nvarchar(max)").IsRequired();
            builder.Property(p=>p.SoDienThoai).HasColumnName("SoDienThoai").HasColumnType("Nvarchar(50)").IsRequired();
            builder.Property(p=>p.TongTien).HasColumnName("TongTien").HasColumnType("float").IsRequired();
            builder.Property(p => p.ThoiGianThanhToan).HasColumnName("ThoiGianThanhToan").HasColumnType("DateTime").IsRequired();
            builder.Property(p => p.IDVouncher).HasColumnName("IDVouncher").HasColumnType("uniqueidentifier");
            builder.Property(p => p.TrangThai).HasColumnName("TrangThai").HasColumnType("int").IsRequired();
           
        }
    }
}
