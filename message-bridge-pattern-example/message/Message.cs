using message_bridge_pattern_example.message_sender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message_bridge_pattern_example.message
{
    public abstract class Message : IMessage
    {
        private IMessageSender _sender;

        public Message(IMessageSender sender)
        {
            _sender = sender;
        }

        public IMessageSender Sender
        {
            get { return _sender; }
            set { _sender = value; }
        }

        public abstract void Send(String content);
    }
}
