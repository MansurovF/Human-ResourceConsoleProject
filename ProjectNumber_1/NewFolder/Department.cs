using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectNumber_1.NewFolder
{
    public class Department
    {
        public string Name;
        public double WorkerLimit;
        public double SalaryLimit;
        public string Employees;

        public Employee[] Employees;
        public Department()
        {
            Employee = new Employee[0];
        }

        internal Employee[] Employee { get; }

        public double CalcSalaryAverage()
        {
             
        }

    }
}
