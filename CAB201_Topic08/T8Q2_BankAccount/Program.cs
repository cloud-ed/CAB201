namespace BankAccount;
class Program
{
    /// <summary>
    /// Entry point of the program. Do not modify.
    /// </summary>
    static void Main(string[] args)
    {
        Console.WriteLine("===========================");

        BankAccount source = new BankAccount();
        BankAccount destination = new BankAccount();

        Console.WriteLine("Enter amount to deposit into source account: ");
        double amount = double.Parse(Console.ReadLine());
        source.Deposit(amount);

        Console.WriteLine("Enter amount to withdraw from source account: ");
        amount = double.Parse(Console.ReadLine());
        source.Withdraw(amount);

        Console.WriteLine("Enter amount to transfer from source account to destination account: ");
        amount = double.Parse(Console.ReadLine());
        BankAccount.Transfer(source, destination, amount);

        Console.WriteLine("===========================");
    }
}