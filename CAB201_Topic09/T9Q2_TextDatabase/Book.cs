using System.Reflection;

namespace TextDatabase;
class Book
{
    private string title;
    private string author;
    private int yearPublished;
    public void SetYearPublished(int newYear)
    {
        if (newYear < 0)
        {
            yearPublished = 0;
        }
        else if (newYear > DateTime.Now.Year)
        {
            yearPublished = DateTime.Now.Year;
        }
        else
        {
            yearPublished = newYear;
        }
    }

    public Book()
    {
        title = "Unknown";
        author = "Unknown";
        yearPublished = 0;
    }

    public Book(string bookTitle, string bookAuthor, int publishedYear)
    {
        title = bookTitle;
        author = bookAuthor;
        SetYearPublished(publishedYear);
    }

    // ======================== Insert your solution below ========================

    public override string ToString()
    {
        // Insert your solution here to return a string representation of the book
        // in the format:
        // $"|{title}|{author}|{yearPublished}|"
        return $"|{title}|{author}|{yearPublished}|";
    }

    public string Title
    {
        // Insert your solution here to return the title of the book.
        get { return title ; }
    }

    public static string Header
    {
        // Insert your solution here to return the string:
        // "|Title|Author|Year Published|"
        get { return $"|Title|Author|Year Published|";}
    }

    public static Book Parse(string line)
    {
        // Insert your solution here to parse the given line into a book.
        // You may assume that the line is in the format:
        // |title|author|yearPublished|
        // You may also assume that the yearPublished is a valid integer.
        // If the line is not in the correct format, throw an ArgumentException
        // with the message: 
        // $"Invalid line: {line}"
        // The splitting has been done for you below, with empty entries removed.
        // so parts[0] should be the title, parts[1] should be the author, and
        // parts[2] should be the yearPublished.
        string[] parts = line.Split('|', StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length != 3)
        {
            throw new ArgumentException($"Invalid line: {line}");
        }
        string title = parts[0];
        string author = parts[1];
        int yearPublished = int.Parse(parts[2]);
        return new Book(title, author, yearPublished);
    }
}