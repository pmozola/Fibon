using System;
using System.Threading.Tasks;
using Fibon.Messages.Commands;
using Fibon.Messages.Events;
using RawRabbit;

namespace Fibon.Service.Handlers
{
    public class CalculatedValueCommandHandler : ICommandHandler<CalculateValueCommand>
    {
        private readonly IBusClient _busCilent;

        public CalculatedValueCommandHandler(IBusClient busClient)
        {
            _busCilent = busClient;
        }

        private static int Fib(int n)
        {
            switch (n)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:
                    return Fib(n - 2) + Fib(n - 1);
            }
        }

        public async Task HandleAync(CalculateValueCommand command)
        {
            var result = Fib(command.Number);
            await _busCilent.PublishAsync(new ValueCalculatedEvent(command.Number, result));
        }
    }
}
