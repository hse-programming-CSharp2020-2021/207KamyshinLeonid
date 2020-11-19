using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    public class PartTimeEmployee : Employee
    {
        public int workingDays;
        public PartTimeEmployee(string name, decimal basepay, int workingDays) : base(name, basepay)
        {
            this.workingDays = workingDays;
        }
        public override decimal CalculatePay()
        {
            return basepay * workingDays / 25;
        }
        public override void ViewInfo()
        {
            Console.Write("Part time employee ");
            base.ViewInfo();
        }
    }
}
