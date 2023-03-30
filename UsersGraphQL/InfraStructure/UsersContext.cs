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
}
