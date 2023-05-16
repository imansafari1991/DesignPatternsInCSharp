using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    /// <summary>
    /// EmailErrorHandler class
    /// </summary>
    class EmailErrorHandler : Receiver
    {
        bool messagePassedToNextHandler = false;
        public override void HandleMessage(Message message)
        {
            //Start processing if the error message contains "email"
            if (message.Text.Contains("email"))
            {
                Console.WriteLine($"EmailErrorHandler processed {message.
               Priority} priority issue: {message.Text}");
                //Do not leave now, if the error message contains "fax" too.
                if (nextReceiver != null && message.Text.Contains("fax"))
                {
                    Console.WriteLine("Email side defect is fixed.Now fax team needs to cross verify this fix.");
                    //Keeping the following code here.
                    //It can be useful if you place this handler before fax 
                    //error handler
                    nextReceiver.HandleMessage(message);
                    //We'll not pass the message repeatedly to the next 
                    //handler.
                    messagePassedToNextHandler = true;
                }
            }
            if (nextReceiver != null && messagePassedToNextHandler != true)
            {
                nextReceiver.HandleMessage(message);
            }
        }
    }
}
