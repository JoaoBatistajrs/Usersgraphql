using UsersGraphQL.InfraStructure;
using UsersGraphQL.Models;

namespace UsersGraphQL.GraphQL;

public class Query
{
    [UseDbContext(typeof(UsersContext))]
    public IQueryable<User> GetUsers([ScopedService] UsersContext context)
    {
        return context.Users;
    }
}
