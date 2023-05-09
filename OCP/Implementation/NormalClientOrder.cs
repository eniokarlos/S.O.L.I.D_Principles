namespace OCP.Implementation;

public class NormalClientOrder : IOrder
{
    public double Discount(double value)
    {
        return value;
    }
}