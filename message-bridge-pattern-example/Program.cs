using message_bridge_pattern_example.message;
using message_bridge_pattern_example.message_sender;

internal class Program
{
    private static void Main(string[] args)
    {
        IMessage message1 = new UserMessage(new WebServiceSender());
        message1.Send("This is a test message!");
        IMessage message2 = new SystemMessage(new EmailSender());
        message2.Send("Hello world!");
    }
}