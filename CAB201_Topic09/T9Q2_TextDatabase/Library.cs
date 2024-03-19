namespace TextDatabase;
class Library : ILibrary
{
    private List<Book> books;
    private string path;

    public Library(string path)
    {
        // Insert your solution here to:
        // 1. Store the path in the path field.
        // 2. Create a new list of books.
        // 3. Try to load the database from the file. If a FileNotFoundException
        //    is thrown, print the message:
        //    $"No database found at {path}, creating a new library."
        this.path = path;
        books = new List<Book>();
        try
        {
            Load();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"No database found at {path}, creating a new library.");
        }
    }

    public void AddBook(Book book)
    {
        // Insert your solution here to:
        // 1. Check if the book already exists in the database. If it does, throw
        //    an ArgumentException with the message:    
        //    $"Book with title {book.Title} already exists."
        // 2. Add the book to the list of books if it does not already exist.
        foreach (Book b in books)
        {
            if (b.Title == book.Title)
            {
                throw new ArgumentException($"Book with title {book.Title} already exists.");
            }
        }
        books.Add(book);
    }

    public void ListAllBooks()
    {
        // Insert your solution here to display all the books in the database.
        // You may take advantage of the fact that Book.ToString() has been
        // implemented for you.
        foreach (Book book in books)
        {
            Console.WriteLine(book.ToString());
        }
    }

    public void RemoveBook(string title)
    {
        // Insert your solution here to:
        // 1. Find the book with the given title in the list of books.
        // 2. Remove the book from the list of books if it exists and return.
        // 3. If the book does not exist, throw an ArgumentException with the
        //    message: $"Book with title {title} not found."
        foreach (Book book in books)
        {
            if (book.Title == title)
            {
                books.Remove(book);
                return;
            }
        }
        throw new ArgumentException($"Book with title {title} not found.");
    }

    public void Save()
    {
        // Insert your solution here to save the database to the file.
        // You will want to also write the Book.Header to the file
        // before writing each book.
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine(Book.Header);
            foreach (Book book in books)
            {
                sw.WriteLine(book);
            }
        }
    }

    private void Load()
    {
        // Insert your solution here to load the database from the file.
        // You will want to skip the first line of the file, which contains
        // the header.
        books.Clear();
        using (StreamReader sr = new StreamReader(path))
        {
            sr.ReadLine();
            while (sr.EndOfStream == false)
            {
                string line = sr.ReadLine();
                books.Add(Book.Parse(line));
            }
        }
    }
}