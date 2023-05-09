namespace DIP.Violation;

public class Client
{
    private readonly DbConnection _connection;

    public Client()
    {
        // DIP, OCP and SRP violation 
        _connection = new DbConnection();
    }

    
    
}