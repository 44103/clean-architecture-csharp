using Domain.Domain.Users;

namespace Infrastructure.InMemoryInfrastructure.Users
{
    public class InMemoryUserRepository : IUserRepository
    {
        private Dictionary<string, User> data = new Dictionary<string, User>();

        private User CloneUser(User user)
        {
            return new User(user.Id, user.Name);
        }

        public void Save(User user)
        {
            data[user.Id] = CloneUser(user);
        }

        public User? FindByUserName(string name)
        {
            return data.Select(x => x.Value).FirstOrDefault(x => x.Name == name);
        }

        public IEnumerable<User> FindAll()
        {
            return data.Values;
        }
    }
}
