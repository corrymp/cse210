using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders= new()
        {
            new Order
            (
                new Customer("Steve Enderson", new Address("123 A Street", "Anywhere", "Oregon", "United States of America")),

                new List<Product>
                {
                    new("String", 574108, 9.99f, 1),
                    new("Flint", 41107, 4.99f, 1),
                    new("Stick", 57103, 14.95f, 1)
                }
            ),

            new Order
            (
                new Customer("Alex Jebson", new Address("456 Z Way", "Somewhere", "Stockholm", "Sweden")),

                new List<Product>
                {
                    new("String", 574108, 9.99f, 2),
                    new("Stick", 57103, 14.95f, 3),
                    new("Feather", 4347437, 9.49f, 1)
                }
            )
        };

        foreach (Order order in orders)
        {
            Console.WriteLine($"\n== Order =={order.GetPackingLabel()}\n----\n{order.GetShippingLabel()}\n----\nTotal: {order.GetTotal()}");
        }
    }
}