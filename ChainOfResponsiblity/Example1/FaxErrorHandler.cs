using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    /// <summary>
    /// FaxErrorHandler class
    /// </summary>
    class FaxErrorHandler : Receiver
    {
        bool messagePassedToNextHandler = false;
        public override void HandleMessage(Message message)
        {
            //Start processing if the error message contains "fax"
            if (message.Text.Contains("fax"))
            {
                Console.WriteLine($"FaxErrorHandler processed {message.
               Priority} priority issue: {message.Text}");
                //Do not leave now, if the error message contains email too.
                if (nextReceiver != null && message.Text.Contains("email"))
                {
                    Console.WriteLine("I've fixed fax side defect.Now email team needs to work on top of this fix.");
                   
                    nextReceiver.HandleMessage(message);
                    //We'll not pass the message repeatedly to next handler.
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
