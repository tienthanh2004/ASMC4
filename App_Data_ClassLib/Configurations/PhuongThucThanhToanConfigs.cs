using App_Data_ClassLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabC4.Configurations
{
    internal class PhuongThucThanhToanConfigs : IEntityTypeConfiguration<PhuongThucThanhToan>
    {
        public void Configure(EntityTypeBuilder<PhuongThucThanhToan> builder)
        {
            builder.ToTable("PhuongThucThanhToan");
            builder.HasKey(p => p.IDPTTT);
           
        }
    }
}
