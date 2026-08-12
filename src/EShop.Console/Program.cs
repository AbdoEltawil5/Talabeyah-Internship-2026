using EShop.Console.Entities;
using EShop.Console.Notifications;
using EShop.Console.Services;
using EShop.Console.Shared;

// var parentCategory = new Category(Guid.NewGuid(), "Electronics", null);
// var phones = new Category(Guid.NewGuid(), "Phones", parentCategory.Id);
// parentCategory.AddSubCategory(phones);
//
// var product = new Product(Guid.NewGuid(), "Iphone", "Iphone 17 pro max", new Money(50000m), 10, phones);
// phones.AddProduct(product);
//
// var customer = new Customer(Guid.NewGuid(), "Baselyosry", "baselyosry@gmail.com", "password");
// var cart = new Cart(Guid.NewGuid(), customer.Id);
// cart.AddItem(product.Id, 1);
//
// var products = new List<Product>(){product};
//
// IStockValidator stockValidator = new StockValidator();
// IDiscountService discountService = new PercentageDiscount(10);
// Notification notification = new EmailNotification();
//
// var orderProcessor = new OrderProcessor(
//     stockValidator,
//     discountService,
//     notification);
//
// var order = orderProcessor.PlaceOrder(cart, products);
//
// Console.WriteLine(product.Summarize());
// Console.WriteLine(cart.Summarize());
// Console.WriteLine(order.Summarize());
// Console.WriteLine(customer.Summarize());
// var parentCategory = new Category(Guid.NewGuid(), "Electronics", null);
// var phones = new Category(Guid.NewGuid(), "Phones", parentCategory.Id);
// parentCategory.AddSubCategory(phones);
//
// var product = new Product(Guid.NewGuid(), "Iphone", "Iphone 17 pro max", new Money(50000m), 10, phones);
// phones.AddProduct(product);
//
// var customer = new Customer(Guid.NewGuid(), "Baselyosry", "baselyosry@gmail.com", "password");
// var cart = new Cart(Guid.NewGuid(), customer.Id);
// cart.AddItem(product.Id, 1);
//
// var products = new List<Product>(){product};
//
// IStockValidator stockValidator = new StockValidator();
// IDiscountService discountService = new PercentageDiscount(10);
// Notification notification = new EmailNotification();
//
// var orderProcessor = new OrderProcessor(
//     stockValidator,
//     discountService,
//     notification);
//
// var order = orderProcessor.PlaceOrder(cart, products);
//
// Console.WriteLine(product.Summarize());
// Console.WriteLine(cart.Summarize());
// Console.WriteLine(order.Summarize());
// Console.WriteLine(customer.Summarize());

//=============================================
//---------------- Task 2 ---------------------
//=============================================

IProductService productService = new ProductService();
var products = productService.GetProducts();

Console.WriteLine("This message appears before iteration start.\n");

foreach (var product in products)
{
    Console.WriteLine(product);
}
