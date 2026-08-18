using EShop.Console.Shared;

namespace EShop.Console.Services;

public class PercentageDiscount : IDiscountService
{
    private readonly decimal _percent;

    public PercentageDiscount(decimal percent)
    {
        if (percent < 0 || percent > 100)
            throw new ArgumentException("Percent must be between 0 and 100.");

        _percent = percent;
    }

    public Money Apply(Money subtotal)
    {
        var discountAmount = subtotal * (_percent / 100m);
        return subtotal - discountAmount;
    }
}
