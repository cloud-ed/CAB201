class FailedRequestException : Exception
{
    public FailedRequestException() : base() { }
    public FailedRequestException(string message) : base(message) { }
    public FailedRequestException(string message, Exception? innerException) : base(message, innerException) { }
}