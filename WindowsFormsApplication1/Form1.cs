using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Add a reference to System.Runtime.Serialization.
using System.Runtime.Serialization;

// Add a reference to System.ServiceModel.Web.
using System.Runtime.Serialization.Json;

using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Customer customer = new Customer("Rod", "Stephens");
            customer.Picture = Properties.Resources._24hour;


            // Create a serializer that works with the Customer class.
            XmlSerializer serializer = new XmlSerializer(typeof(Customer));

            // Create a TextWriter to hold the serialization.
            string serialization;
            using (TextWriter writer = new StringWriter())
            {
                // Serialize the Customer.
                serializer.Serialize(writer, customer);
                serialization = writer.ToString();
            }

            // Display the serialization.
            Console.WriteLine(serialization);


            //DataContractJsonSerializer serializer =
            //    new DataContractJsonSerializer(typeof(Customer));

            //// Create a stream to hold the serialization.
            //using (MemoryStream stream = new MemoryStream())
            //{
            //    // Serialize the Customer.
            //    serializer.WriteObject(stream, customer);

            //    // Convert the stream into a string.
            //    stream.Seek(0, SeekOrigin.Begin);
            //    string serialization;
            //    using (StreamReader reader = new StreamReader(stream))
            //    {
            //        serialization = reader.ReadToEnd();

            //        // Display the serialization.
            //        Console.WriteLine(serialization);
            //    }
            //}
        }

        public class Customer
        {
            public string FirstName, LastName;

            [IgnoreDataMember]
            public Image Picture;

            public Customer() { }
            public Customer(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
        }
    }
}
