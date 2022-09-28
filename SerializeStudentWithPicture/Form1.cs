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

namespace SerializeStudentWithPicture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make a Student.
            Student student = new Student("Rod", "Stephens", Properties.Resources.Rod);

            // Display the Student's data.
            firstNameTextBox.Text = student.FirstName;
            lastNameTextBox.Text = student.LastName;
            studentPictureBox.Image = student.Picture;

            // Create a serializer that works with the Student class.
            XmlSerializer serializer = new XmlSerializer(typeof(Student));

            // Create a TextWriter to hold the serialization.
            string serialization;
            using (TextWriter writer = new StringWriter())
            {
                // Serialize the Customer.
                serializer.Serialize(writer, student);
                serialization = writer.ToString();
            }

            // Display the serialization.
            serializationTextBox.Text = serialization;

            // Create a reader from which to read the serialization.
            using (TextReader reader = new StringReader(serialization))
            {
                // Deserialize.
                Student newStudent = (Student)serializer.Deserialize(reader);

                // Display the new Student's data.
                firstNameTextBox2.Text = newStudent.FirstName;
                lastNameTextBox2.Text = newStudent.LastName;
                studentPictureBox2.Image = newStudent.Picture;
            }
        }
    }
}
