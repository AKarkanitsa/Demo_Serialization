using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeDepartment
{
    [Serializable]
    public class Employee
    {
        public string Name;
        public Department Department;

        public Employee() { }
        public Employee(string name, Department department)
        {
            Name = name;
            Department = department;
        }
    }
}
