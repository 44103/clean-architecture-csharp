using Domain.Domain.Users;
using UseCase.User.Create;

namespace Domain.Application.User
{
    public class UserCreateInteractor : IUserCreateUseCase
    {
        private readonly IUserRepository userRepository;
        private readonly IUserCreatePresenter presenter;

        public UserCreateInteractor(IUserRepository userRepository, IUserCreatePresenter presenter)
        {
            this.userRepository = userRepository;
            this.presenter = presenter;
        }

        public void Handle(UserCreateInputData inputData)
        {
            var userName = inputData.UserName;
            var duplicatedUser = userRepository.FindByUserName(userName);
            if (duplicatedUser != null)
            {
                throw new Exception("Duplicated");
            }

            var user = new Domain.Users.User(userName);
            userRepository.Save(user);

            presenter.Complete(new UserCreateOutputData(user.Id, DateTime.Now));
        }
    }
}
