namespace PolymorphicMenu;
/// <summary>
/// Program entry point for library document management system. DO NOT MODIFY THIS FILE.
/// </summary>
class Program
{
    /// <summary>Main entry point.</summary>
    /// <param name="args">Command line arguments: if supplied, args[0] 
    /// is the name of a text file containing account information.</param>
    public static void Main(string[] args)
    {
        Console.WriteLine("===========================");

        Library library = new Library();
        MainMenu menu = new MainMenu(library);
        menu.Display();

        Console.WriteLine("===========================");
    }
}