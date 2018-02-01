using T_Service.Models;
using Microsoft.EntityFrameworkCore;

namespace T_Service.Data
{
    public class T_ServiceContext : DbContext
    {
        public T_ServiceContext(DbContextOptions<T_ServiceContext> options) : base(options)
        {
        }

        public DbSet<mUser> userProfile { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<cDelivery_product>()
				.Property(x => x.created_datetime)
				.HasDefaultValueSql("getdate()");
		}

    }
}