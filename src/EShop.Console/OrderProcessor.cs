using EShop.Console.Dtos;
using EShop.Console.Entities;
using EShop.Console.Services.Interfaces;

namespace EShop.Console;

public class OrderProcessor
{
    private readonly IOrderService _orderService;
    private readonly IProductService _productService;

    public OrderProcessor(IOrderService orderService, IProductService productService)
    {
        _orderService = orderService;
        _productService = productService;
    }

    public void AddOrder()
    {
        System.Console.WriteLine("======== Products List ========");
        var products = _productService.GetProducts();
        var orderItemsDto = new List<OrderItemDto>();
        foreach (var product in products)
        {
            System.Console.WriteLine($"{product.Id} - {product.Name} - {product.Price}");
        }

        System.Console.WriteLine("-------------------------------");
        System.Console.WriteLine("======== Adding orders ========");

        bool isFinished = false;
        while (!isFinished)
        {
            bool isValidInput = false;
            Guid chosenId;
            do
            {
                System.Console.WriteLine("Enter a valid id of the product you would like to add:");
                isValidInput = Guid.TryParse(System.Console.ReadLine(), out chosenId);
            } while (!isValidInput);

            var existProduct = _productService.GetProduct(chosenId);
            orderItemsDto.Add(new OrderItemDto(chosenId, existProduct!.Price, 0));
            System.Console.WriteLine($"\nProduct '{existProduct.Name}' added to the order.");
            
            System.Console.WriteLine("Do you want to add another product? (y/n)");
            var answer = System.Console.ReadLine() ?? string.Empty;
            while (answer.Trim().ToLower() != "n"
                   && answer.Trim().ToLower() != "y")
            {
                System.Console.WriteLine("Invalid input.");
                System.Console.WriteLine("Do you want to add another product? (y/n)");
                answer = System.Console.ReadLine() ?? string.Empty;
            }
            if (answer == "n")
            {
                isFinished = true;
                var orderDto = new OrderDto(new Guid("97DF7E3B-E679-47B7-8AF5-D44C55BF9805"), orderItemsDto);
                _orderService.AddOrder(orderDto);
                System.Console.WriteLine("Order added Successfully");
            }
        }
    }
}