using Microsoft.EntityFrameworkCore;
using PinternAPI.Core.Domain;
using PinternAPI.Persistance.Configurations;

namespace PinternAPI.Persistance.Context
{
    public class PinternContext : DbContext
    {
        public PinternContext(DbContextOptions<PinternContext> options) :base(options)
        {
        }

        public DbSet<AppRole> AppRoles => this.Set<AppRole>();
        public DbSet<Intern> Interns => this.Set<Intern>();
        public DbSet<Transaction> Transactions => this.Set<Transaction>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
