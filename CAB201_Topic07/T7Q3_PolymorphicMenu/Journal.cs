namespace PolymorphicMenu;
/// <summary>
/// A journal, which is a document, with a title and issue number.
/// </summary>
class Journal : IDocument
{
    /// <summary>
    /// The journal's title.
    /// </summary>
    public string Title { get; }
    /// <summary>
    /// The journal's issue number.
    /// </summary>
    public int Issue { get; }
    /// <summary>
    /// Create a new journal with the given title and issue number.
    /// </summary>
    public Journal(string name, int issue)
    {
        Title = name;
        Issue = issue;
    }
    public override string ToString()
    {
        return $"{Title}, issue {Issue}";
    }
}