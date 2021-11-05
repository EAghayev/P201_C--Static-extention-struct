using System;

namespace StaticTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Employee.TotalCount);

            Employee emp1 = new Employee("Abbas","Abdullayev");
            Employee emp2 = new Employee("Nergiz","Rustemazde");
            Employee emp3 = new Employee("Leyla","Abbasova");

            Console.WriteLine(emp1.No);
            Console.WriteLine(emp2.No);
            Console.WriteLine(emp3.No);

            Console.WriteLine(Employee.TotalCount);

            Console.WriteLine(emp2.No);
        }
    }
}
