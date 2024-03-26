using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App_Data_ClassLib.Models
{
    public partial class ASMC4Context : DbContext
    {
        public ASMC4Context()
        {
        }

        public ASMC4Context(DbContextOptions<ASMC4Context> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-77CCL75;Initial Catalog=ASMC4;Integrated Security=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
		public DbSet<App_Data_ClassLib.Models.User> User { get; set; } = default!;
        public DbSet<App_Data_ClassLib.Models.SanPham> SanPhams { get; set; } = default!;

	}
}
