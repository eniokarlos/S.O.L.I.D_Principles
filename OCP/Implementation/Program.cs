using System;

namespace OCP.Implementation;

class Program
{
    static void Main(string[] args)
    {
        IOrder affiliatedClient = new AffiliatedClientOrder();
        IOrder especialClient  = new EspecialClientOrder();
        IOrder normalClient = new NormalClientOrder();

        double normalClientOrder =
            normalClient.Discount(1000);

        double affiliatedClientOrder = 
            affiliatedClient.Discount(1000);

        double especialClientOrder = 
            especialClient.Discount(1000);


        Console.WriteLine($"Cliente Comum =" +
            $" {normalClientOrder}");

        Console.WriteLine($"Cliente Associado =" +
            $" {affiliatedClientOrder}");

        Console.WriteLine($"Cliente Especial =" +
            $" {especialClientOrder}");

        Console.ReadLine();
    }
}
