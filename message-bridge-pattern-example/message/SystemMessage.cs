using message_bridge_pattern_example.message_sender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message_bridge_pattern_example.message
{
    public class SystemMessage : Message
    {
        public SystemMessage(IMessageSender sender) : base(sender) { }

        public override void Send(String content)
        {
            Sender.SendMessage("System", content);
        }
    }
}
