namespace ISP.Implementation;

public class ProductRegister : IPersistence
{
    public void SaveInDataBase()
    {
        System.Console.WriteLine("Saved in data base");
    }
    
    public void ValidateData()
    {
        System.Console.WriteLine("validated data");
    }
}