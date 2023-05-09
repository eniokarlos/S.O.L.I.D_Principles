
namespace SRP.Implementation
{
    public class Mail
    {

        public string From {get;set;}
        public string To {get;set;}
        public string Subject {get;set;}
        public string Body {get;set;}

        public void Send()
        {
            System.Console.WriteLine("Email Sent");
        }
    }
}