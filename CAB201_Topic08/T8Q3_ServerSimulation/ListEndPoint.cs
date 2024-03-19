﻿namespace ServerSimulation;
/// <summary>
/// An endpoint of a server that can be used to list all endpoints of the server.
/// </summary>
class ListEndPoint : EndPoint
{
    private Server server;

    /// <summary>
    /// The list of endpoints of the server.
    /// </summary>
    public override string Response
    {
        get
        {
            string response = "";
            foreach (EndPoint endPoint in server.EndPoints)
            {
                response += server.Identifier + endPoint.Path + "\n";
            }
            return response;
        }
    }

    /// <summary>
    /// Creates a new endpoint with the given path and response.
    /// </summary>
    /// <param name="server">The server that the endpoint is in.</param>
    public ListEndPoint(Server server) : base("/list")
    {
        this.server = server;
    }
}