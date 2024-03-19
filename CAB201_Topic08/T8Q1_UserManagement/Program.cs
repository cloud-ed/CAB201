namespace UserManagement;
class Program
{
    enum MenuOption
    {
        Default,
        Register,
        Login,
        Logout,
        Print,
        Exit
    }

    /// <summary>
    /// The main entry point of the program.
    /// </summary>
    static void Main(string[] args)
    {
        Console.WriteLine("===========================");
        UserManager usersManager = new UserManager();

        Console.WriteLine("Welcome to User Management");

        MenuOption option = MenuOption.Default;
        while (option != MenuOption.Exit)
        {
            option = ReadOption();
            // Wrap the next line in a try-catch block to catch the following exceptions:
            // - ArgumentException, with the message "An invalid argument was provided: {exception.Message}."
            // - UnauthenticatedException, with the message "You are unauthenticated: {exception.Message}."
            try
            {
                OnOptionSelected(option, usersManager);
            } catch (ArgumentException ex)
            {
                Console.WriteLine($"An invalid argument was provided: {ex.Message}.");
            } catch (UnauthenticatedException ex)
            {
                Console.WriteLine($"You are unauthenticated: {ex.Message}.");
            }
        }

        Console.WriteLine("===========================");
    }

    /// <summary>
    /// Reads the option from the console.
    /// </summary>
    /// <returns>The option.</returns>
    static MenuOption ReadOption()
    {
        Console.WriteLine("---------------------------");
        foreach (MenuOption option in Enum.GetValues(typeof(MenuOption)))
        {
            if (option == MenuOption.Default)
            {
                continue;
            }
            Console.WriteLine($"{(int)option}. {option}");
        }
        Console.WriteLine("---------------------------");
        Console.WriteLine("Enter your option:");
        string optionStr = Console.ReadLine()!;
        if (int.TryParse(optionStr, out int optionInt))
        {
            return (MenuOption)optionInt;
        }
        return MenuOption.Default;
    }

    /// <summary>
    /// Executes the option selected.
    /// </summary>
    /// <param name="option">The option selected.</param>
    /// <param name="usersManager">The user manager to help execute the option.</param>
    /// <exception cref="ArgumentException">Thrown when the email or password is invalid.</exception>
    /// <exception cref="UnauthenticatedException">Thrown when no user is logged in.</exception>
    static void OnOptionSelected(MenuOption option, UserManager usersManager)
    {
        switch (option)
        {
            case MenuOption.Register:
                usersManager.RegisterFromConsole();
                break;
            case MenuOption.Login:
                usersManager.LoginFromConsole();
                break;
            case MenuOption.Logout:
                usersManager.Logout();
                break;
            case MenuOption.Print:
                usersManager.PrintUsers();
                break;
            case MenuOption.Exit:
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
}