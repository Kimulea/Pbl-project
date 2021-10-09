using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pbl.Domain.Auth;

namespace Pbl.Dal.EntityConfiguration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .Property(x => x.BirthDate)
                .HasColumnType("Date");

            builder
                .Property(x => x.BirthDate)
                .HasDefaultValueSql("getdate()");
        }
    }
}
