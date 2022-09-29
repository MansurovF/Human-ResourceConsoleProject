using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectNumber_1.NewFolder
{
    public interface IHumanResourceManager
    {
        Department[] Departments { get; }
        public void AddDepartment();
        Department[] GetDepartments();
        Department[] EditDepartments();
        public void AddEmployee();
        public void RemoveEmployee();
        public void EditEmploye();

        


    }
}
