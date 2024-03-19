namespace WordAnalysis;
class Program
{
    static void Main(string[] args)
    {
        // Keep the following line intact 
        Console.WriteLine("===========================");
        int vowels, consonants;
        Console.WriteLine("Enter a word: ");

        // Insert your solution here
        // Call the TryCount method, outputting the counts of vowels and consonants into the vowels and consonants variables
        string userInput = Console.ReadLine();
        
        // If the TryCount method returns true, display "There are {vowels} vowels and {consonants} consonants in the given word."
        if (Word.TryCount(userInput, out vowels, out consonants) == true)
        {
            Console.WriteLine($"There are {vowels} vowels and {consonants} consonants in the given word.");
        }
        // If the TryCount method returns false, display the prompt "Invalid input. The word must not contain any non-alphabetic characters."
        else
        {
            Console.WriteLine("Invalid input. The word must not contain any non-alphabetic characters.");
        }
        // Keep the following line intact
        Console.WriteLine("===========================");
    }
}