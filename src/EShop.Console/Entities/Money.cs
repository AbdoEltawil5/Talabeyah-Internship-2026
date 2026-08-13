namespace EShop.Console.Entities;

public struct Money(decimal amount, Currency currency)
{
    private decimal _amount = amount;
    private Currency _currency = currency;
    
    public decimal getAmount()
    {
        return _amount;
    }
    public Money setAmount(decimal amount)
    {
        return new Money(amount, this._currency);
    }
    public Currency getCurrency()
    {
        return _currency;
    }
    public Money setCurrency(Currency currency)
    {
        if (!Enum.IsDefined(typeof(Currency), currency))
        {
            System.Console.WriteLine("Please Enter a valid Enum.");
        }
        return new Money(this._amount, currency);
    }
}