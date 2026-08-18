using EShop.Console.ValueObjects;

namespace EShop.Console.Services;

public interface IDiscountService
{
    Money Apply(Money subtotal);
}
