using Microsoft.EntityFrameworkCore;
using UsersGraphQL.GraphQL;
using UsersGraphQL.GraphQL.Adresses;
using UsersGraphQL.GraphQL.Users;
using UsersGraphQL.InfraStructure;

namespace UsersGraphQL.IoC;

public static class DependecyInjection
{
    public static IServiceCollection AddInfraStrucuture(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddPooledDbContextFactory<UsersContext>(options => options.UseSqlServer(configuration.GetConnectionString("UsersConnectionStrings")));
        services
            .AddGraphQLServer()
            .AddQueryType<Query>()
            .AddMutationType<Mutation>()
            .AddType<AdressesTypes>()
            .AddType<UsersTypes>()
            .AddSubscriptionType<Subscription>()
            .AddFiltering()
            .AddSorting()
            .AddInMemorySubscriptions();

        return services;
    }
}
