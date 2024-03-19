namespace PolymorphicMenu;
/// <summary>Dialog specialised to offer user choice by a range of options.</summary>
class Menu : Dialog
{
    const string MENU_HEADING = "Please choose from the following list:";
    const string INPUT_PREFIX = "> ";

    /// <summary>Local copy of menu options.</summary>
    private IDisplayable[] options;

    /// <summary>Initialise a new Menu object.</summary>
    /// <param name="title">Title for display.</param>
    /// <param name="library">Reference to library where documents can be added or borrowed.</param>
    /// <param name="options">List of options offered to user.</param>
    public Menu(string title, Library library, params IDisplayable[] options) : base(title, library)
    {
        this.options = new IDisplayable[options.Length];
        Array.Copy(options, this.options, options.Length);
    }

    /// <summary>Get an option from the user and take subsequent action.</summary>
    public override void Display()
    {
        while (true)
        {
            WriteOptions();
            IDisplayable option;
            if (!GetOption(out option))
            {
                ConsoleUtils.WriteLine("Attempt to read past end of input.");
                break;
            }
            option.Display();
            if (option is ITerminator) break;
        }
    }

    /// <summary>Displays the available options.</summary>
    private void WriteOptions()
    {
        ConsoleUtils.WriteLine(Title);
        ConsoleUtils.WriteLine(MENU_HEADING);
        for (int i = 0; i < options.Length; i++)
        {
            ConsoleUtils.WriteLine("{0} -> {1}", i + 1, options[i].Title);
        }
    }

    /// <summary>Reads an option </summary>
    /// <param name="option">The option selected by the user.</param>
    /// <returns>True if the option was successfully read, false otherwise.</returns>
    private bool GetOption(out IDisplayable option)
    {
        int optionIndex;
        bool success = ConsoleUtils.Read(out optionIndex, INPUT_PREFIX, 1, options.Length);
        if (success)
        {
            option = options[optionIndex - 1];
        }
        else
        {
            option = null;
        }
        return success;
    }
}