namespace PolymorphicMenu;
/// <summary>
/// A library, which is a collection of documents.
/// </summary>
class Library
{
    private List<IDocument> documents;
    /// <summary>
    /// Create a new, empty library.
    /// </summary>
    public Library()
    {
        documents = new List<IDocument>();
    }
    /// <summary>
    /// Add a document to the library.
    /// </summary>
    /// <param name="document">The document to add.</param>
    public void AddDocument(IDocument document)
    {
        documents.Add(document);
    }
    /// <summary>
    /// Remove a document from the library.
    /// </summary>
    /// <param name="document">The document to remove.</param>
    public void RemoveDocument(IDocument document)
    {
        documents.Remove(document);
    }
    /// <summary>
    /// Find a document in the library by name.
    /// </summary>
    /// <param name="name">The name of the document to find.</param>
    /// <returns>The document with the given name, or null if no such document exists.</returns>
    public IDocument? FindDocument(string name)
    {
        foreach (IDocument document in documents)
        {
            if (document.Title == name)
            {
                return document;
            }
        }
        return null;
    }
    /// <summary>
    /// Get a copy of all documents in the library as an array.
    /// </summary>
    /// <returns>An array of all documents in the library.</returns>
    public IDocument[] ToArray()
    {
        return documents.ToArray();
    }
}