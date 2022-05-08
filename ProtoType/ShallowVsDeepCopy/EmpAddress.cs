using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowVsDeepCopy
{
     class EmpAddress
    {
        public string Address { get; set; }
        public EmpAddress(string address)
        {
            Address = address;
        }
        public override string ToString()
        {
            return Address;
        }
        public object CloneAddress()
        {
            // Shallow Copy
            return MemberwiseClone();
        }
    }
}
