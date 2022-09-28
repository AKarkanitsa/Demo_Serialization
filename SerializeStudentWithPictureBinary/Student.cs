using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Xml.Serialization;

namespace SerializeStudentWithPictureBinary
{
    [Serializable]
    public class Student
    {
        public string FirstName, LastName;
        public Image Picture;

        public Student() { }
        public Student(string firstName, string lastName, Image picture)
        {
            FirstName = firstName;
            LastName = lastName;
            Picture = picture;
        }
    }
}
