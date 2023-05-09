namespace OCP.Implementation;

public class AffiliatedClientOrder : IOrder
{
    public double Discount(double value)
    {
        return value - 10;
    }
}