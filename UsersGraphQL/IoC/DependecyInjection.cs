using Microsoft.EntityFrameworkCore;
using UsersGraphQL.GraphQL;
using UsersGraphQL.InfraStructure;

namespace UsersGraphQL.IoC;

public static class DependecyInjection
{
    public static IServiceCollection AddInfraStrucuture(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddPooledDbContextFactory<UsersContext>(options => options.UseSqlServer(configuration.GetConnectionString("UsersConnectionStrings")));
        services.AddGraphQLServer().AddQueryType<Query>();

        return services;
    }
}
