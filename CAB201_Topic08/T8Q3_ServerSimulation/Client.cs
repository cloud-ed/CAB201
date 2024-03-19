namespace ServerSimulation;
/// <summary>
/// Represents a client that can get responses from some registered servers.
/// </summary>
class Client
{
    /// <summary>
    /// Parses the given path and gets the server and server path.
    /// </summary>
    /// <param name="path">The path to parse.</param>
    /// <param name="serverHub">The server hub to search for the server in.</param>
    /// <param name="server">Output parameter for the server found.</param>
    /// <param name="endpoint">Output parameter for the server path.</param>
    private static void ProcessPath(string path, ServerHub serverHub, out Server? server, out string endpoint)
    {
        string[] pathParts = path.Split("/");

        // Insert your code here to check if the path contains at least two parts.
        // If it does not, throw an InvalidPathException with the message
        // "Path must contain server identifier and endpoint path, separated by /"
        if (pathParts.Length < 2)
        {
            throw new InvalidPathException($"Invalid path {path}, must contain server identifier and endpoint path, separated by /");
        }
        string serverIdentifier = pathParts[0];
        server = serverHub.SearchServer(serverIdentifier);

        // Insert your code here to check if the server exists.
        // If it does not, throw an ServerNotFoundException with the message
        // $"Server {serverIdentifier} not registered"
        if (server == null)
        {
            throw new ServerNotFoundException($"Server {serverIdentifier} not registered");
        }
        endpoint = "/" + string.Join("/", pathParts[1..]);
    }

    /// <summary>
    /// Gets the response using the given path and server hub.
    /// </summary>
    /// <param name="path">The path to get the response from, in the format serverIdentifier/endpointPath.</param>
    /// <param name="serverHub">The server hub to get the response from.</param>
    /// <returns>The response of the server endpoint.</returns>
    /// <exception cref="FailedRequestException">Thrown when the response could not be fetched.</exception>
    public string Fetch(string path, ServerHub serverHub)
    {
        // Insert your code here to wrap the following code in a try-catch block.
        // If an exception is thrown, throw a new FailedRequestException with the message
        // "Failed to fetch response" and the original exception as the inner exception.
        try
        {
            ProcessPath(path, serverHub, out Server? server, out string serverPath);
            return server.GetResponse(serverPath);
        } 
        catch (Exception e)
        {
            throw new FailedRequestException($"Could not fetch the given path {path}", e);
        }
    }
}