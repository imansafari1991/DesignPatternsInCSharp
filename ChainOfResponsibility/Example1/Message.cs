using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    /// <summary>
    /// Message class
    /// </summary>
    public class Message
    {
        public string Text { get; set; }
        public MessagePriority Priority;
        public Message(string msg, MessagePriority priority)
        {
            this.Text = msg;
            this.Priority = priority;
        }
    }
}
