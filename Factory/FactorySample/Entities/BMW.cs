using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample.Entities
{
     class BMW:ICarSupplier
    {
        public void Start()
        {
            Console.WriteLine("BMW is Started");
        }
    }
}
