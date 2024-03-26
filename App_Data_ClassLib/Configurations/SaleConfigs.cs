using App_Data_ClassLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabC4.Configurations
{
    internal class SaleConfigs : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(p => p.MaSale);
            builder.HasMany(p => p.SanPhamChiTiets).WithOne(p => p.Sales)
            .HasForeignKey(p => p.MaSale).HasConstraintName("FK_Sales_Users");
            builder.Property(p=>p.TenSale).HasColumnName("TenSale").HasColumnType("Nvarchar(max)").IsRequired();
            builder.Property(p => p.NgayBatDau).HasColumnName("NgayBatDau").HasColumnType("DateTime").IsRequired();
            builder.Property(p => p.NgayKetThuc).HasColumnName("NgayketThuc").HasColumnType("DateTime").IsRequired();
            builder.Property(p => p.SoLuong).HasColumnName("SoLuong").HasColumnType("int").IsRequired();
            builder.Property(p => p.GiaTri).HasColumnName("GiaTri").HasColumnType("float").IsRequired();
            builder.Property(p => p.TrangThai).HasColumnName("TrangThai").HasColumnType("int").IsRequired();

        }
    }
}
