using App_Data_ClassLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabC4.Configurations
{
    internal class GioHangConfigs : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.ToTable("GioHang");
            builder.HasKey(p=>p.UserID);
            builder.HasMany(p => p.GioHangChiTiet).WithOne(p => p.GioHangs)
                   .HasForeignKey(p => p.IDUser);
            builder.Property(p=>p.SoLuongSP).HasColumnName("SoLuongSP").HasColumnType("int").IsRequired();
            builder.Property(p=>p.GiaSanPham).HasColumnName("GiaSanPham").HasColumnType("float").IsRequired();

              
        }
    }
}
