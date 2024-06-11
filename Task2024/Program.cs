

using Task2024;

public class Program
{
    static void Main(string[] args)
    {
        var store = new Store
        {
            Products = new List<Product>
            {
                new() { Id = 1, Name = "Product 1", Price = 1000d },
                new() { Id = 2, Name = "Product 2", Price = 3000d },
                new() { Id = 3, Name = "Product 3", Price = 10000d }
            },
            Orders = new List<Order>
            {
                new()
                {
                    UserId = 1,
                    OrderDate = DateTime.UtcNow,
                    Items = new List<Order.OrderItem>
                    {
                        new() { ProductId = 1, Quantity = 2 }
                    }
                },
                new()
                {
                    UserId = 1,
                    OrderDate = DateTime.UtcNow,
                    Items = new List<Order.OrderItem>
                    {
                        new() { ProductId = 1, Quantity = 1 },
                        new() { ProductId = 2, Quantity = 1 },
                        new() { ProductId = 3, Quantity = 1 }
                    }
                }
            }
        };

        Console.WriteLine(store.GetProductStatistics(2022));
        Console.WriteLine(store.GetYearsStatistics());

    }
}