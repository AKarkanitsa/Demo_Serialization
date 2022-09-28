using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace SerializeDepartment
{
    [Serializable]
    public class Department
    {
        public Image Logo;
        public string Name;
        public List<Employee> Employees = new List<Employee>();
    }
}
