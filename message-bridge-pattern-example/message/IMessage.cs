using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message_bridge_pattern_example.message
{
    public interface IMessage
    {
        void Send(String content);
    }
}
