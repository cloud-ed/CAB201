
class InvalidPathException : Exception
{
    public InvalidPathException() : base() { }
    public InvalidPathException(string message) : base(message) { }
    public InvalidPathException(string message, Exception? innerException) : base(message, innerException) { }
}