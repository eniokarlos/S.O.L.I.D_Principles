namespace SRP.Implementation
{
    public class LogRegister : ILogger
    {
        public void Info(string info)
        {
            System.Console.WriteLine(info);
        }
    }
}