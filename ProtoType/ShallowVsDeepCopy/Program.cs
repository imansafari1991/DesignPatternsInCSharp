using ShallowVsDeepCopy;

Console.WriteLine("***Shallow vs Deep Copy Demo.***\n");
EmpAddress initialAddress = new EmpAddress("21, abc Road, USA");
Employee emp = new Employee(1, "John", initialAddress);
Console.WriteLine("The original object is emp1 which is as follows: ");

Console.WriteLine(emp);
Console.WriteLine("Making a clone of emp1 now.");
Employee empClone = (Employee)emp.Clone();
Console.WriteLine("empClone object is as follows:");
Console.WriteLine(empClone);
Console.WriteLine("\n Now changing the name, id and address of the cloned object ");

empClone.Id = 10;
empClone.Name = "Sam2";
empClone.EmpAddress.Address = "221, xyz Road, Canada ";
Console.WriteLine("Now emp1 object is as follows:");
Console.WriteLine(emp);
Console.WriteLine("And emp1Clone object is as follows:");
Console.WriteLine(empClone);


Console.WriteLine("---------------------------------Deep Clone------------------------");

Employee deepEmpClone= (Employee)emp.DeepClone();

Console.WriteLine("deepEmpClone object is as follows:");
Console.WriteLine(deepEmpClone);
Console.WriteLine("\n Now changing the name, id and address of the deep cloned object ");
deepEmpClone.Id = 10;
deepEmpClone.Name = "Sam2";
deepEmpClone.EmpAddress.Address = "221, xyz Road, Canada 2";

Console.WriteLine("Now emp1 object is as follows:");
Console.WriteLine(emp);
Console.WriteLine("And deepemp1Clone object is as follows:");
Console.WriteLine(deepEmpClone);
