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
    internal class PersonTagMappings : IEntityTypeConfiguration<PersonTag>
    {
        public void Configure(EntityTypeBuilder<PersonTag> builder)
        {
            builder.ToTable("PersonTag");

            builder.Property(pt => pt.FK_PersonId).HasColumnName("FK_PersonId").IsRequired();
            builder.Property(pt => pt.FK_TagId).HasColumnName("FK_TagId").IsRequired();
            builder.HasKey(pt => new { pt.FK_PersonId, pt.FK_TagId });

            builder.HasOne(pt => pt.Person).WithMany(p => p.PersonTags).HasForeignKey(pt => pt.FK_PersonId);
            builder.HasOne(pt => pt.Tag).WithMany(p => p.PersonTags).HasForeignKey(pt => pt.FK_TagId);
        }
    }
}
