namespace DIP.Implementation;

public class DbConnection : IDataBaseConnection
{
    public void Connect()
    {
        System.Console.WriteLine("Connected!");
    }
}