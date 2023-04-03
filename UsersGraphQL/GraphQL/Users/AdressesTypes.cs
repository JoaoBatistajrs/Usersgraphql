using UsersGraphQL.InfraStructure;
using UsersGraphQL.Models;

namespace UsersGraphQL.GraphQL.Users;

public class AdressesTypes : ObjectType<Adress>
{
    protected override void Configure(IObjectTypeDescriptor<Adress> descriptor)
    {
        descriptor.Description("Represent and User Added on the system.");

        descriptor
            .Field(a => a.User)
            .ResolveWith<Resolvers>(u => u.GetAdresses(default!, default!))
            .UseDbContext<UsersContext>()
            .Description("");
    }

    private class Resolvers
    {
        public User GetAdresses(Adress adress, [ScopedService] UsersContext context)
        {
            return context.Users.FirstOrDefault(u => u.Id == adress.UserId);
        }
    }
}
