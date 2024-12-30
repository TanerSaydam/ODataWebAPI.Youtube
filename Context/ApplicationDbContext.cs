using Microsoft.EntityFrameworkCore;
using ODataWebAPI.Models;

namespace ODataWebAPI.Context;

public sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(builder =>
        {
            builder.Property(p => p.Price).HasColumnType("money");
        });

        modelBuilder.Entity<User>(builder =>
        {
            builder.Property(p => p.UserType)
            .HasConversion(type => type.Value, value => UserTypeEnum.FromValue(value));

            builder.OwnsOne(p => p.Address);
        });
    }
}