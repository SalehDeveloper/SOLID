using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.After
{ 
    //using this design if you need to add a new service like WhatsApp service
    //you dont need to update any thing only add the service and pass any type you want to the Notfication Serviec
    public interface IMessageService
    {
        void Send(string message);
    }

    public class EmailService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine("Email sent");
        }
    }

    public class SmsService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine("SMS sent");
        }
    }

    
    public class NotificationSerivce
    {

        private readonly IMessageService _service;

        public NotificationSerivce(IMessageService service)
        {
            _service = service;
        }


        public void Notify(string message)
        {
            _service.Send(message);
        }
    }
}
