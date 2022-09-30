using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectNumber_1
{
     interface IHumanResourceManager
    {
        public Department[] Departments { get; }
        public void AddDepartment(string departmentname,double workerlimit,double salarylimit);
        Department[] GetDepartments();
        void EditDepartments(string name,string newName);
        public void AddEmployee(string fullname,string position,double salary,string departmentname);
        public void RemoveEmployee(string no,string departmentName);
        public void EditEmployee(string no,string position,double salary);

        
        
    }
    

}
