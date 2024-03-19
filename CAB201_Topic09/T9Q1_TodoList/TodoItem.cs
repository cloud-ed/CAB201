namespace TodoList;
/// <summary>
/// A todo item with a title and a status (done / undone).
/// </summary>
class TodoItem
{
    private string title;
    private bool isDone;

    /// <summary>
    /// The title of the todo item.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the title is null or empty.</exception>
    public string Title
    {
        get { return title; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Title cannot be null or empty.");
            }
            title = value;
        }
    }

    /// <summary>
    /// Creates a new todo item with the given title, and is marked undone by default.
    /// </summary>
    /// <param name="title">The title of the todo item.</param>
    public TodoItem(string title)
    {
        Title = title;
        isDone = false;
    }

    /// <summary>
    /// Marks the todo item as done.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown when the todo item is already marked as done.</exception>
    public void MarkDone()
    {
        if (isDone)
        {
            throw new InvalidOperationException("You cannot mark an already completed todo item as done.");
        }
        isDone = true;
    }

    /// <summary>
    /// Marks the todo item as undone.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown when the todo item is already marked as undone.</exception>
    public void MarkUndone()
    {
        if (!isDone)
        {
            throw new InvalidOperationException("You cannot mark an already completed todo item as undone.");
        }
        isDone = false;
    }

    /// <summary>
    /// Returns a string representation of the todo item, in the format:
    /// [x] Title, if the item is done
    /// or
    /// [ ] Title, if the item is undone
    /// </summary>
    public override string ToString()
    {
        string status = isDone ? "[x]" : "[ ]";
        return $"{status} {title}";
    }

    /// <summary>
    /// Parses a string representation of a todo item, in the format:
    /// [x] Title, if the item is done
    /// or
    /// [ ] Title, if the item is undone
    /// </summary>
    public static TodoItem Parse(string line)
    {
        string status = line.Substring(0, 3).Trim();
        string title = line.Substring(4).Trim();
        TodoItem item = new TodoItem(title);
        if (status == "[x]")
        {
            item.MarkDone();
        }
        return item;
    }
}