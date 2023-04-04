using UsersGraphQL.Models;

namespace UsersGraphQL.GraphQL.Adresses;

public record AddAdressInput(string city, long postalCode, string street, int userId);


