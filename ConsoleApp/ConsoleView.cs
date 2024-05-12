using ConsoleApp.User.Create;

namespace ConsoleApp
{
    public class ConsoleView : IDisposable
    {
        private readonly UserCreateSubject subject;

        public void Update(UserCreateViewModel viewModel)
        {
            Console.WriteLine($"id: {viewModel.UserId}, created: {viewModel.CreatedDate}");
        }

        public ConsoleView(UserCreateSubject subject)
        {
            subject.UserCreateViewModelUpdated += Update;
        }

        public void Dispose()
        {
            subject.UserCreateViewModelUpdated -= Update;
        }
    }
}
