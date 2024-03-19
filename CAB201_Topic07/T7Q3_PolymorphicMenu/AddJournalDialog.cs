using PolymorphicMenu;

class AddJournalDialog : Dialog, ITerminator
{
    private const string TITLE = "Journal";
    private const string PROMPT_NAME = "Enter journal name: ";
    private const string PROMPT_ISSUE = "Enter journal issue: ";

    // Insert your solution here

    public AddJournalDialog(Library library) : base(TITLE, library) { }

    public override void Display()
    {
        ConsoleUtils.Read(out string journalName, PROMPT_NAME);
        ConsoleUtils.Read(out int journalIssue, PROMPT_ISSUE, 1);
        IDocument journal = new Journal(journalName, journalIssue);
        Library.AddDocument(journal);
        Console.WriteLine($"Journal added: {journal.ToString()}");
    }
}