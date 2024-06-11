using EFDemo1.DataClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFDemo1.Data.Mappings;

class CategoryMappings : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");

        builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name).HasColumnName("Name").IsRequired();
    }
}