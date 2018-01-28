using T_Service.Models;
using Microsoft.EntityFrameworkCore;

namespace T_ServiceContext.Data
{
    public class T_ServiceContext : DbContext
    {
        public T_ServiceContext(DbContextOptions<T_ServiceContext> options) : base(options)
        {
        }

        public DbSet<mUser> userProfile { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<mUser>()
				.Property(x => x.createdDatetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<mUser>()
				.Property(x => x.updatedDatetime)
				.HasDefaultValueSql("getdate()");
		}

    }
}