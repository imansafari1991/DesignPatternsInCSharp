using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowVsDeepCopy
{
     class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EmpAddress EmpAddress { get; set; }
        public Employee(int id, string name, EmpAddress empAddress)
        {
            this.Id = id;
            this.Name = name;
            this.EmpAddress = empAddress;
        }
        public override string ToString()
        {
            return string.Format("Employee Id is : {0},Employee Name is : {1}, Employee Address is : {2}", this.Id,this.Name,this.EmpAddress.ToString());
        }
        public object Clone()
        {
            // Shallow Copy
            return this.MemberwiseClone();
            #region For deep copy
           
            #endregion
        }


        public object DeepClone()
        {
            Employee employee = (Employee)this.MemberwiseClone();
            employee.EmpAddress = (EmpAddress)this.EmpAddress.CloneAddress();
            /*
            * NOTE:
            * Error: MemberwiseClone() is protected, you cannot access 
           it via a qualifier of type EmpAddress. The qualifier must be 
           Employee or its derived type.
            */
            
            return employee;
        }
        //Copy Constructor
        public Employee(Employee originalEmployee)
        {
            Id=originalEmployee.Id;
            Name=originalEmployee.Name;
            this.EmpAddress=originalEmployee.EmpAddress.CloneAddress() as EmpAddress;

            
        }
    }
}
