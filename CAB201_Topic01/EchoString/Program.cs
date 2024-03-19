namespace EchoString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* EchoString implementation */
            Console.WriteLine("Please enter a line of text:");
            string userInput = Console.ReadLine();
            Console.WriteLine($"You entered '{userInput}'.");
        }
    }
}