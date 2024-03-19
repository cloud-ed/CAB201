namespace PolymorphicMenu;
/// <summary>
/// A book, which is a document, with a title, author, and number of pages.
/// </summary>
class Book : IDocument
{
    /// <summary>
    /// The book's title.
    /// </summary>
    public string Title { get; }
    /// <summary>
    /// The book's author.
    /// </summary>
    public string Author { get; }
    /// <summary>
    /// The number of pages in the book.
    /// </summary> 
    public int Pages { get; }
    /// <summary>
    /// Create a new book with the given title, author, and number of pages.
    /// </summary>
    public Book(string name, string author, int pages)
    {
        Title = name;
        Author = author;
        Pages = pages;
    }
    public override string ToString()
    {
        return $"{Title} by {Author}, {Pages} pages";
    }
}