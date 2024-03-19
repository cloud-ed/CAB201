using System.Reflection.Metadata;

namespace TodoList;
/// <summary>
/// The options available to the user.
/// </summary>
enum MenuOption
{
    Default,
    AddItem,
    MarkDone,
    MarkUndone,
    PrintTodoList,
    ReloadTodoList,
    SaveTodoList,
    Exit,
}

/// <summary>
/// The main program. DO NOT MODIFY.
/// </summary>
class Program
{
    /// <summary>
    /// Entry point of the program. DO NOT MODIFY.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("===========================");
        Console.WriteLine("Enter the path to the todo list file:");
        string path = Console.ReadLine();
        ITodoList todoList = new TodoList(path);
        while (true)
        {
            DisplayOptions();
            MenuOption option;
            if (!Enum.TryParse(Console.ReadLine(), out option))
            {
                option = MenuOption.Default;
            }
            if (option == MenuOption.Exit)
            {
                break;
            }
            try
            {
                RunOption(option, todoList);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        Console.WriteLine("===========================");
    }

    /// <summary>
    /// Runs the given option on the given todo list.
    /// </summary>
    /// <param name="option">The option to run.</param>
    /// <param name="todoList">The todo list to run the option on.</param>
    static void RunOption(MenuOption option, ITodoList todoList)
    {
        switch (option)
        {
            case MenuOption.AddItem:
                AddItemOption(todoList);
                break;
            case MenuOption.MarkDone:
                MarkDoneOption(todoList);
                break;
            case MenuOption.MarkUndone:
                MarkUndoneOption(todoList);
                break;
            case MenuOption.PrintTodoList:
                todoList.Print();
                break;
            case MenuOption.ReloadTodoList:
                todoList.Load();
                break;
            case MenuOption.SaveTodoList:
                todoList.Save();
                break;
            case MenuOption.Exit:
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

    /// <summary>
    /// Displays the options to the user.
    /// </summary>
    static void DisplayOptions()
    {
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Add item");
        Console.WriteLine("2. Mark item as done");
        Console.WriteLine("3. Mark item as undone");
        Console.WriteLine("4. Print todo list");
        Console.WriteLine("5. Reload todo list");
        Console.WriteLine("6. Save todo list");
        Console.WriteLine("7. Exit");
    }

    /// <summary>
    /// Adds a new item to the todo list using console input.
    /// </summary>
    /// <param name="todoList">The todo list to add the item to.</param>
    static void AddItemOption(ITodoList todoList)
    {
        Console.WriteLine("Enter the title of the todo item:");
        string title = Console.ReadLine();
        todoList.AddItem(title);
    }

    /// <summary>
    /// Marks an item as done using console input.
    /// </summary>
    /// <param name="todoList">The todo list to mark the item as done on.</param>
    static void MarkDoneOption(ITodoList todoList)
    {
        todoList.Print();
        Console.WriteLine("Enter the index of the todo item:");
        int index = int.Parse(Console.ReadLine());
        todoList.MarkDone(index);
    }

    /// <summary>
    /// Marks an item as undone using console input.
    /// </summary>
    /// <param name="todoList">The todo list to mark the item as undone on.</param>
    static void MarkUndoneOption(ITodoList todoList)
    {
        todoList.Print();
        Console.WriteLine("Enter the index of the todo item:");
        int index = int.Parse(Console.ReadLine());
        todoList.MarkUndone(index);
    }
}