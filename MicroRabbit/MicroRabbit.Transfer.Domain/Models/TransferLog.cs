namespace MicroRabbit.Transfer.Domain.Models
{
    public class TransferLog
    {
        public int Id { get; set; }
        public int AccountFrom { get; set; }
        public int ToAccount { get; set; }
        public decimal Amount { get; set; }
    }
}
