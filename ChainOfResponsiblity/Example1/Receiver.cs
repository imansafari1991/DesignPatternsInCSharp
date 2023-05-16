using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    /// <summary>
    /// Abstract class -Receiver
    /// The abstract class is chosen to share
    /// the common codes across derived classes.
    /// </summary>
    abstract class Receiver
    {
        protected Receiver nextReceiver;
        //To set the next handler in the chain.
        public void NextReceiver(Receiver nextReceiver)
        {
            this.nextReceiver = nextReceiver;
        }
        public abstract void HandleMessage(Message message);
    }
}
