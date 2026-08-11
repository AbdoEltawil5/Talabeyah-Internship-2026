using EShop.Console;
using EShop.Console.Repositories.Implementations;
using EShop.Console.Services.Implementations;

var orderRepository = new OrderRepository();
var productRepository = new ProductRepository();
var orderService = new OrderService(orderRepository);
var productService = new ProductService(productRepository);

OrderProcessor orderProcessor = new OrderProcessor(orderService, productService);

orderProcessor.AddOrder();