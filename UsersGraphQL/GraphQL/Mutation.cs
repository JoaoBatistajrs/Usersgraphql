using UsersGraphQL.GraphQL.Adresses;
using UsersGraphQL.GraphQL.Users;
using UsersGraphQL.InfraStructure;
using UsersGraphQL.Models;

namespace UsersGraphQL.GraphQL;

public class Mutation
{
    [UseDbContext(typeof(UsersContext))]
    public async Task<AddUserPayload> AddUserAsync(AddUserInput input, [ScopedService] UsersContext context)
    {
        var user = new User
        {
            Name = input.name
        };

        context.Users.Add(user);
        await context.SaveChangesAsync();

        return new AddUserPayload(user);
    }

    [UseDbContext(typeof(UsersContext))]
    public async Task<AddAdressPayload> AddAdressAsync(AddAdressInput input, [ScopedService] UsersContext context)
    {
        var adress = new Adress
        {
            City = input.city,
            PostalCode = input.postalCode,
            Street = input.street,
            UserId = input.userId
        };

        context.Adresses.Add(adress);
        await context.SaveChangesAsync();

        return new AddAdressPayload(adress);
    }
}
