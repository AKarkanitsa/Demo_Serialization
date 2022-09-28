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

namespace ClassroomEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The Students.
        private List<Student> Students;

        // Load saved Students.
        private void Form1_Load(object sender, EventArgs e)
        {
            // See if the serialization file exists.
            if (File.Exists("Students.xml"))
            {
                // Deserialize the file.
                // Create a serializer that works with Student[].
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));

                // Create a stream from which to read the serialization.
                using (FileStream reader = File.OpenRead("Students.xml"))
                {
                    // Deserialize.
                    Students = (List<Student>)serializer.Deserialize(reader);
                }
            }
            else
            {
                // Create an empty student list.
                Students = new List<Student>();
            }

            // Display the Students.
            studentsListBox.DataSource = Students;
        }

        // Save Students.
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Create a serializer that works with Student[].
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));

            // Create a StreamWriter to hold the serialization.
            using (StreamWriter writer = File.CreateText("Students.xml"))
            {
                // Serialize the student list.
                serializer.Serialize(writer, Students);
            }
        }

        // Enable or disable the Edit and Delete buttons.
        private void studentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = (studentsListBox.SelectedIndex >= 0);
            deleteButton.Enabled = (studentsListBox.SelectedIndex >= 0);
        }

        // Add a new Student.
        private void addButton_Click(object sender, EventArgs e)
        {
            EditStudentForm frm = new EditStudentForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                studentsListBox.DataSource = null;
                Students.Add(new Student(
                    frm.firstNameTextBox.Text,
                    frm.lastNameTextBox.Text));
                studentsListBox.DataSource = Students;
            }
        }

        // Edit the selected student.
        private void editButton_Click(object sender, EventArgs e)
        {
            // Get the selected student.
            Student student = (Student)studentsListBox.SelectedItem;

            // Edit it.
            EditStudentForm frm = new EditStudentForm();
            frm.firstNameTextBox.Text = student.FirstName;
            frm.lastNameTextBox.Text = student.LastName;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                studentsListBox.DataSource = null;
                student.FirstName = frm.firstNameTextBox.Text;
                student.LastName = frm.lastNameTextBox.Text;
                studentsListBox.DataSource = Students;
            }
        }

        // Delete the selected student.
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Get the selected student.
            Student student = (Student)studentsListBox.SelectedItem;

            if (MessageBox.Show("Delete " + student.ToString() + "?",
                "Delete?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                studentsListBox.DataSource = null;
                Students.Remove(student);
                studentsListBox.DataSource = Students;
            }
        }
    }
}
