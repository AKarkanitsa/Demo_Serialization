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

namespace SerializeDepartment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create some data.
            Department department = new Department()
                { Name = "R & D", Logo = Properties.Resources.Logo };
            Employee[] employees =
            {
                new Employee("Alice Able", department),
                new Employee("Bart Benedict", department),
                new Employee("Cynthia Carruthers", department),
                new Employee("Daniel Dent", department),
                new Employee("Ella Everstone", department),
                new Employee("Francois Fredericks", department),
            };
            department.Employees = employees.ToList();

            // Display the data.
            originalPictureBox.Image = department.Logo;
            originalTextBox.Text = DisplayDepartment(department);

            // Create a BinaryFormatter.
            IFormatter formatter = new BinaryFormatter();

            // Create a stream to hold the serialization.
            using (MemoryStream stream = new MemoryStream())
            {
                // Serialize.
                formatter.Serialize(stream, department);

                // Display a textual representation of the serialization.
                byte[] bytes = stream.ToArray();
                string serialization = BitConverter.ToString(bytes).Replace("-", " ");

                // Display the serialization.
                serializationTextBox.Text = serialization;

                // Deserialize.
                stream.Seek(0, SeekOrigin.Begin);
                Department newDepartment = (Department)formatter.Deserialize(stream);

                // Display the new Department's data.
                deserializedPictureBox.Image = newDepartment.Logo;
                deserializedTextBox.Text = DisplayDepartment(newDepartment);
            }
        }

        // Display a Department's data.
        private string DisplayDepartment(Department department)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Name: " + department.Name + "\r\n");
            foreach (Employee employee in department.Employees)
            {
                builder.Append("    " + employee.Name +
                    ": " + employee.Department.Name + "\r\n");
            }
            return builder.ToString();
        }
    }
}
