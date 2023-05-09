namespace ISP.Implementation;

public class ClientRegister : IPersistence, IEmail
{
    public void SaveInDataBase()
    {
        System.Console.WriteLine("Saved in data base");
    }

    public void SendEmail()
    {
        System.Console.WriteLine("Email sent");
    }

    public void ValidateData()
    {
        System.Console.WriteLine("validated data");
    }
}