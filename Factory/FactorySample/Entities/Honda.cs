using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample.Entities
{
    internal class Honda:ICarSupplier
    {
        public void Start()
        {
            Console.WriteLine("Ford is Started");
        }
    }
}
