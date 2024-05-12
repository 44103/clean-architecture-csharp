namespace UseCase.User.Create
{
    public class UserCreateOutputData
    {
        public string UserId { get; }
        public DateTime Created{ get; }

        public UserCreateOutputData(string userId, DateTime created)
        {
            UserId = userId;
            Created = created;
        }
    }
}
