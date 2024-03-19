namespace TUT_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is designed to take two number inputs and give the total sum value.");
            Console.WriteLine("Please enter the first number of the sum.");
            string userInput1 = Console.ReadLine();
            double firstNum = double.Parse(userInput1);
            Console.WriteLine("Please enter the second number of the sum.");
            string userInput2 = Console.ReadLine();
            double secondNum = double.Parse(userInput2);
            double sum = firstNum + secondNum;
            Console.WriteLine($"The total sum of {firstNum} and {secondNum} is {sum}");

        }
    }
}