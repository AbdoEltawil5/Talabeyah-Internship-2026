namespace EShop.Console.Entities;

public struct Money(decimal amount, Currency currency)
{
    private decimal _amount = amount;
    private Currency _currency = currency;
    
    public decimal getAmount()
    {
        return _amount;
    }
    public void setAmount(decimal amount)
    {
        _amount = amount;
    }
    public Currency getCurrency()
    {
        return _currency;
    }
    public void setCurrency(Currency currency)
    {
        if (!Enum.IsDefined(typeof(Currency), currency))
        {
            System.Console.WriteLine("Please Enter a valid Enum.");
        }
        _currency = currency;
    }
}