using System.Threading.Tasks;
using System.Windows.Input;

namespace BasicMvvm.Commands.Abstraction
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync();
        bool CanExecute();
        void RaiseCanExecuteChanged();
    }

    // Generic interface
    public interface IAsyncCommand<T> : ICommand
    {
        Task ExecuteAsync(T parameter);
        bool CanExecute(T parameter);
        void RaiseCanExecuteChanged();
    }
}
