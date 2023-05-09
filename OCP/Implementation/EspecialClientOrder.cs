namespace OCP.Implementation;

public class EspecialClientOrder : IOrder
{
    public double Discount(double value)
    {
        return value - 50;
    } 
}