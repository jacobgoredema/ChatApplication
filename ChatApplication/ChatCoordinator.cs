using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public delegate void MessageHandler(string message);
    public class ChatCoordinator
    {
        //List<MessageHandler> Handlers = new List<MessageHandler>();
        public event MessageHandler ReceiveMessage;
        //public void Register(MessageHandler handler)
        //{
        //    Handlers.Add(handler);
        //}
        public void Broadcast(string message)
        {
            //foreach (MessageHandler handler in Handlers)
            //    handler(message);
            if (ReceiveMessage != null)
                ReceiveMessage(message);
        }

        //singleton class(only one instancecan be created
        private ChatCoordinator()
        {

        }

        private static ChatCoordinator obj;
        public static ChatCoordinator GetObject()
        {
            if (obj == null)
                obj = new ChatCoordinator();
            return obj;
        }
    }
}
