using MediatR;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Events;
using MicroRabbit.Domain.Core.Bus;
using System.Threading;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.CommandHandlers
{
    // The customer you login, will have a chance to view all their account information through of our banking microservices. 
    // He'll initate a transfer. As well as initiate a transfer, which is a COMMAND that is sent through the BUS from our Service, 
    // and then it's handled in the CommandHandler. 
    // Lastly, the TransferCommandHandler will actually finally publish the event to RabbitMQ.
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            // Publish event to RabbitMQ
            _bus.Publish(new TransferCreatedEvent(request.FromAccount, request.ToAccount, request.Amount));

            return Task.FromResult(true);
        }
    }
}
