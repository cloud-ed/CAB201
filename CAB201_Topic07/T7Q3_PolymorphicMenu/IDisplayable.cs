namespace PolymorphicMenu;
/// <summary>All objects displayable in the view will implement this interface.</summary>
public interface IDisplayable
{
    /// <summary> The displayable object's title</summary>
    string Title { get; }

    /// <summary>Display and execute the logic of the displayable object.</summary>
    void Display();
}