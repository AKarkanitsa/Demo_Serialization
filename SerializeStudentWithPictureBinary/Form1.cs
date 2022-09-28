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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;

namespace SerializeStudentWithPictureBinary
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

            // Create a BinaryFormattter.
            IFormatter formatter = new BinaryFormatter();

            // Create a stream to hold the serialization.
            using (MemoryStream stream = new MemoryStream())
            {
                // Serialize.
                formatter.Serialize(stream, student);

                // Display a textual representation of the serialization.
                byte[] bytes = stream.ToArray();
                string serialization = BitConverter.ToString(bytes).Replace("-", " ");

                // Display the serialization.
                serializationTextBox.Text = serialization;

                // Deserialize.
                stream.Seek(0, SeekOrigin.Begin);
                Student newStudent = (Student)formatter.Deserialize(stream);

                // Display the new Student's data.
                firstNameTextBox2.Text = newStudent.FirstName;
                lastNameTextBox2.Text = newStudent.LastName;
                studentPictureBox2.Image = newStudent.Picture;
            }
        }
    }
}
