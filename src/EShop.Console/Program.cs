using EShop.Console.Dtos;
using EShop.Console.Entities;
using EShop.Console.Extensions;
using EShop.Console.Notifications;
using EShop.Console.Services;
using EShop.Console.ValueObjects;

var parentCategory = new Category(Guid.NewGuid(), "Electronics", null);
var phones = new Category(Guid.NewGuid(), "Phones", parentCategory.Id);
parentCategory.AddSubCategory(phones);

var product1 = new Product(Guid.NewGuid(), "Iphone", "Iphone 17 pro max", new Money(50000m), 10, phones);
var product2 = new Product(Guid.NewGuid(), "Samsung", "Samsung S25", new Money(40000m), 8, phones);
var product3 = new Product(Guid.NewGuid(), "Pixel", "Pixel 9", new Money(35000m), 5, phones);
phones.AddProduct(product1);
phones.AddProduct(product2);
phones.AddProduct(product3);

var customer = new Customer(Guid.NewGuid(), "Baselyosry", "baselyosry@gmail.com", "password");
var cart = new Cart(Guid.NewGuid(), customer.Id);
cart.AddItem(product1.Id, 1);
cart.AddItem(product2.Id, 1);
cart.AddItem(product3.Id, 1);

var products = new List<Product> { product1, product2, product3 };

Console.WriteLine($"Cart total: {cart.TotalPrice(products)} \n");

var productService = new ProductService(products);

Console.WriteLine("Calling GetProducts");
var result = productService.GetProducts();
Console.WriteLine("GetProducts returned (iterator should not have run yet)");

Console.WriteLine("Starting foreach");
foreach (var p in result)
{
    Console.WriteLine($"{p.Name}");
}
Console.WriteLine("Foreach done");
Console.WriteLine();

IStockValidator stockValidator = new StockValidator();
IDiscountService discountService = new PercentageDiscount(10);
Notification notification = new EmailNotification();

var orderProcessor = new OrderProcessor(
    stockValidator,
    discountService,
    notification);

var order = orderProcessor.PlaceOrder(cart, products);

Console.WriteLine(product1.Summarize());
Console.WriteLine(product2.Summarize());
Console.WriteLine(product3.Summarize());

Console.WriteLine(cart.Summarize());
Console.WriteLine(order.Summarize());
Console.WriteLine(customer.Summarize());
Console.WriteLine();

var orderService = new OrderService();

var bigOrder = new Order(Guid.NewGuid(), "Pending", new Money(0m), customer.Id);
for (int i = 0; i < 50; i++)
{
    bigOrder.AddItem(product1, 1);
}

Console.WriteLine("receipt with string:");
Console.WriteLine(orderService.GetOrderRecieptWithString(bigOrder));

Console.WriteLine("receipt with stringbuilder:");
Console.WriteLine(orderService.GetOrderRecieptWithStringBuilder(bigOrder));
