using App_Data_ClassLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabC4.Configurations
{
    internal class GioHangChiTietConfigs : IEntityTypeConfiguration<GioHangChiTiet>
    {
        public void Configure(EntityTypeBuilder<GioHangChiTiet> builder)
        {
            builder.ToTable("GioHangChiTiet");
            builder.HasKey(P=>P.IDUser);
            builder.HasOne(p => p.SanPhamChiTiets).WithMany(p => p.GioHangChiTiets).
                HasForeignKey(p => p.IDSPCT).HasConstraintName("FK_SanPhamChiTiet_GioHangChiTiet");
            builder.Property(p=>p.TrangThai).HasColumnName("TrangThai").HasColumnType("int").IsRequired();
        }
    }
}
