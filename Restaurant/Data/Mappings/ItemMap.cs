using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Models;

namespace Restaurant.Data.Mappings;

public class ItemMap : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.ToTable("Item");

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

        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnName("Description")
            .HasColumnType("VARCHAR")
            .HasMaxLength(60);

        builder.Property(x => x.Price)
            .IsRequired()
            .HasColumnName("Price")
            .HasColumnType("FLOAT");

        builder.Property(x => x.Available)
            .IsRequired()
            .HasColumnName("Available")
            .HasColumnType("BOOL");

        builder
            .HasIndex(x => x.Slug, "IX_Item_SLug")
            .IsUnique();
    }
}