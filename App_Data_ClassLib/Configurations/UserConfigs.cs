using App_Data_ClassLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabC4.Configurations
{
    internal class UserConfigs : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");
            builder.HasKey(p=>p.UserID);
            builder.HasOne(p => p.GioHangs)
                  .WithOne(p => p.Users)
                  .HasForeignKey<GioHang>(p => p.UserID);
            builder.Property(p => p.ChucVu).HasColumnType("Nvarchar(10)").HasColumnName("ChucVu").IsRequired();
            builder.Property(p => p.TenNguoiDung).HasColumnType("Nvarchar(max)").HasColumnName("TenNguoiDung").IsRequired();
            builder.Property(p => p.Matkhau).HasColumnName("MatKhau").HasColumnType("Nvarchar(max)").IsRequired();
                builder.Property(p => p.SoDienThoai).HasColumnName("SoDienThoai").HasColumnType("Nvarchar(50)").IsRequired();
            builder.Property(p => p.DiaChi).HasColumnName("DiaChi").HasColumnType("Nvarchar(max)").IsRequired();
        }
    }
}
