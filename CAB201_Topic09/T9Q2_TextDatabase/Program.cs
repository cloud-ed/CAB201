namespace TextDatabase;
enum MenuOption
{
    Default,
    ListAllBooks,
    AddNewBook,
    RemoveBook,
    SaveAndExit
}

class Program
{
    static void Main(string[] args)
    {
        // Keep this line intact
        Console.WriteLine("===========================");
        Console.WriteLine("Enter the path to the database:");
        string path = Console.ReadLine();
        ILibrary library = new Library(path);
        // Insert your solution here to display the menu,
        // get the user's choice, and run the selected option.
        // The menu should be displayed repeatedly until the user
        // chooses to save and exit.
        // The menu should also handle any exceptions thrown by
        // the RunOption method.
        while (true)
        {
            // Display the menu

            // Get the user's choice

            // Run the selected option using RunOption

            // If the user chooses to save and exit, break out of the loop


            // If any exceptions are thrown by RunOption, catch them here
            // and display the message, i.e.:
            // Console.WriteLine(exception.Message)
            DisplayOptions();
            MenuOption option = GetMenuOptionFromConsole();
            try
            {
                RunOption(option, library);
                if (option == MenuOption.SaveAndExit)
                {
                    break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Keep this line intact
        Console.WriteLine("===========================");
    }

    static void RunOption(MenuOption option, ILibrary library)
    {
        // Insert your solution here to run the selected option.
        // You may use the static methods defined below
        // to get the necessary input from the user for
        // AddNewBook and RemoveBook.
        switch (option)
        {
            case MenuOption.ListAllBooks:
                library.ListAllBooks(); break;

            case MenuOption.AddNewBook:
                library.AddBook(GetBookFromConsole()); break;

            case MenuOption.RemoveBook:
                RemoveBookFromConsole(library); break;

            case MenuOption.SaveAndExit:
                library.Save(); break;

            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }

    /// <summary>
    /// Displays the menu options to the user.
    /// </summary>
    static void DisplayOptions()
    {
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. List all books");
        Console.WriteLine("2. Add a new book");
        Console.WriteLine("3. Remove a book");
        Console.WriteLine("4. Save and exit");
    }

    /// <summary>
    /// Gets the menu option from the user.
    /// </summary>
    /// <returns>The menu option.</returns>
    static MenuOption GetMenuOptionFromConsole()
    {
        Console.WriteLine("Enter your choice:");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int option))
        {
            return (MenuOption)option;
        }
        return MenuOption.Default;
    }

    /// <summary>
    /// Reads the book information from the console.
    /// </summary>
    /// <returns>A new book.</returns>
    static Book GetBookFromConsole()
    {
        Console.WriteLine("Enter the book's title:");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the book's author:");
        string author = Console.ReadLine();
        Console.WriteLine("Enter the book's publication year:");
        int year = int.Parse(Console.ReadLine());
        return new Book(title, author, year);
    }

    /// <summary>
    /// Removes a book from the library by reading the title from the console.
    /// </summary>
    /// <param name="library">The library.</param>
    static void RemoveBookFromConsole(ILibrary library)
    {
        Console.WriteLine("Enter the book's title:");
        string title = Console.ReadLine();
        library.RemoveBook(title);
    }
}