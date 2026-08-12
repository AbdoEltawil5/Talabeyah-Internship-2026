namespace EShop.Console.ValueObjects;

public readonly struct Money
{
    public decimal Amount { get; }
    public string Currency { get; }

    public Money(decimal amount, string currency = "EGP")
    {
        if (amount < 0)
            throw new ArgumentException("Amount can't be negative", nameof(amount));
        
        if (string.IsNullOrWhiteSpace(currency))
            throw new ArgumentException("Currency can't be null or empty", nameof(currency));
        
        Amount = amount;
        Currency = currency.Trim().ToUpper();
    }

    private void ValidateSameCurrency(Money other)
    {
        if (Currency != other.Currency)
            throw new ArgumentException($"Currency {Currency} is not equal to {other.Currency}");
    }
    
    public Money Add(Money another)
    {
        ValidateSameCurrency(another);
        return new Money(Amount + another.Amount, Currency);
    }

    public Money Subtract(Money another)
    {
        ValidateSameCurrency(another);
        return new Money(Amount - another.Amount, Currency);
    }

    public Money Multiply(int quantity)
    {
        if (quantity < 0)
            throw new ArgumentException("Quantity cannot be negative.", nameof(quantity));

        return new Money(Amount * quantity, Currency);
    }
    
    public override string ToString() => $"{Amount} {Currency}";
}