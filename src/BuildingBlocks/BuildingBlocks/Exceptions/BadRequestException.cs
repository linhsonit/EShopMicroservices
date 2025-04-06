namespace BuildingBlocks.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message)
        {
        }
        public BadRequestException(string message, Exception innerException) : base(message, innerException)
        {
        }
        public BadRequestException(string message, string errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }
        public string ErrorCode { get; }
    }
}
