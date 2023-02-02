namespace TransferAPI.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public Account? DebitedAccountId { get; set; }
        public Account? CreditedAccountId { get; set; }
        public decimal Value { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
