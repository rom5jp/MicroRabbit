using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;

        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            // Here we can do whatever we want...
            // Make calculation, talk to another API or service, etc...
            _transferRepository.Add(new TransferLog()
            {
                AccountFrom = @event.FromAccount,
                ToAccount = @event.ToAccount,
                Amount = @event.Amount
            });
                
            return Task.CompletedTask;
        }
    }
}
