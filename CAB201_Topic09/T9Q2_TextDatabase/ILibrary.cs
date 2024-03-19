namespace TextDatabase;
interface ILibrary
{
    void AddBook(Book book);
    void RemoveBook(string title);
    void ListAllBooks();
    void Save();
}