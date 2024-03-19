using System.Runtime.CompilerServices;

namespace IterativeMethods;
enum MenuOption
{
    Default,
    DisplayFileContents,
    ConvertToUppercase,
    AddPrefix,
    AddSuffix,
    DisplayLength,
    GetLinesThatContainWord,
    GetLinesThatIsAtMostLength,
    Exit
}

class Program
{
    /// <summary>
    /// The entry point of the program. DO NOT MODIFY THIS METHOD.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Console.WriteLine("===========================");

        Console.Write("Enter the file path: ");
        string path = Console.ReadLine();
        IIterable iterable = LoadData(path);

        while (true)
        {
            DisplayOptions();
            Console.Write("Enter your option: ");
            if (!int.TryParse(Console.ReadLine(), out int option))
            {
                Console.WriteLine("Invalid option");
                continue;
            }
            RunOption((MenuOption)option, iterable, out bool terminated);
            if (terminated)
            {
                break;
            }
        }

        Console.WriteLine("===========================");
    }

    /// <summary>
    /// Displays the options to the user. DO NOT MODIFY THIS METHOD.
    /// </summary>
    static void DisplayOptions()
    {
        Console.WriteLine("1. Display the file contents");
        Console.WriteLine("2. Convert to uppercase");
        Console.WriteLine("3. Add a prefix to each line");
        Console.WriteLine("4. Add a suffix to each line");
        Console.WriteLine("5. Display the length of each line");
        Console.WriteLine("6. Get the lines that contain a specific word");
        Console.WriteLine("7. Get the lines that is at most a specific length");
        Console.WriteLine("8. Exit");
    }

    /// <summary>
    /// Reads the file at the specified path and returns an iterable containing the lines in the file.
    /// DO NOT MODIFY THIS METHOD.
    /// </summary>
    /// <param name="path">The path of the file to read.</param>
    /// <returns>An iterable containing the lines in the file.</returns>
    static IIterable LoadData(string path)
    {
        IIterable results = new Iterable();
        using (StreamReader reader = new StreamReader(path))
        {
            while (!reader.EndOfStream)
            {
                results.Add(reader.ReadLine());
            }
        }
        return results;
    }

    /// <summary>
    /// Invokes the appropriate method based on the option selected by the user.
    /// </summary>
    /// <param name="option">The option selected by the user.</param>
    /// <param name="iterable">The iterable containing the lines in the file.</param>
    /// <param name="terminated">A flag indicating whether the program should terminate.</param>
    static void RunOption(MenuOption option, IIterable iterable, out bool terminated)
    {
        Console.WriteLine("---------------------------");
        switch (option)
        {
            // Insert your solution here to implement each of the menu options.
            // You may use the first two options as a reference.
            case MenuOption.DisplayFileContents:
                iterable.ForEach(s => Console.WriteLine(s));
                break;
            case MenuOption.ConvertToUppercase:
                iterable.Map(s => s.ToUpper()).ForEach(Console.WriteLine);
                break;
            case MenuOption.AddPrefix:
                Console.Write("Enter the prefix: ");
                string prefix = Console.ReadLine();
                // Insert your solution here to add a prefix to each line,
                // and then print the result.
                // Hint: You may use the Map method with an appropriate lambda expression, 
                // followed by the ForEach method that takes Console.WriteLine as the argument.
                iterable.Map(s => prefix + s).ForEach(Console.WriteLine);
                break;

            case MenuOption.AddSuffix:
                Console.Write("Enter the suffix: ");
                string suffix = Console.ReadLine();
                // Insert your solution here to add a suffix to each line,
                // and then print the result.
                iterable.Map(s => s + suffix).ForEach(Console.WriteLine);
                break;

            case MenuOption.DisplayLength:
                // Insert your solution here to display the length of each line, in the
                // following format for each line:
                // {line}: {length}
                // Hint: You may use the ForEach method with an appropriate lambda expression.
                iterable.ForEach(s => Console.WriteLine($"{s}: {s.Length}"));
                break;

            case MenuOption.GetLinesThatContainWord:
                Console.Write("Enter the word: ");
                string word = Console.ReadLine();
                // Insert your solution here to get the lines that contain the specified word,
                // and then print the result.
                // Hint: You may use the Filter method with an appropriate lambda expression,
                // with the Contains method of the string class.
                iterable.Filter(s => s.Contains(word)).ForEach(Console.WriteLine);
                break;

            case MenuOption.GetLinesThatIsAtMostLength:
                Console.Write("Enter the length: ");
                int length = int.Parse(Console.ReadLine());
                // Insert your solution here to get the lines that are at most the specified length,
                // and then print the result.
                iterable.Filter(s => s.Length <= length).ForEach(Console.WriteLine);
                break;

            case MenuOption.Exit:
                terminated = true;
                return;
        }
        terminated = false;
        Console.WriteLine("---------------------------");
        return;
    }
}