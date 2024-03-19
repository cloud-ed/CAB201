namespace PolymorphicMenu;
/// <summary>Main menu for library document management system.</summary>
class MainMenu : Menu
{
    private const string TITLE = "Welcome to THE library!";
    private const string FAREWELL = "Thank you for using THE library!";
    private const string EXIT = "Exit";

    /// <summary>Initialise new MainMenu object.</summary>
    /// <param name="library">Reference to library where documents can be added or borrowed.</param>
    public MainMenu(Library library) : base(TITLE, library,
        new ListDocumentsDialog(library),
        new AddDocumentMenu(library),
        new BorrowDocumentDialog(library),
        new ExitDialog(EXIT, FAREWELL)
    )
    { }
}