using UsersGraphQL.InfraStructure;
using UsersGraphQL.Models;

namespace UsersGraphQL.GraphQL.Adresses;

public class AdressesTypes : ObjectType<Adress>
{
    protected override void Configure(IObjectTypeDescriptor<Adress> descriptor)
    {
        descriptor.Description("Represent an Adress on the system.");

        descriptor
            .Field(a => a.User)
            .ResolveWith<Resolvers>(u => u.GetAdresses(default!, default!))
            .UseDbContext<UsersContext>()
            .Description("This respresents any register about adress that are included in an User.");
    }

    private class Resolvers
    {
        public User GetAdresses([Parent] Adress adress, [ScopedService] UsersContext context)
        {
            return context.Users.FirstOrDefault(u => u.Id == adress.UserId);
        }
    }
}
