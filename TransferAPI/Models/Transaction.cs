namespace TransferAPI.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public Account? DebitedAccount { get; set; }
        public Account? CreditedAccount { get; set; }
        public decimal Value { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
