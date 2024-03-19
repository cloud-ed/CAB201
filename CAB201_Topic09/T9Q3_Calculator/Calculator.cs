namespace Calculator;
class Calculator
{
    public double Current { get; private set; }

    public Calculator()
    {
        Current = 0;
    }

    public void Clear()
    {
        Current = 0;
    }

    public void Add(double value)
    {
        Current += value;
    }

    public void Subtract(double value)
    {
        Current -= value;
    }

    public void Multiply(double value)
    {
        Current *= value;
    }

    public void Divide(double value)
    {
        Current /= value;
    }

    public void Power(double value)
    {
        Current = Math.Pow(Current, value);
    }
}