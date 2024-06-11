using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo1.DataClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFDemo1.Data.Mappings
{
    internal class TagMappings : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tags");

            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name).HasColumnName("Name").IsRequired();

            builder.HasMany(t => t.Persons).WithMany(p => p.Tags);
        }
    }
}
