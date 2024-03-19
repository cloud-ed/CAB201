using PolymorphicMenu;

class AddDocumentMenu : Menu
{
    private const string TITLE = "Add a document";
    private const string FAREWELL = "Returning to main menu.";
    private const string EXIT = "Exit";

    // Insert your solution here
    public AddDocumentMenu(Library library) : base(TITLE, library,
        new AddBookDialog(library),
        new AddJournalDialog(library),
        new ExitDialog(EXIT, FAREWELL)
    )
    { }
}