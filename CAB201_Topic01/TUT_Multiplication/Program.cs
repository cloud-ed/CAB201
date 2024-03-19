namespace TUT_Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is designed to take two number inputs and give the total multiplied value.");
            Console.WriteLine("Please enter the first number of the multiplication.");
            string userInput1 = Console.ReadLine();
            double firstNum = double.Parse(userInput1);
            Console.WriteLine("Please enter the second number of the multiplication.");
            string userInput2 = Console.ReadLine();
            double secondNum = double.Parse(userInput2);
            double multi = firstNum * secondNum;
            Console.WriteLine($"The total multiplied value of {firstNum} and {secondNum} is {multi}");
        }
    }
}