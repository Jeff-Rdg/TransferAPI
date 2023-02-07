namespace TransferAPI.Exceptions
{
    public class TransferException : Exception
    {
        public TransferException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
