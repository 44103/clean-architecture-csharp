using UseCase.User.Create;

namespace ConsoleApp.User
{
    public class UserController
    {
        private readonly IUserCreateUseCase userCreateUseCase;

        public UserController(IUserCreateUseCase userCreateUseCase)
        {
            this.userCreateUseCase = userCreateUseCase;
        }

        public void CreateUser(string userName)
        {
            userCreateUseCase.Handle(new UserCreateInputData(userName));
        }
    }
}
