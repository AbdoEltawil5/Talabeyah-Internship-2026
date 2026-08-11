using EShop.Console.Dtos;
using EShop.Console.Repositories.Implementations;
using EShop.Console.Services.Implementations;

var orderRepository = new OrderRepository();
var productRepository = new ProductRepository();
var orderService = new OrderService(orderRepository);
var productService = new ProductService(productRepository);

Console.WriteLine("======== Products List ========");
var products = productService.GetProducts();
var orderItemsDto = new List<OrderItemDto>();
foreach (var product in products)
{
    Console.WriteLine($"{product.Id} - {product.Name} - {product.Price}");
}

Console.WriteLine("-------------------------------");
Console.WriteLine("======== Adding orders ========");

var isFinished = false;
while (!isFinished)
{
    bool isValidInput = false;
    Guid chosenId;
    int quantity;
    do
    {
        Console.WriteLine("Enter a valid id of the product you would like to add:");
        isValidInput = Guid.TryParse(Console.ReadLine(), out chosenId);
    } while (!isValidInput);
    
    do
    {
        Console.WriteLine("Enter the quantity of the product you want to add:");
        isValidInput = int.TryParse(Console.ReadLine(), out quantity);
    } while (!isValidInput);

    var existProduct = productService.GetProduct(chosenId);
    orderItemsDto.Add(new OrderItemDto(chosenId, existProduct!.Price, 0, quantity));
    Console.WriteLine($"\nProduct '{existProduct.Name}' added to the order.");
            
    Console.WriteLine("Do you want to add another product? (y/n)");
    var answer = Console.ReadLine() ?? string.Empty;
    while (answer.Trim().ToLower() != "n"
           && answer.Trim().ToLower() != "y")
    {
        Console.WriteLine("Invalid input.");
        Console.WriteLine("Do you want to add another product? (y/n)");
        answer = Console.ReadLine() ?? string.Empty;
    }
    if (answer == "n")
    {
        isFinished = true;
        var orderDto = new OrderDto(new Guid("97DF7E3B-E679-47B7-8AF5-D44C55BF9805"), orderItemsDto);
        orderService.AddOrder(orderDto);
        Console.WriteLine("Order added Successfully");
    }
}