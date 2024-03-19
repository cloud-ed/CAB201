namespace UserManagement;
/// <summary>
/// The user manager that handles interactions with users created.
/// </summary>
class UserManager
{
    private List<User> users;
    private User? currentUser;

    /// <summary>
    /// Constructs a new user manager.
    /// </summary>
    public UserManager()
    {
        users = new List<User>();
        currentUser = null;
    }

    /// <summary>
    /// Registers a new user by reading the email and password from the console.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the email or password is invalid.</exception>
    public void RegisterFromConsole()
    {
        Console.WriteLine("Enter email:");
        string? email = Console.ReadLine();

        Console.WriteLine("Enter password:");
        string? password = Console.ReadLine();

        Console.WriteLine("Confirm password:");
        string? confirmPassword = Console.ReadLine();

        User user = new User(email, password, confirmPassword);
        users.Add(user);
    }

    /// <summary>
    /// Logs in a user by reading the email and password from the console.
    /// </summary>
    public void LoginFromConsole()
    {
        Console.WriteLine("Enter email:");
        string? email = Console.ReadLine();
        Console.WriteLine("Enter password:");
        string? password = Console.ReadLine();
        foreach (User user in users)
        {
            if (user.Email == email && user.Password == password)
            {
                currentUser = user;
                return;
            }
        }
        Console.WriteLine("Invalid email or password.");
    }

    /// <summary>
    /// Logs out the current user.
    /// </summary>
    /// <exception cref="UnauthenticatedException">Thrown when there is no current user.</exception>
    public void Logout()
    {
        // Insert your solution here to throw an UnauthenticatedException with the message "Cannot logout when not logged in" when there is no current user.
        if (currentUser == null)
        {
            throw new UnauthenticatedException("Cannot logout when not logged in");
        }
        currentUser = null;
    }

    /// <summary>
    /// Prints the users.
    /// </summary>
    /// <exception cref="UnauthenticatedException">Thrown when there is no current user.</exception>
    public void PrintUsers()
    {
        // Insert your solution here to throw an UnauthenticatedException with the message "Cannot print users when not logged in" when there is no current user.
        if (currentUser == null)
        {
            throw new UnauthenticatedException("Cannot print users when not logged in");
        }

        foreach (User user in users)
        {
            Console.WriteLine($"Email: {user.Email}, Password: {user.Password}");
        }
    }
}

class UnauthenticatedException : Exception
{
    public UnauthenticatedException() : base() { }
    public UnauthenticatedException(string message) : base(message) { }
    public UnauthenticatedException(string message,  Exception? innerException) : base(message, innerException) { }
}