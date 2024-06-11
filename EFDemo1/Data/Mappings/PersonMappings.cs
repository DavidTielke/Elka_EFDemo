using EFDemo1.DataClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFDemo1.Data.Mappings;

class PersonMappings : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("Persons");

        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name).HasColumnName("Name").IsRequired();

        builder.Property(p => p.Age).HasColumnName("Age").IsRequired();

        builder.Property(p => p.FK_CategoryId).HasColumnName("FK_CategoriesId").IsRequired();

        builder.HasOne(p => p.Category).WithMany(c => c.Persons).HasForeignKey(p => p.FK_CategoryId);
    }
}

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