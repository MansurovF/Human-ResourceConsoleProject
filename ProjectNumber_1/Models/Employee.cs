using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectNumber_1
{
    public class Employee
    {
        static int _no;
        string _fullname;
        string _position;
        double _salary;
        public string DepartmentName;


        //public Employee(string fullname, string position, double salary, string departmentName)
        //{
        //    No =
        //    Fullname = fullname;
        //    Position = position;
        //    Salary = salary;
        //    DepartmentName = departmentName;
        //    

        public override string ToString()
        {
            return $"{Fullname} {Position} {DepartmentName}";
        }

        static Employee()
        {
            _no = 1000;
        }

        

        public string No { get; set; }


        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                string[] array = value.Split(' ');
                while (array.Length <= 2)
                {
                    return;
                }
                _fullname = value;
            }
        }

        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                //string[] array = value.Split(' ');
                while (value.Length >= 2)
                {
                    return;
                }
                Position = value;

            }
        }
        public double Salary
        {
            get
            {
                return Salary;
            }
            set
            {
                if (value < 250)
                {
                    return;
                }
                _salary = value;
            }
        }
        public Employee(string fullname, string position, double salary, string departmentname)
        {
            Fullname = fullname;
            Position = position;
            Salary = salary;
            DepartmentName = departmentname;
            _no++;
            No += departmentname.ToUpper().Substring(0, 2) + _no;


        }


        
    }

}
