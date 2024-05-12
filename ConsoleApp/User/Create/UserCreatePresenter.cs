using UseCase.User.Create;

namespace ConsoleApp.User.Create
{
    public class UserCreatePresenter : IUserCreatePresenter
    {
        private readonly UserCreateSubject subject;

        public UserCreatePresenter(UserCreateSubject subject)
        {
            this.subject = subject;
        }

         public void Complete(UserCreateOutputData outputData)
        {
            var model = new UserCreateViewModel(outputData.UserId, outputData.Created.ToString("yyyy/MM/dd"));
            subject.UserCreateViewModel = model;
        }
    }
}
