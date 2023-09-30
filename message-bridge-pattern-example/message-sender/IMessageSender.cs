using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message_bridge_pattern_example.message_sender
{
    public interface IMessageSender
    {
        void SendMessage(String messageType, String content);
    }
}
