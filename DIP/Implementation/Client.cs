namespace DIP.Implementation;

public class Client
{
    private readonly IDataBaseConnection _connection;

    public Client(IDataBaseConnection connection)
    {
        _connection = connection;
    }

    
    
}