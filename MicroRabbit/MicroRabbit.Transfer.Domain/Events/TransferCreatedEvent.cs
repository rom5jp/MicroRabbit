using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Transfer.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public int FromAccount { get; private set; }
        public int ToAccount { get; private set; }
        public decimal Amount { get; private set; }

        public TransferCreatedEvent(int fromAccount, int toAccount, decimal amount)
        {
            FromAccount = fromAccount;
            ToAccount = toAccount;
            Amount = amount;
        }
    }
}
