namespace PHIndicator;
interface IPHIndicator
{
    // Insert your solution here.
    public void SetPh(double ph);
    public string GetColor();

    public double GetPh();
}

public class Litmus : IPHIndicator
{
    private double ph;

    public Litmus() { }

    public Litmus(double ph)
    {
        this.ph = ph;
    }

    public void SetPh(double ph)
    {
        this.ph = ph;
    }
    public double GetPh()
    {
        return this.ph;
    }

    public string GetColor()
    {
        double ph = this.ph;
        if (ph < 4.5) { return "Red"; }
        if (ph >= 4.5 && ph < 8.3) { return "Purple"; }
        else { return "Blue"; }
    }

}

class Turmeric : IPHIndicator
{
    private double ph;

    public Turmeric() { }

    Turmeric (double ph)
    {
        this.ph = ph;
    }

    public void SetPh(double ph)
    {
        this.ph = ph;
    }

    public double GetPh()
    {
        return this.ph;
    }

    public string GetColor()
    {
        double ph = this.ph;
        if (ph < 11) { return "Vermilion"; }
        else { return "Yellow"; }
    }
}

class UniversalIndicator : IPHIndicator
{
    private double ph;

    public UniversalIndicator() { }

    UniversalIndicator(double ph)
    {
        this.ph = ph;
    }

    public void SetPh(double ph)
    {
        this.ph = ph;
    }
    public double GetPh()
    {
        return this.ph;
    }

    public string GetColor()
    {
        double ph = this.ph;
        if (ph < 2) { return "Red"; }
        if (ph >= 2 && ph < 4) { return "Orange"; }
        if (ph >= 4 && ph < 6) { return "Yellow"; }
        if (ph >= 6 && ph < 8) { return "Green"; }
        if (ph >= 8 && ph < 10) { return "Blue"; }
        if (ph >= 10 && ph < 12) { return "Indigo"; }
        else { return "Violet"; }
    }
}