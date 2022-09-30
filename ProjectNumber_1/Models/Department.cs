using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectNumber_1
{
    public class Department
    {
         string _Name;
         double _WorkerLimit;
         double _SalaryLimit;
         string _Employees;


        //public Employee(string name, double workerlimit, double salarylimit, string employees);

        public Employee[] Employees;

        public Department(string name, double workerlimit, double salarylimit)
        {
            Employees = new Employee[0];
            Name = name;
            WorkerLimit = workerlimit;
            SalaryLimit = salarylimit;
        }


        public double CalcSalaryAverage()
        {
            double cem = 0;
            foreach (Employee item in Employees)
            {
                cem += item.Salary;
            }
            double avg = cem / Employees.Length;
            return avg;
        }


        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (Name.Length>2)
                {
                    return;
                }
                else
                {
                    _Name = value;
                }
            }
        }
         public double WorkerLimit
        {
            get
            {
                return _WorkerLimit;
            }
            set
            {
                if (value<1)
                {
                    return;
                }
            }
        }
        public double SalaryLimit
        {
            get
            {
                return _SalaryLimit;
            }
            set
            {
                if (value<250)
                {
                    return;
                }
                
            }
        }
        
        
    }
}
