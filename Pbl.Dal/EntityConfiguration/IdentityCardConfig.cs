using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pbl.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pbl.Dal.EntityConfiguration
{
    class IdentityCardConfig : IEntityTypeConfiguration<IdentityCard>
    {
        public void Configure(EntityTypeBuilder<IdentityCard> builder)
        {
            builder
                .ToTable("IdentityCards");

            builder
                .Property(x => x.FirstName)
                .HasMaxLength(80);

            builder
                .Property(x => x.BirthDate)
                .HasDefaultValueSql("getdate()");
        }
    }
}
