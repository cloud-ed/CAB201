using System.Security.Cryptography.X509Certificates;

namespace Calculator;
class Program
{
    private const char
        ADD = '+',
        SUBTRACT = '-',
        MULTIPLY = '*',
        DIVIDE = '/',
        POWER = '^',
        CLEAR = 'C',
        QUIT = 'Q';

    static void Main()
    {
        // Keep this line intact
        Console.WriteLine("===========================");

        // Insert your solution here to
        // 1. Create a new Calculator object
        // 2. In an infinite while loop:
        //  a. Print the current value of the calculator with the message $"Current value: {calculator.Current}"
        //  b. Ask the user $"Enter an operation (+, -, *, /, ^, C to clear or Q to quit): "
        //  c. Using a char.TryParse, get the operation from the user. If failed, print "Invalid operation!" and call continue; to skip the rest of the current iteration.
        //  d. If the operation is QUIT, break out of the loop
        //  e. If the operation is CLEAR, call calculator.Clear() and call continue;
        // In a try-catch block:
        //  f. Using the GetOperation method below, create a delegate of type Operation and assign it to the result of GetOperation(operation, calculator)
        //  g. Ask the user "Enter a value:"
        //  h. Using a double.TryParse, get the value from the user. If failed, print "Invalid value!" and call continue;
        //  i. Call the delegate with the parsed value as the argument
        // If an exception is caught, print the exception message in the catch block
        Calculator calculator = new Calculator();
        while (true)
        {
            Console.WriteLine($"Current value: {calculator.Current}");
            Console.WriteLine($"Enter an operation (+, -, *, /, ^, C to clear or Q to quit): ");
            if (!char.TryParse(Console.ReadLine(), out char op))
            {
                Console.WriteLine("Invalid operation!");
                continue;
            }
            if (op == QUIT)
            {
                break;
            }
            if (op == CLEAR)
            {
                calculator.Clear();
                continue;
            }
            try
            {
                Operation calculate = GetOperation(op, calculator);
                Console.WriteLine("Enter a value:");
                if (!double.TryParse(Console.ReadLine(), out double number))
                {
                    Console.WriteLine("Invalid value!");
                    continue;
                    
                }
                calculate(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Keep this line intact
        Console.WriteLine("===========================");
    }

    // Insert your solution here to declare a delegate type called Operation
    // that takes a double as an argument and returns void
    delegate void Operation(double value);

    static Operation GetOperation(char operation, Calculator calculator)
    {
        switch (operation)
        {
            // Insert your solution here to return
            // calculator.Add if the operation is ADD,
            // calculator.Subtract if the calculation is SUBTRACT,
            // and so on...
            case ADD:
                return calculator.Add;
            case SUBTRACT:
                return calculator.Subtract;
            case MULTIPLY:
                return calculator.Multiply;
            case DIVIDE:
                return calculator.Divide;
            case POWER:
                return calculator.Power;
            default:
                throw new ArgumentException("Invalid operation!");
        }
    }
}