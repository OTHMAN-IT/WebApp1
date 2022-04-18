using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp1.Areas.Identity.Data;

namespace WebApp1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp1.Areas.Identity.Data.WebApp1User> WebApp1Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        }
    }

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<WebApp1User>
    {
        public void Configure(EntityTypeBuilder<WebApp1User> builder)
        {
            builder.Property(u => u.Name).HasMaxLength(255);
            builder.Property(u => u.DOB).HasMaxLength(255);
        }
    }
}