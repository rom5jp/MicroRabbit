using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;
using System;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        public TransferEventHandler()
        {
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            // Here we can do whatever we want...
            // Make calculation, talk to another API or service, etc...
            return Task.CompletedTask;
        }
    }
}
