public class Fraction
{
    private int numerator;
    private int denominator;

    // Constructors
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    public Fraction(int top)
    {
        numerator = top;
        denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        numerator = top;
        denominator = bottom;
    }

    // Getters and Setters
    public int GetNumerator()
    {
        return numerator;
    }

    public void SetNumerator(int value)
    {
        numerator = value;
    }

    public int GetDenominator()
    {
        return denominator;
    }

    public void SetDenominator(int value)
    {
        if (value != 0)
        {
            denominator = value;
        }
        else
        {
            Console.WriteLine("Denominator cannot be zero.");
        }
    }

    // Methods
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}
