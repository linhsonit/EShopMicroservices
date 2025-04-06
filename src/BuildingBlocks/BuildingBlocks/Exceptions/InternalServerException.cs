namespace BuildingBlocks.Exceptions
{
    public class InternalServerException : Exception
    {
        public InternalServerException(string message) : base(message)
        {
        }
        public InternalServerException(string message, Exception innerException) : base(message, innerException)
        {
        }
        public InternalServerException(string message, string code) : base(message)
        {
            Code = code;
        }
        public string Code { get; set; } = "InternalServerError";
    }
}
