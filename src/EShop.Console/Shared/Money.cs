namespace EShop.Console.Shared;

public struct Money : IEquatable<Money>
{
    public decimal Amount { get; set; }
    public string Currency { get; set; }

    public Money(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }
    public Money(decimal amount)
    {
        Amount = amount;
        Currency = string.Empty;
    }

    public static Money operator *(Money m1, Money m2)
    {
        CheckCurrencyEquality(m1, m2);
        return new Money(m1.Amount * m2.Amount, m1.Currency);
    }

    public static Money operator *(Money m, int value)
    {
        m.Amount *= value;
        return m;
    }

    public static Money operator *(int value, Money m)
    {
        m.Amount *= value;
        return m;
    }

    public static Money operator *(Money m, decimal value)
    {
        m.Amount *= value;
        return m;
    }
    public static Money operator *(decimal value, Money m)
    {
        m.Amount *= value;
        return m;
    }

    public static Money operator +(Money m1, Money m2)
    {
        CheckCurrencyEquality(m1, m2);
        return new Money(m1.Amount + m2.Amount, m1.Currency);
    }
    public static Money operator -(Money m1, Money m2)
    {
        CheckCurrencyEquality(m1, m2);
        return new Money(m1.Amount - m2.Amount, m1.Currency);
    }

    public static bool operator <(Money m1, Money m2)
    {
        CheckCurrencyEquality(m1, m2);
        return m1.Amount < m2.Amount;
    }

    public static bool operator >(Money m1, Money m2)
    {
        CheckCurrencyEquality(m1, m2);
        return m1.Amount > m2.Amount;
    }
    
    public static bool operator <(Money m, int value)
    {
        return m.Amount < value;
    }
    public static bool operator >(Money m, int value)
    {
        return m.Amount > value;
    }
    
    public static bool operator ==(Money m1, Money m2)
    {
        return m1.Amount == m2.Amount && m1.Currency == m2.Currency;
    }

    public static bool operator !=(Money m1, Money m2)
    {
        return m1.Amount != m2.Amount || m1.Currency != m2.Currency;
    }
    
    public static bool operator ==(Money m1, decimal value)
    {
        return m1.Amount == value;
    }

    public static bool operator !=(Money m1, decimal value)
    {
        return m1.Amount != value;
    }
    
    public static bool operator >=(Money m, decimal value)
    {
        return m.Amount >= value;
    }
    public static bool operator <=(Money m, decimal value)
    {
        return m.Amount <= value;
    }
    
    public bool Equals(Money other)
    {
        return Amount == other.Amount && Currency == other.Currency;
    }

    public override bool Equals(object? obj)
    {
        return obj is Money other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Amount, Currency);
    }
    
    private static void CheckCurrencyEquality(Money m1, Money m2)
    {
        if (m1.Currency != m2.Currency || !(m1.Currency is null && m2.Currency is null))
        {
            throw new InvalidOperationException("Currency should be the same to do this operation");
        }
    }
}