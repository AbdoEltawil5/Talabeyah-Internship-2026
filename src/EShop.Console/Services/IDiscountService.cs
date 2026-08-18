using EShop.Console.Shared;

namespace EShop.Console.Services;

public interface IDiscountService
{
    Money Apply(Money subtotal);
}
