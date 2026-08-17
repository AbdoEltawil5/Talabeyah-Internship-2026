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

    public static Money operator +(Money left, Money right)
    {
        left.ValidateSameCurrency(right);
        return new Money(left.Amount + right.Amount, left.Currency);
    }

    public static Money operator -(Money left, Money right)
    {
        left.ValidateSameCurrency(right);
        return new Money(left.Amount - right.Amount, left.Currency);
    }

    public static Money operator *(Money money, int quantity)
    {
        if (quantity < 0)
            throw new ArgumentException("Quantity cannot be negative.", nameof(quantity));

        return new Money(money.Amount * quantity, money.Currency);
    }

    public static Money operator *(int quantity, Money money) => money * quantity;

    public static bool operator ==(Money left, Money right)
    {
        left.ValidateSameCurrency(right);
        return left.Amount == right.Amount;
    }

    public static bool operator !=(Money left, Money right)
    {
        left.ValidateSameCurrency(right);
        return left.Amount != right.Amount;
    }

    public static bool operator >(Money left, Money right)
    {
        left.ValidateSameCurrency(right);
        return left.Amount > right.Amount;
    }

    public static bool operator <(Money left, Money right)
    {
        left.ValidateSameCurrency(right);
        return left.Amount < right.Amount;
    }

    public static bool operator >=(Money left, Money right)
    {
        left.ValidateSameCurrency(right);
        return left.Amount >= right.Amount;
    }

    public static bool operator <=(Money left, Money right)
    {
        left.ValidateSameCurrency(right);
        return left.Amount <= right.Amount;
    }
    
    public override string ToString() => $"{Amount} {Currency}";
}