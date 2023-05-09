using System.Net.Mail;

namespace SRP.Implementation
{
    public class Order
    {
        public long Quantity {get;set;}
        private ILogger logger;
        private Mail mail;
        

        public Order()
        {
            mail = new Mail();
            logger = new LogRegister();
        }

        public void Add()
        {
            try
            {
                logger.Info("Adding order");
                mail.From = "example@example.com";
                mail.To = "example2@example.com";
                mail.Subject = "SRP";
                mail.Body = "Body...";
                mail.Send();
            }
            catch(Exception e)
            {
                logger.Info("Error: " + e.Message);
            }
        }

        public void Delete()
        {
            try
            {
                logger.Info("Order Removed");
            }
            catch(Exception e)
            {
                logger.Info("Error: " + e.Message);
            }
        }

    }
}