using UsersGraphQL.InfraStructure;
using UsersGraphQL.Models;

namespace UsersGraphQL.GraphQL.Users;

public class UsersTypes : ObjectType<User>
{
    protected override void Configure(IObjectTypeDescriptor<User> descriptor)
    {
        descriptor.Description("Represent and User Added on the system.");

        descriptor
            .Field(u => u.Adresses)
            .ResolveWith<Resolvers>(u => u.GetAdresses(default!, default!))
            .UseDbContext<UsersContext>()
            .Description("This is a list of adresses in an User.");
    }

    private class Resolvers
    {
        public IQueryable<Adress> GetAdresses([Parent] User user, [ScopedService] UsersContext context)
        {
            return context.Adresses.Where(a => a.UserId == user.Id);
        }
    }
}
