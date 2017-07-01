namespace Fibon.Messages.Commands
{
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