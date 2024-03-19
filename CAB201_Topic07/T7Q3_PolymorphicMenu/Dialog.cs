namespace PolymorphicMenu;
/// <summary>Base class for most displayable objects.</summary>
abstract class Dialog : IDisplayable
{
    /// <summary>Implement Title property of IDisplayable</summary>
    public string Title { get; }

    /// <summary>Reference to library where documents can be added or borrowed.</summary>
    protected Library Library { get; }

    /// <summary>Initialise the Dialog.</summary>
    /// <param name="title">String containing title text.</param>
    /// <param name="library">Reference to library where documents can be added or borrowed.</param>
    public Dialog(string title, Library library)
    {
        Title = title;
        Library = library;
    }

    /// <summary>Abstract implementation of Display method of IDisplayable.</summary>
    public abstract void Display();
}