using FactorySample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample
{
    internal class CarFactory
    {
        public ICarSupplier GetCar(string type)
        {
            ICarSupplier? car = null;
            if (type == "B")
            {
                car = new BMW();
            }
            else if (type == "F")
            {
                car = new Ford();
            }
            else if (type == "H")
            {
                car = new Honda();
            }
            else
            {
                throw new Exception("Not valid type");
            }
            return car;
        }
    }
}
