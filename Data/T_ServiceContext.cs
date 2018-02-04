using T_Service.Models;
using Microsoft.EntityFrameworkCore;

namespace T_Service.Data
{
    public class T_ServiceContext : DbContext
    {
        public T_ServiceContext(DbContextOptions<T_ServiceContext> options) : base(options)
        {

        }

        public DbSet<cDelivery_product> DeliveryProducts { get; set; }
        public DbSet<cDelivery_work> DeliveryWorks { get; set; }
        public DbSet<cEvaluated_answer> EvaluatedAnswer { get; set; }
        public DbSet<cList_evaluated_question_choice> ListEvaluatedQuestionChoices { get; set; }
        public DbSet<cList_evaluated_question> ListEvaluatedQuestions { get; set; }
        public DbSet<cList_setup_product_accessory> ListSetupAccessoryProducts { get; set; }
        public DbSet<cList_setup_product_main> ListSetupMainProducts { get; set; }
        public DbSet<cList_Tservice_type> ListTserviceTypes { get; set; }
        public DbSet<cList_Tservice_work_status> ListTserviceWorkStatus { get; set; }
        public DbSet<cMember_book_address> MemberBookAddresses { get; set; }
        public DbSet<cMember> Members { get; set; }
        public DbSet<cSetup_product_accessory> SetupAccessoryProducts { get; set; }
        public DbSet<cSetup_product> SetupProducts { get; set; }
        public DbSet<cSetup_work_product_type> SetupWorkProductTypes { get; set; }
        public DbSet<cSetup_work> SetupWorks { get; set; }
        public DbSet<cTservice_work_employee> TserviceWorkEmployees { get; set; }
        public DbSet<cTservice_work> TserviceWorks { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<cDelivery_product>()
				.Property(x => x.created_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cDelivery_product>()
				.Property(x => x.updated_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cDelivery_work>()
				.Property(x => x.created_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cDelivery_work>()
				.Property(x => x.updated_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cEvaluated_answer>()
				.Property(x => x.created_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cEvaluated_answer>()
				.Property(x => x.updated_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cList_evaluated_question_choice>()
				.Property(x => x.created_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cList_evaluated_question_choice>()
				.Property(x => x.updated_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cList_evaluated_question>()
				.Property(x => x.created_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cList_evaluated_question>()
				.Property(x => x.updated_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cMember_book_address>()
				.Property(x => x.created_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cMember_book_address>()
				.Property(x => x.updated_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cMember>()
				.Property(x => x.created_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cMember>()
				.Property(x => x.updated_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cSetup_product_accessory>()
				.Property(x => x.created_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cSetup_product_accessory>()
				.Property(x => x.updated_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cSetup_product>()
				.Property(x => x.created_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cSetup_product>()
				.Property(x => x.updated_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cSetup_work>()
				.Property(x => x.created_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cSetup_work>()
				.Property(x => x.updated_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cTservice_work>()
				.Property(x => x.created_datetime)
				.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<cTservice_work>()
				.Property(x => x.updated_datetime)
				.HasDefaultValueSql("getdate()");
		}

    }
}