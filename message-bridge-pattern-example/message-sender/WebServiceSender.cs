using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message_bridge_pattern_example.message_sender
{
    public class WebServiceSender : IMessageSender
    {
        public void SendMessage(String messageType, String content)
        {
            Console.WriteLine("Web Service - " + messageType);
            Console.WriteLine(content);
        }
    }
}
