using PolymorphicMenu;

class BorrowDocumentDialog : Dialog
{
    private const string TITLE = "Borrow a document";
    private const string SELECT_DOCUMENT_PROMPT = "Select a document to borrow:";
    private const string NO_DOCUMENTS_MESSAGE = "No documents found.";

    // Insert your solution here
    public BorrowDocumentDialog(Library library) : base(TITLE, library) { }

    public override void Display()
    {
        ConsoleUtils.WriteLine(SELECT_DOCUMENT_PROMPT);
        IDocument[] documents = Library.ToArray();
        for (int i = 0; i < documents.Length; i++)
        {
            ConsoleUtils.WriteLine("{0} -> {1}", i + 1, documents[i].ToString());
        }
        int documentIdx;
        ConsoleUtils.Read(out documentIdx, "> ", 1, documents.Length);
        IDocument? document = Library.FindDocument(documents[documentIdx - 1].Title);
        if (document == null)
        {
            ConsoleUtils.WriteLine(NO_DOCUMENTS_MESSAGE);
        }
        else
        {
            ConsoleUtils.WriteLine("You have borrowed {0}.", document.ToString());
            Library.RemoveDocument(document);
        }
    }
}