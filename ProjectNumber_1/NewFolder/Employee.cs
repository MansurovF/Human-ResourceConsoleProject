using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectNumber_1.NewFolder
{
    class Employee
    {
        public byte No;
         string _fullname;
         string _position;
         double _salary;
        public string DepartmentName;


        public Employee(byte no,string fullname,string position,double salary,string departmentName)
        {
            No = no;
            Fullname = fullname;
            Position = position;
            Salary = salary;
            DepartmentName = departmentName;
        }

        public override string ToString()
        {
            return $"{Fullname}{Position}{DepartmentName}";
        }

        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                string[] array = value.Split(' ');
                while (array.Length<=2)
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
                string[] array = value.Split(' ');
                while(array.Length >= 2)
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
                if (value>250)
                {
                    return;
                }
                _salary = value;
            }
        }
        //public string DepartmentName
        //{
           
        //}

        //public override string 
    }
}
