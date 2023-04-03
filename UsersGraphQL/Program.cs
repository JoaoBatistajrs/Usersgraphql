using UsersGraphQL.IoC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfraStrucuture(builder.Configuration);

var app = builder.Build();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL("/graphql");
    endpoints.MapGraphQLVoyager("ui/voyager");
});

app.Run();
