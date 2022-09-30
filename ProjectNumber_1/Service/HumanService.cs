using ProjectNumber_1;
using System;
using System.Collections.Generic;
using System.Text;


namespace ProjectNumber_1
{
    class HumanService : IHumanResourceManager
    {
        Department[] _departments;
        private double workerlimit;
        private readonly double salarylimit;

        public Department[] Departments => _departments;
        public HumanService()
        {
            _departments = new Department[0];
        }


        public Department[] GetDepartments()
        {
            Department[] department = new Department[0];
            foreach (Department department1 in _departments)
            {
                if (department!=null)
                {
                    Array.Resize(ref department, departments.Length + 1);
                    departments[departments.Length - 1] = department1;
                    
                }
                
            }
            return department; 
        }

        public void EditDepartments(string name, string newName)
        {
            foreach (Department department in departments)
            {
                if (department.Name== name)
                {
                    department.Name = newName;
                    foreach (Employee employee in department.Employees)
                    {

                        employee.No.Replace(employee.DepartmentName.Substring(0, 2).ToUpper(),newName.Substring(0,2).ToUpper());
                        employee.DepartmentName = newName;
                    }
                }
            }
        }

        public void AddEmployee(string fullname, string position, double salary, string departmentname)
        {

            Department department = new Department(name: departmentname, workerlimit: workerlimit, salarylimit: salarylimit);
            Array.Resize(ref _departments, _departments.Length + 1);
            _departments[_departments.Length - 1] = department;
        }

        public void RemoveEmployee(string no, string departmentName)
        {
            foreach (Department item in _departments)
            {
                for (int i = 0; i < item.Employees.Length; i++)
                {
                    if (item.Employees != null)
                    {
                        if (item.Employees[i].No.ToLower() == no.ToLower())
                        {
                            item.Employees[i] = null;
                            return;
                        }
                    }
                }

            }
        }

        public void EditEmployee(string no, string position, double salary)
        {
            foreach (Department item1 in _departments)
            {
                if (item1 != null)
                {
                    foreach (Employee item2 in item1.Employees)
                    {
                        if (item2 != null)
                        {
                            if (item2.No.ToLower() == no.ToLower())
                            {
                                item2.Salary = salary;
                                item2.Position = position;
                            }
                        }
                    }
                }

            }


        }
        public Department[] departments => departments;
        public void AddDepartment(string departmentname, double workerlimit, double salarylimit)
        {
            Department department = new Department(departmentname, workerlimit, salarylimit);
            Array.Resize(ref _departments, _departments.Length + 1);
            _departments[_departments.Length - 1] = department;
        }


    }

}
