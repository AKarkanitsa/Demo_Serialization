using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Xml.Serialization;

namespace SerializeStudentWithPicture
{
    public class Student
    {
        public string FirstName, LastName;

        [XmlIgnore]
        public Image Picture;

        // Return the Picture as a byte stream.
        public byte[] PictureBytes
        {
            get     // Serialize
            {
                if (Picture == null) return null;
                using (MemoryStream stream = new MemoryStream())
                {
                    Picture.Save(stream, ImageFormat.Png);
                    return stream.ToArray();
                }
            }
            set     // Deserialize.
            {
                if (value == null) Picture=  null;
                else
                {
                    using (MemoryStream stream = new MemoryStream(value))
                    {
                        Picture = new Bitmap(stream);
                    }
                }
            }
        }

        public Student() { }
        public Student(string firstName, string lastName, Image picture)
        {
            FirstName = firstName;
            LastName = lastName;
            Picture = picture;
        }
    }
}
