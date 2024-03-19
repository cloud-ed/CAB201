namespace TodoList;
class TodoList : ITodoList
{
    private List<TodoItem> todoItems;
    private string path;
    public TodoList(string path)
    {
        // Insert your solution here to:
        // 1. Initialize the todoItems field to a new list of TodoItem objects.
        // 2. Set the path field to the given path.
        // 3. Try to call the Load method. If it throws a FileNotFoundException,
        //    catch it and print the message, and also display an extra message
        //    on a different file: "Creating new todo list."

        todoItems = new List<TodoItem>();
        this.path = path;
        try
        {
            Load();
        }
        catch (FileNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
            Console.WriteLine("Creating new empty todo list...");
        }
    }
    public void AddItem(string title)
    {
        // Insert your solution here to add a new item with the given title.
        todoItems.Add(new TodoItem(title));
    }
    public void MarkDone(int index)
    {
        // Insert your solution here to mark the item at the given index as done.
        // If the index is out of range, throw an IndexOutOfRangeException, with the message:
        // $"Cannot mark non-existent item at index {index} as done."
        if (index < 0 || index >= todoItems.Count)
        {
            throw new IndexOutOfRangeException($"Cannot mark non-existent item at index {index} as done.");
        }
        todoItems[index].MarkDone();
    }
    public void MarkUndone(int index)
    {
        // Insert your solution here to mark the item at the given index as undone.
        // If the index is out of range, throw an IndexOutOfRangeException, with the message:
        // $"Cannot mark non-existent item at index {index} as undone."
        if (index < 0 || index >= todoItems.Count)
        {
            throw new IndexOutOfRangeException($"Cannot mark non-existent item at index {index} as undone.");
        }
        todoItems[index].MarkUndone();
    }
    public void Print()
    {
        // Insert your solution here to print the list to the console, with each item on its own line,
        // and using the format:
        // $"{index}. {todoItems[index]}"
        for (int i = 0; i < todoItems.Count; i++)
        {
            Console.WriteLine($"{i}. {todoItems[i]}");
        }
    }
    public void Load()
    {
        // Insert your solution here to clear the current list, and 
        // load a list from the file at the given path.
        // If the file does not exist, throw a FileNotFoundException, with the message:
        // $"Cannot load list from non-existent file: {path}"
        // Hint:
        // - Use the todoItems.Clear() method to clear the current list.
        // - Use a StreamReader to read from the file.
        // - The TodoItem class has a static Parse method that can parse a line from the file
        if (!File.Exists(path))
        {
            throw new FileNotFoundException($"Cannot load list from non-existent file: {path}");
        }
        todoItems.Clear();
        using (StreamReader reader = new StreamReader(path))
        {
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                todoItems.Add(TodoItem.Parse(line));
            }
        }
    }
    public void Save()
    {
        // Insert your solution here to save the list to the file at the given path.
        // You should overwrite the file if it already exists.
        // Hint:
        // - Use a StreamWriter to write to the file.
        // - The TodoItem class has a ToString method that has
        //   the desired format for each item.
        using (StreamWriter writer = new StreamWriter(path))
        {
            foreach (TodoItem item in todoItems)
            {
                writer.WriteLine(item);
            }
        }
    }
}