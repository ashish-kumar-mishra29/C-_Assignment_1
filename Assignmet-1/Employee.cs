using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmet_1
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public string DepartmentName;

        public delegate void MethodCalledEventHandler(string methodName);

        public event MethodCalledEventHandler MethodCalled;

        public Employee(int id, string name, string departmentName)
        {
            Id = id;
            Name = name;
            DepartmentName = departmentName;
        }

        public int GetId()
        {
            MethodCalled.Invoke("GetId() method called");
            return Id;
        }

        public string GetName()
        {
            MethodCalled.Invoke("GetName() method called");
            return Name;
        }

        public string GetDepartmentName()
        {
            MethodCalled.Invoke("GetDepartmentName() method called");
            return DepartmentName;
        }

        public void UpdateId(int id)
        {
            Id = id;
        }

        public void UpdateName(string name)
        {
            Name = name;
        }

        public void UpdateDepartmentName(string departmentName)
        {
            DepartmentName = departmentName;
        }
    }
}
