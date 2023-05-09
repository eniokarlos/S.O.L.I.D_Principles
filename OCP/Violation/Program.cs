using System;
namespace OCP.Violation;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();

        var normalClient =
           order.Discount(1000, ClientType.NORMAL);

        var affiliatedClient = 
            order.Discount(1000, ClientType.AFFILIATED);

        var especialClient =
            order.Discount(1000, ClientType.ESPECIAL);

        Console.WriteLine($"Normal Client = " +
            $"{normalClient}");

        Console.WriteLine($"Affiliated Client = " +
            $"{affiliatedClient}");

        Console.WriteLine($"Especial Client = " +
            $" {especialClient}");

        Console.ReadLine();
    }
}
