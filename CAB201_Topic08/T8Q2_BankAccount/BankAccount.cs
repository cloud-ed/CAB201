namespace BankAccount;
class BankAccount
{
    public double Funds { get; private set; }

    /// <summary>
    /// Deposits an amount into this bank account.
    /// </summary>
    /// <param name="amount">The amount to be deposited.</param>
    /// <exception cref="ArgumentException">Thrown when the amount is negative.</exception>
    public void Deposit(double amount)
    {
        Console.WriteLine("Attempting deposit... ");

        // Insert your solution here to throw an ArgumentException, with the message
        // "Deposit failed. Cannot deposit a negative amount: {amount:C2}"
        if (amount <= 0)
        {
            throw new ArgumentException($"Deposit failed. Cannot deposit a negative amount: {amount:C2}");
        }
        Funds += amount;
    }

    /// <summary>
    /// Withdraws an amount from this bank account.
    /// </summary>
    /// <param name="amount">The amount to be withdrawn.</param>
    /// <exception cref="InsufficientFundsException">Thrown when there are insufficient funds for the withdraw.</exception>
    public void Withdraw(double amount)
    {
        Console.WriteLine("Attempting withdraw... ");

        // Insert your solution here to throw a InsufficientFundsException, with the message
        // "Withdraw failed. This account has {Funds:C2} in funds but {amount:C2} were requested."
        if (Funds < amount)
        {
            throw new InsufficientFundsException($"Withdraw failed. This account has {Funds:C2} in funds but {amount:C2} were requested.");
        }

        Funds -= amount;
        Console.WriteLine("Withdrew {0:C2} funds.", amount);
    }


    /// <summary>
    /// Transfers an amount from one bank account to another.
    /// </summary>
    /// <param name="source">The bank account the funds are transferred from.</param>
    /// <param name="destination">The bank account the funds are transferred to.</param>
    /// <param name="amount">The amount to be transferred.</param>
    /// <exception cref="TransferException">Thrown when the withdraw fails.</exception>
    public static void Transfer(BankAccount source, BankAccount destination, double amount)
    {
        // Insert your solution here to wrap the following code in a try-catch block to 
        // catch the InsufficientFundsException thrown by the Withdraw method. 

        // If a FundsException is caught, throw a new TransferException with the message
        // "Transfer failed due to underlying exception: {exception.Message}"
        // where {exception.Message} is the message of the FundsException that was caught.

        // Regardless of whether an exception is caught or not (finally), print the following message:
        // "Cleanup transfer"
        try
        {
            Console.WriteLine("Attempting transfer... ");
            source.Withdraw(amount);
            destination.Deposit(amount);
            Console.WriteLine("Transferred {0:C2} funds from source to destination. Source account has {1:C2} funds. Destination account has {2:C2} funds.", amount, source.Funds, destination.Funds);
        } catch (InsufficientFundsException exception)
        {
            throw new TransferException($"Transfer failed due to underlying exception: {exception.Message}");
        }
        finally
        {
            Console.WriteLine("Clean up transfer");
        }
    }
}

class InsufficientFundsException : Exception
{
    public InsufficientFundsException() : base() { }
    public InsufficientFundsException(string message) : base(message) { }
    public InsufficientFundsException(string message, Exception? innerException) : base(message, innerException) { }
}
class TransferException : Exception
{
    public TransferException() : base() { }
    public TransferException(string message) : base(message) { }
    public TransferException(string message, Exception? innerException) : base(message, innerException) { }
}