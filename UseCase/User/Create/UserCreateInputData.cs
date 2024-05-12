namespace UseCase.User.Create
{
    public class UserCreateInputData
    {
        public string UserName { get; }

        public UserCreateInputData(string userName)
        {
            UserName = userName;
        }
    }
}
