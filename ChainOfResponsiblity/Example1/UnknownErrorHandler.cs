using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    /// <summary>
    /// UnknownErrorHandler class
    /// </summary>
    class UnknownErrorHandler : Receiver
    {
        public override void HandleMessage(Message message)
        {
            if (!(message.Text.Contains("fax") || message.Text.
           Contains("email")))
            {
                Console.WriteLine("Unknown error occurs.Consult experts immediately.");
            }
            else if (nextReceiver != null)
            {
                nextReceiver.HandleMessage(message);
            }
        }
    }
}
