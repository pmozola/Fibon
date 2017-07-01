using System.Threading.Tasks;

namespace Fibon.Messages.Commands
{
    public interface ICommand
    {
    }

    public interface ICommandHandler<in T> where T : ICommand
    {
        Task HandleAync(T command);
    }

    public class CalculateValueCommand : ICommand
    {
        public CalculateValueCommand()
        {
        }

        public CalculateValueCommand(int number)
        {
            Number = number;
        }

        public int Number { get; set; }
    }
}