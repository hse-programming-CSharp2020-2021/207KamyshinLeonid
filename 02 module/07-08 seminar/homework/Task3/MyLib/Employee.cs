using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    public class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee a, Employee b)
        {
            if (a is SalesEmployee)
            {
                a = a as SalesEmployee;
            }
            else
            {
                a = a as PartTimeEmployee;
            }
            if (b is SalesEmployee)
            {
                b = b as SalesEmployee;
            }
            else
            {
                b = b as PartTimeEmployee;
            }
            return a.CalculatePay().CompareTo(b.CalculatePay());
        }
    }
    public class Employee
    {
        public string name;

        // Basepay is defined as protected, so that it may be
        // accessed only by this class and derived classes.
        protected decimal basepay;

        // Constructor to set the name and basepay values.
        public Employee(string name, decimal basepay)
        {
            this.name = name;
            this.basepay = basepay;
        }

        // Declared virtual so it can be overridden.
        public virtual decimal CalculatePay()
        {
            return basepay;
        }
        public virtual void ViewInfo()
        {
            Console.Write($"name: {name}, pay: {CalculatePay()}");
        }
    }
}
