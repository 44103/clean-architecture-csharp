namespace Domain.Domain.Users
{
    public class User
    {
        public string Id { get; }
        public string Name { get; }

        public User(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
        }

        public User(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
