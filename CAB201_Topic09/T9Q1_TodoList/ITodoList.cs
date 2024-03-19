namespace TodoList;
/// <summary>
/// An interface for a todo list with basic operations for adding, marking items
/// as done / undone, printing the list, and saving / loading the list from a file.
/// </summary>
interface ITodoList
{
    /// <summary>
    /// Adds a new item to the list.
    /// </summary>
    /// <param name="title">The title of the item to add.</param>
    void AddItem(string title);

    /// <summary>
    /// Marks the item at the given index as done.
    /// </summary>
    /// <param name="index">The index of the item to mark as done.</param>
    /// <exception cref="IndexOutOfRangeException">Thrown when the index is out of range.</exception>
    void MarkDone(int index);

    /// <summary>
    /// Marks the item at the given index as undone.
    /// </summary>
    /// <param name="index">The index of the item to mark as undone.</param>
    /// <exception cref="IndexOutOfRangeException">Thrown when the index is out of range.</exception>
    void MarkUndone(int index);

    /// <summary>
    /// Prints the list to the console.
    /// </summary>
    void Print();

    /// <summary>
    /// Saves the list to the file.
    /// </summary>
    void Save();

    /// <summary>
    /// Loads the list from the file.
    /// </summary>
    void Load();
}