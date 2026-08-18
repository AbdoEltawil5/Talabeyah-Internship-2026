using EShop.Console.Entities;

namespace EShop.Console.Shared;

public static class DummyData
{
    private static Guid CatElectronics = Guid.Parse("11111111-1111-1111-1111-111111111111");
    private static Guid CatHomeKitchen = Guid.Parse("22222222-2222-2222-2222-222222222222");
    private static Guid CatFoodBev = Guid.Parse("33333333-3333-3333-3333-333333333333");
    private static Guid CatApparel = Guid.Parse("44444444-4444-4444-4444-444444444444");

    // Subcategories
    private static Guid CatAudio = Guid.Parse("11111111-2222-0000-0000-000000000001");
    private static Guid CatMonitors = Guid.Parse("11111111-2222-0000-0000-000000000002");
    private static Guid CatFurniture = Guid.Parse("22222222-2222-0000-0000-000000000001");
    private static Guid CatCookware = Guid.Parse("22222222-2222-0000-0000-000000000002");
    private static Guid CatGroceries = Guid.Parse("33333333-2222-0000-0000-000000000001");
    private static Guid CatActivewear = Guid.Parse("44444444-2222-0000-0000-000000000001");

    private static List<Category> Categories = new List<Category>
    {
        new Category(CatElectronics, "Electronics", null),
        new Category(CatHomeKitchen, "Home & Kitchen", null),
        new Category(CatFoodBev, "Food & Beverage", null),
        new Category(CatApparel, "Apparel & Fashion", null),
        
        new Category(CatAudio, "Audio & Headphones", CatElectronics),
        new Category(CatMonitors, "Monitors & Computers", CatElectronics),
        new Category(CatFurniture, "Furniture", CatHomeKitchen),
        new Category(CatCookware, "Cookware & Kitchenware", CatHomeKitchen),
        new Category(CatGroceries, "Groceries", CatFoodBev),
        new Category(CatActivewear, "Activewear & Shoes", CatApparel)
    };

    private static readonly Dictionary<Guid, Category> CategoryMap = Categories.ToDictionary(c => c.Id);
    public static List<Product> Products = new()
    {
        new Product(
            Guid.Parse("a0000000-0000-0000-0000-000000000001"),
            "Wireless Noise-Canceling Headphones",
            "High-fidelity over-ear headphones with active noise cancellation.",
            new Money(299.99m, "USD"),
            45,
            CategoryMap[CatAudio]
        ),
        new Product(
            Guid.Parse("a0000000-0000-0000-0000-000000000002"),
            "Ergonomic Mesh Office Chair",
            "Adjustable lumbar support chair with breathable mesh.",
            new Money(189.50m, "USD"),
            12,
            CategoryMap[CatFurniture]
        ),
        new Product(
            Guid.Parse("a0000000-0000-0000-0000-000000000003"),
            "Stainless Steel Water Bottle",
            "Vacuum-insulated 32oz bottle that keeps beverages cold.",
            new Money(24.99m, "USD"),
            120,
            CategoryMap[CatCookware]
        ),
        new Product(
            Guid.Parse("a0000000-0000-0000-0000-000000000004"),
            "Mechanical RGB Keyboard",
            "Tactile mechanical keyboard with customizable lighting.",
            new Money(89.99m, "USD"),
            0,
            CategoryMap[CatElectronics]
        ),
        new Product(
            Guid.Parse("a0000000-0000-0000-0000-000000000005"),
            "Organic Dark Roast Coffee Beans",
            "1lb bag of fair-trade, whole bean coffee.",
            new Money(15.49m, "USD"),
            85,
            CategoryMap[CatGroceries]
        ),
        new Product(
            Guid.Parse("a0000000-0000-0000-0000-000000000006"),
            "Waterproof Running Jacket",
            "Lightweight, windproof, and breathable reflective jacket.",
            new Money(74.00m, "USD"),
            28,
            CategoryMap[CatActivewear]
        ),
        new Product(
            Guid.Parse("a0000000-0000-0000-0000-000000000007"),
            "Ultra-Wide Curved Gaming Monitor",
            "34-inch QHD curved monitor with 144Hz refresh rate.",
            new Money(499.99m, "USD"),
            18,
            CategoryMap[CatMonitors]
        ),
        new Product(
            Guid.Parse("a0000000-0000-0000-0000-000000000008"),
            "Standing Desk Converter",
            "Dual-tier height-adjustable desktop workstation.",
            new Money(149.95m, "USD"),
            30,
            CategoryMap[CatFurniture]
        ),
        new Product(
            Guid.Parse("a0000000-0000-0000-0000-000000000009"),
            "Cast Iron Dutch Oven",
            "6-quart enameled cast iron pot suitable for baking and roasting.",
            new Money(69.99m, "USD"),
            55,
            CategoryMap[CatCookware]
        ),
        new Product(
            Guid.Parse("a0000000-0000-0000-0000-000000000010"),
            "Trail Running Shoes",
            "All-terrain running shoes with reinforced toe cap.",
            new Money(110.00m, "USD"),
            40,
            CategoryMap[CatActivewear]
        ),
        new Product(
            Guid.Parse("a0000000-0000-0000-0000-000000000011"),
            "Smart Fitness Watch",
            "GPS smartwatch featuring heart rate monitoring and sleep tracking.",
            new Money(179.99m, "USD"),
            62,
            CategoryMap[CatElectronics]
        ),
        new Product(
            Guid.Parse("a0000000-0000-0000-0000-000000000012"),
            "Cold Brew Coffee Maker",
            "1-liter durable glass pitcher with fine mesh filter.",
            new Money(29.95m, "USD"),
            90,
            CategoryMap[CatCookware]
        ),
        new Product(
            Guid.Parse("a0000000-0000-0000-0000-000000000013"),
            "Organic Matcha Green Tea Powder",
            "100g tin of ceremonial grade Japanese matcha powder.",
            new Money(22.50m, "USD"),
            110,
            CategoryMap[CatGroceries]
        ),
        new Product(
            Guid.Parse("a0000000-0000-0000-0000-000000000014"),
            "Compact Leather Wallet",
            "RFID-blocking slim bi-fold wallet made from genuine leather.",
            new Money(34.99m, "USD"),
            0,
            CategoryMap[CatApparel]
        ),
        new Product(
            Guid.Parse("a0000000-0000-0000-0000-000000000015"),
            "Noise-Isolating Desk Divider",
            "Acoustic fabric privacy screen designed for office spaces.",
            new Money(58.00m, "USD"),
            15,
            CategoryMap[CatFurniture]
        ),
        new Product(
            Guid.Parse("a0000000-0000-0000-0000-000000000016"),
            "Raw Artisan Honey",
            "Unfiltered, pure wildflower honey sourced from local apiaries.",
            new Money(12.99m, "USD"),
            75,
            CategoryMap[CatGroceries]
        )
    };
}