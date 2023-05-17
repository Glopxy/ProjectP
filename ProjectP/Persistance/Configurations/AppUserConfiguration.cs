using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PinternAPI.Core.Domain;

namespace PinternAPI.Persistance.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<Intern>
    {
        public void Configure(EntityTypeBuilder<Intern> builder)
        {
            builder.HasOne(x => x.AppRole).WithMany(x => x.Interns).HasForeignKey(x => x.AppRoleId);
            builder.HasOne(x => x.Transaction).WithMany(x => x.Interns).HasForeignKey(x => x.TransactionId);
        }
    }

}
