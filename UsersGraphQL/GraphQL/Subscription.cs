using UsersGraphQL.Models;

namespace UsersGraphQL.GraphQL
{
    public class Subscription
    {
        [Subscribe]
        [Topic]
        public User OnUserAdded([EventMessage] User user)
        {
            return user;
        }
    }
}
