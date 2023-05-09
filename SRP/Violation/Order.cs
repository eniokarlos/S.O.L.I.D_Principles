using System.Net.Mail;

namespace SRP.Violation
{
    public class Order
    {
        public long Quantity {get;set;}

        public void Add()
        {
            try
            {
                System.Console.WriteLine("Order Added");
                MailMessage mailMessage = 
                    new MailMessage("From ", "To",
                                "Subject", "Body");

                // SRP Violation
                this.SendEmail(mailMessage);   
            }
            catch(Exception e)
            {
                // SRP Violation
                File.WriteAllText(@"c:\data\ErrorLog.txt", e.ToString());
            }
        }


        public void Delete()
        {
            try
            {
                System.Console.WriteLine("Order Removed");
            }
            catch(Exception e)
            {
                // SRP Violation
                File.WriteAllText(@"c:\data\ErrorLog.txt", e.ToString());
            }
        }

        // SRP Violation
        public void SendEmail(MailMessage message)
        {
            try
            {
                System.Console.WriteLine("Email sent");
            }
            catch(Exception e)
            {
                File.WriteAllText(@"c:\data\ErrorLog.txt", e.ToString());
            }
        }
    }
}