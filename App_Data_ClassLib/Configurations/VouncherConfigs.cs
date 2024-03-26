using App_Data_ClassLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabC4.Configurations
{
    internal class VouncherConfigs : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.ToTable("Vouncher");
            builder.HasKey(p=>p.IDVouncher);
            builder.HasMany(p => p.HoaDons).WithOne(p => p.Vounchers)
                .HasForeignKey(p => p.IDVouncher).HasConstraintName("FK_Vouncher_HDs");
            builder.Property(p => p.TenVouncher).HasColumnName("TenVouncher").HasColumnType("Nvarchar(max)").IsRequired();
            builder.Property(p => p.SoLuong).HasColumnName("Soluong").HasColumnType("int").IsRequired();
            builder.Property(p => p.GiaTri).HasColumnName("GiaTri").HasColumnType("float").IsRequired();
            builder.Property(p => p.DieuKien).HasColumnName("DieuKien").HasColumnType("int").IsRequired();
        }
    }
}
