using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public abstract class BasicCar
    {
        public int basePrice = 0, onRoadPrice = 0;
        public string ModelName { get; set; }
        public string Color { get; set; }
        /*
        We'll add this price before
        the final calculation of onRoadPrice.
        */
        public static int SetAdditionalPrice()
        {
            Random random = new Random();
            int additionalPrice = random.Next(200000, 500000);
            return additionalPrice;
        }
        public abstract BasicCar Clone();
    }
}
