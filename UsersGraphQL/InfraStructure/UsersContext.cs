using Microsoft.EntityFrameworkCore;
using UsersGraphQL.Models;

namespace UsersGraphQL.InfraStructure;

public class UsersContext : DbContext
{
    public UsersContext(DbContextOptions<UsersContext> options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Adress> Adresses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<User>()
            .HasMany(p => p.Adresses)
            .WithOne(p => p.User!)
            .HasForeignKey(p => p.UserId);

        modelBuilder
            .Entity<Adress>()
            .HasOne(p => p.User)
            .WithMany(p => p.Adresses)
            .HasForeignKey(p => p.UserId);
    }
}
