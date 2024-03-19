using PolymorphicMenu;

class AddBookDialog : Dialog, ITerminator
{
    private const string TITLE = "Book";
    private const string PROMPT_BOOK_TITLE = "Enter book title: ";
    private const string PROMPT_AUTHOR = "Enter book author: ";
    private const string PROMPT_PAGES = "Enter book page count: ";

    // Insert your solution here

    public AddBookDialog(Library library) : base(TITLE, library) { }

    public override void Display()
    {
        ConsoleUtils.Read(out string title, PROMPT_BOOK_TITLE);
        ConsoleUtils.Read(out string author, PROMPT_AUTHOR);
        ConsoleUtils.Read(out int pages, PROMPT_PAGES, 1);
        IDocument book = new Book(title, author, pages);
        Library.AddDocument(book);
        ConsoleUtils.WriteLine($"Book added: {book.ToString()}");
    }
}