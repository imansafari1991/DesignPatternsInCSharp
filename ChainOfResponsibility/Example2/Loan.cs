namespace Example2;

/// <summary>
/// Class for holding loan request details
/// </summary>

public class Loan
{
    // Constructor
    public Loan(int number, double amount, string purpose)
    {
        this.Number = number;
        this.Amount = amount;
        this.Purpose = purpose;
    }

    // Gets or sets loan number
    public int Number { get;private set; }

    // Gets or sets loan amount
    public double Amount { get; private set; }

    // Gets or sets loan purpose
    public string Purpose { get; private set; }
}