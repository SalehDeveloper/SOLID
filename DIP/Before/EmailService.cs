using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DIP.Before
{
    // low level module
    // if we need to  add a new message service like sms we need to update the NotificationService (High level module) 
    // so the High level module should not depend on low level module 
    public class EmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }


    public class NotificationService
    {
        private readonly EmailService service = new EmailService();

         public  void Notify (string message)
        {
            service.SendEmail(message);
        }
    }



}
