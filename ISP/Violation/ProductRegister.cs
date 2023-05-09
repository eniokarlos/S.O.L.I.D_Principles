namespace ISP.Violation;

public class ProductRegister : IPersistence
{
    public void SaveInDataBase()
    {
        System.Console.WriteLine("Saved in data base");
    }

    // Register a product dont need Send Email
    public void SendEmail()
    {
        System.Console.WriteLine("Email sent");
    }

    public void ValidateData()
    {
        System.Console.WriteLine("validated data");
    }
}