namespace ConsoleApp.User.Create
{
    public class UserCreateViewModel
    {
        public string UserId { get; }
        public string CreatedDate {  get; }

        public UserCreateViewModel(string userId, string createdDate)
        {
            UserId = userId;
            CreatedDate = createdDate;
        }
    }
}
