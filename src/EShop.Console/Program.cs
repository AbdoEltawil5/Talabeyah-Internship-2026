using EShop.Console.DbContext;
using EShop.Console.Entities;
using EShop.Console.Services;

SmsNotification email = new SmsNotification();

AppDbContext appDbContext = new AppDbContext();

OrderService orderService = new OrderService(email, appDbContext);


List<KeyValuePair<Product, int>> productsCountTest = new List<KeyValuePair<Product, int>>();

Product p1 = new Product(1, "vcola", "bla bla bla", 20, 55, 2);
Product p2 = new Product(3, "bigcola", "bla bla bla", 10,22, 2);
Product p3 = new Product(4, "leban", "bla bla bla", 2,11, 3);

productsCountTest.Add(new KeyValuePair<Product, int>(p1, 11));
productsCountTest.Add(new KeyValuePair<Product, int>(p2, 14));
productsCountTest.Add(new KeyValuePair<Product, int>(p3, 11));

orderService.OrderProcessing(productsCountTest, 7);

var customer = new Customer(1,"ahmed","mmm@adsa.com","965132adsd");

var customer2 = new Customer();
customer2.Name = "ibrahim";


var customer3 = new Customer()
{
    Name = "samy"
};