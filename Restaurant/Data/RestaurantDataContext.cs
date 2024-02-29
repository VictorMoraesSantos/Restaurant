using Microsoft.EntityFrameworkCore;
using Restaurant.Data.Mappings;
using Restaurant.Models;

namespace Restaurant.Data;

public class RestaurantDataContext : DbContext
{
    public RestaurantDataContext(DbContextOptions<RestaurantDataContext> options) : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Table> Tables { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ItemMap());
        modelBuilder.ApplyConfiguration(new CategoryMap());
        modelBuilder.ApplyConfiguration(new UserMap());
        modelBuilder.ApplyConfiguration(new TableMap());
    }
}