namespace PolymorphicMenu;
/// <summary>Encapsulate direct interaction with user via the console.</summary>
static class ConsoleUtils
{
    const string BLANK_INPUT_ERROR_MESSAGE = "Please supply the requested value.";
    const string INVALID_INTEGER_ERROR_MESSAGE = "Please supply a whole number.";
    const string INTEGER_OUT_OF_BOUND_ERROR_MESSAGE = "Please supply a whole number between {0} and {1}";

    /// <summary>Gets a line  of text from user.</summary>
    /// <param name="result">Reference to string where result is saved.</param>
    /// <param name="prompt">Text used to request input.</param>
    /// <param name="errorMessage">Text used if empty line entered.</param>
    /// <param name="allowBlank">Should we accept an empty line?</param>
    /// <returns>False if and only if we attempted to read past the end of 
    /// input.</returns>
    public static bool Read(
        out string result,
        string prompt,
        string errorMessage = BLANK_INPUT_ERROR_MESSAGE,
        bool allowBlank = false
    )
    {
        bool isValid;
        while (true)
        {
            Write(prompt);
            result = Console.ReadLine();
            isValid = result != null;

            if (!isValid) break;
            if (allowBlank) break;
            if (!string.IsNullOrWhiteSpace(result)) break;

            WriteLine(errorMessage);
        }
        return isValid;
    }

    /// <summary>Fetch a validated integer value from user.</summary>
    /// <param name="result">Reference to a variable in which the result 
    /// will be saved.</param>
    /// <param name="prompt">Text used to request input.</param>
    /// <param name="errorMessage">Text used if invalid data entered.</param>
    /// <returns>Returns false if and only if we attempted to read past the 
    /// end of input.</returns>
    public static bool Read(
        out int result,
        string prompt,
        string errorMessage = INVALID_INTEGER_ERROR_MESSAGE
    )
    {
        bool isValid;
        result = int.MinValue;

        while (true)
        {
            string userInput;
            isValid = Read(out userInput, prompt, errorMessage, false);

            if (!isValid) break;
            if (int.TryParse(userInput, out result)) break;

            WriteLine(errorMessage);
        }

        return isValid;
    }

    /// <summary>Fetch a validated integer value from user, with bounds 
    /// checking.</summary>
    /// <param name="result">Reference to a variable in which the result 
    /// will be saved.</param>
    /// <param name="prompt">Text used to request input.</param>
    /// <param name="lowerBound">The lower bound of the desired value.</param>
    /// <param name="upperBound">The upper bound of the desired value.</param>
    /// <param name="errorFormat">Template used if invalid data entered.</param>
    /// <returns>Returns false if and only if we attempted to read past the 
    /// end of input.</returns>
    public static bool Read(
        out int result,
        string prompt,
        int lowerBound,
        int upperBound = int.MaxValue,
        string errorFormat = INTEGER_OUT_OF_BOUND_ERROR_MESSAGE
    )
    {
        string errorMessage = string.Format(errorFormat, lowerBound, upperBound);
        bool isValid;
        while (true)
        {
            isValid = Read(out result, prompt, errorMessage);
            if (!isValid) break;
            if (result >= lowerBound && result <= upperBound) break;
            WriteLine(errorMessage);
        }
        return isValid;
    }

    /// <summary>Displays a line of text.</summary>
    /// <param name="format">Format string.</param>
    /// <param name="args">Arguments to format.</param>
    public static void WriteLine(string format, params object[] args)
    {
        Console.WriteLine(format, args);
    }

    /// <summary>Inserts a linefeed into output stream.</summary>
    public static void WriteLine()
    {
        Console.WriteLine();
    }

    /// <summary>Displays text.</summary>
    /// <param name="format"></param>
    /// <param name="args">Text content to display</param>
    public static void Write(string format, params object[] args)
    {
        Console.Write(format, args);
    }
}