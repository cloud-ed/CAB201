using PolymorphicMenu;

class ListDocumentsDialog : Dialog
{
    private const string TITLE = "List documents";
    private const string NO_DOCUMENTS_MESSAGE = "\tNo documents found.";

    public ListDocumentsDialog(Library library) : base(TITLE, library) { }

    public override void Display()
    {
        ConsoleUtils.WriteLine("Documents in library:");
        IDocument[] documents = Library.ToArray();
        if (documents.Length == 0)
        {
            ConsoleUtils.WriteLine(NO_DOCUMENTS_MESSAGE);
        }
        else
        {
            for (int i = 0; i < documents.Length; i++)
            {
                ConsoleUtils.WriteLine("\t{0}", documents[i].ToString());
            }
        }
    }
}