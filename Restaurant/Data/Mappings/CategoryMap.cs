using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Models;

namespace Restaurant.Data.Mappings;

public class CategoryMap : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Category");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("VARCHAR")
            .HasMaxLength(60);

        builder.Property(x => x.Slug)
            .IsRequired()
            .HasColumnName("Slug")
            .HasColumnType("VARCHAR")
            .HasMaxLength(60);

        builder
            .HasIndex(x => x.Slug, "IX_Category_Slug")
            .IsUnique();
    }
}