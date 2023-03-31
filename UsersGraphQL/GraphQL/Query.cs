using UsersGraphQL.InfraStructure;
using UsersGraphQL.Models;

namespace UsersGraphQL.GraphQL;

public class Query
{
    [UseDbContext(typeof(UsersContext))]
    [UseProjection]
    public IQueryable<User> GetUsers([ScopedService] UsersContext context)
    {
        return context.Users;
    }

    [UseDbContext(typeof(UsersContext))]
    [UseProjection]
    public IQueryable<Adress> GetAdresses([ScopedService] UsersContext context)
    {
        return context.Adresses;
    }
}
