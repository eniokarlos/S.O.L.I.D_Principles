namespace OCP.Violation;

public class Order
{
    //OCP Violation
    public double Discount(double value, ClientType clientType)
    {   
        double finalValue;

        if(clientType == ClientType.ESPECIAL)
        {
            finalValue = value - 50;
        }
        else if(clientType == ClientType.AFFILIATED)
        {
            finalValue = value - 10;
        }
        else
        {
            finalValue = value;
        }
        return finalValue;
    }

}

public enum ClientType
{
    NORMAL,
    AFFILIATED,
    ESPECIAL
};