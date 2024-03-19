namespace ServerSimulation;
class Server
{
    private List<EndPoint> endPoints;
    private string identifier;

    /// <summary>
    /// The identifier of the server.
    /// </summary>
    /// <exception cref="InvalidPathException">Thrown when the identifier is null or empty, or contains /.</exception>
    public string Identifier
    {
        get
        {
            return identifier;
        }
        set
        {
            // Insert your code here to check if the identifier is null or empty, or contains /.
            // If it is, throw an InvalidPathException with the message
            // "Identifier cannot be null or empty" or
            // "Server identifier cannot contain /"
            if (string.IsNullOrEmpty(value))
            {
                throw new InvalidPathException("Identifier cannot be null or empty");
            }
            if (value.Contains('/'))
            {
                throw new InvalidPathException("Server identifier cannot contain /");
            }
            identifier = value;
        }
    }

    /// <summary>
    /// Gets the end points of the server.
    /// </summary>
    public EndPoint[] EndPoints
    {
        get
        {
            return endPoints.ToArray();
        }
    }

    /// <summary>
    /// Creates a new server with the given identifier. All servers contain a /list endpoint by default.
    /// </summary>
    /// <param name="identifier">The identifier of the server.</param>
    /// <exception cref="ArgumentException">Thrown when the identifier is null or empty, or contains /.</exception>
    public Server(string identifier)
    {
        Identifier = identifier;
        endPoints = new List<EndPoint>()
        {
            new ListEndPoint(this)
        };
    }

    /// <summary>
    /// Adds a unique endpoint to the server.
    /// </summary>
    /// <param name="path">The path of the endpoint.</param>
    /// <param name="response">The response of the endpoint.</param>
    /// <exception cref="ArgumentException">Thrown when the path already exists in the server.</exception>
    public void AddEndPoint(string path, string response)
    {
        // Insert your code here to loop through the end points and check if the path already exists.
        // If it does, throw an ArgumentException with the message
        // $"Path {path} already exists in server {Identifier}"
        foreach (EndPoint endPoint in endPoints)
        {
            if (endPoint.Path.Equals(path))
            {
                throw new ArgumentException($"Path {path} already exists in server {Identifier}");
            }
        }
        endPoints.Add(new EndPoint(path, response));
    }

    /// <summary>
    /// Gets the response of the endpoint with the given path.
    /// </summary>
    /// <param name="path">The path of the endpoint.</param>
    /// <returns>The response of the endpoint.</returns>
    /// <exception cref="InvalidPathException">Thrown when the path does not exist in the server.</exception>
    public string GetResponse(string path)
    {
        foreach (EndPoint endPoint in endPoints)
        {
            if (endPoint.Path.Equals(path))
            {
                return endPoint.Response;
            }
        }
        // Insert your code here to throw an InvalidPathException with the message
        // $"Endpoint {path} not found in server {Identifier}"
        // if the path does not exist in the server.
        // You may remove the return statement after throwing the exception.
        throw new InvalidPathException($"Endpoint {path} not found in server {Identifier}");
    }
}