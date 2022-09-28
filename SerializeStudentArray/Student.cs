using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace SerializeStudentArray
{
    public class Student
    {
        [XmlAttribute]
        public string FirstName { get; set; }

        [XmlAttribute]
        public string LastName { get; set; }

        public Student() { }
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
