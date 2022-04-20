using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp1.Areas.Identity.Data;
using WebApp1.Models;

namespace WebApp1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp1.Areas.Identity.Data.WebApp1User> WebApp1Users { get; set; }
        public virtual DbSet<Entite> Entite { get; set; }
        public virtual DbSet<ImageUtilisateur> Image { get; set; }
        public virtual DbSet<Profil> Profil { get; set; }
        public virtual DbSet<Site> Site { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUser>().ToTable("Utilisateur").Property(p => p.Id).HasColumnName("UtilisateurID");
            //builder.Entity<IdentityUser>().ToTable("Utilisateur").Property(p => p.PasswordHash).HasColumnName("MDPChiffre");
            builder.Entity<IdentityUser>().Ignore(p => p.NormalizedUserName );
            builder.Entity<IdentityUser>().Ignore(p => p.NormalizedEmail);
            builder.Entity<IdentityUser>().Ignore(p => p.ConcurrencyStamp);
            builder.Entity<IdentityUser>().Ignore(p => p.PhoneNumber);
            builder.Entity<IdentityUser>().Ignore(p => p.PhoneNumberConfirmed);
            builder.Entity<IdentityUser>().Ignore(p => p.TwoFactorEnabled);
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