using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Models;

namespace Restaurant.Data.Mappings;

public class TableMap : IEntityTypeConfiguration<Table>
{
    public void Configure(EntityTypeBuilder<Table> builder)
    {
        builder.ToTable("Table");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        builder.Property(x => x.TableNumber)
            .IsRequired()
            .HasColumnName("TableNumber")
            .HasColumnType("INT");

        builder.Property(x => x.Capacity)
            .IsRequired()
            .HasColumnName("Capacity")
            .HasColumnType("INT");

        builder
            .HasIndex(x => x.TableNumber, "IX_Table_TableNumber")
            .IsUnique();
    }
}