namespace Book;
class Program
{
    static void Main(string[] args)
    {
        // Keep this line intact
        Console.WriteLine("===========================");

        // Insert your solution here
        // Define variables and initilize newBook
        string knowDetails = "Do you know the book's details? (Y/N)";
        string bookTitlePrompt = "Enter the book's title:";
        string bookAuthorPrompt = "Enter the book's author:";
        string bookYearPrompt = "Enter the book's publication year:";
        string newYearPrompt = "Enter the book's new publication year:";
        Book newBook = new Book();

        // Check for details or default values
        Console.WriteLine(knowDetails);
        char userInput = char.Parse(Console.ReadLine());
        if (char.ToUpper(userInput) == 'Y' || char.ToUpper(userInput) == 'N')
        {
            if (char.ToUpper(userInput) == 'Y')
            {
                Console.WriteLine(bookTitlePrompt);
                string titleInput = Console.ReadLine();
                Console.WriteLine(bookAuthorPrompt);
                string authorInput = Console.ReadLine();
                Console.WriteLine(bookYearPrompt);
                int yearInput = int.Parse(Console.ReadLine());

                newBook = new Book(titleInput, authorInput, yearInput);
            }
            else if (char.ToUpper(userInput) == 'N')
            {
                newBook = new Book();
            }
            newBook.DisplayInfo();

            // Prompt for new year of publication and display
            Console.WriteLine(newYearPrompt);
            int newYear = int.Parse(Console.ReadLine());
            newBook.SetYearPublished(newYear);
            newBook.DisplayInfo();
        }

        // Keep this line intact
        Console.WriteLine("===========================");
    }
}