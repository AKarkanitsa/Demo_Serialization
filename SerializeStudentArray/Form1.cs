using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Xml.Serialization;

namespace SerializeStudentArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make some Students.
            Student[] students =
            {
                new Student("Annie", "Artichoke"),
                new Student("Bert", "Broccoli"),
                new Student("Candice", "Chickpea"),
                new Student("Daniel", "Dandelion"),
                new Student("Edna", "Endive"),
            };

            // Display the students.
            originalListBox.DataSource = students;

            // Create a serializer that works with Student[].
            XmlSerializer serializer = new XmlSerializer(typeof(Student[]));

            // Create a TextWriter to hold the serialization.
            string serialization;
            using (TextWriter writer = new StringWriter())
            {
                // Serialize the students array.
                serializer.Serialize(writer, students);
                serialization = writer.ToString();
            }

            // Display the serialization.
            serializationTextBox.Text = serialization;

            // Create a reader from which to read the serialization.
            using (TextReader reader = new StringReader(serialization))
            {
                // Deserialize.
                Student[] newStudents = (Student[])serializer.Deserialize(reader);

                // Display the deserialization.
                deserializedListBox.DataSource = newStudents;
            }
        }
    }
}
