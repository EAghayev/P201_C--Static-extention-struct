using System;
using System.Collections.Generic;
using System.Text;

namespace StaticTask
{
    class Employee
    {
        public static int TotalCount;
        public Employee(string name,string surname)
        {
            TotalCount++;
            No = name[0].ToString() + surname[0] + (1000 + TotalCount);
        }

        public string No;
        public string Name;
        public string Surname;
        public double Salary;
    }
}
