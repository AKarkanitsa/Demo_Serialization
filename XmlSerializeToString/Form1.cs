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

namespace XmlSerializeToString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create some OrderItems.
            OrderItem item1 = new OrderItem("Pencil", 12, 0.25m);
            OrderItem item2 = new OrderItem("Notepad", 6, 1.00m);
            OrderItem item3 = new OrderItem("Binder", 1, 3.50m);
            OrderItem item4 = new OrderItem("Tape", 12, 0.75m);

            // Create some Orders.
            Order order1 = new Order(new DateTime(2014, 4, 4), item1, item2);
            Order order2 = new Order(new DateTime(2014, 4, 17), item3, item4);

            // Create a Customer.
            Customer customer = new Customer("Rod", "Stephens", order1, order2);

            // Display the Customer.
            DisplayCustomer(originalTextBox, customer);

            // Serialize and display the serialization.
            string serialization = XmlTools.Serialize(customer);
            serializationTextBox.Text = serialization;

            // Deserialize.
            Customer newCustomer = XmlTools.Deserialize<Customer>(serialization);

            // Display the deserialization.
            DisplayCustomer(deserializedTextBox, newCustomer);
        }

        // Display the customer's data in a TextBox.
        private void DisplayCustomer(TextBox txt, Customer customer)
        {
            txt.Clear();
            txt.AppendText("FirstName: " + customer.FirstName + "\r\n");
            txt.AppendText("LastName: " + customer.LastName + "\r\n");
            txt.AppendText("Orders: \r\n");
            foreach (Order order in customer.Orders)
            {
                txt.AppendText("  OrderDate: " + order.OrderDate.ToShortDateString() + "\r\n");
                foreach (OrderItem item in order.OrderItems)
                {
                    txt.AppendText("    Item: " + item.Description +
                        " x " + item.Quantity.ToString() +
                        " @ " + item.UnitPrice.ToString("C") + "\r\n");
                }
            }
        }
    }

    // Customer and related classes.
    public class Customer
    {
        public string FirstName, LastName;
        public List<Order> Orders = new List<Order>();

        public Customer() { }
        public Customer(string firstName, string lastName, params Order[] orders)
        {
            FirstName = firstName;
            LastName = lastName;
            foreach (Order order in orders) Orders.Add(order);
        }
    }

    public class Order
    {
        public DateTime OrderDate;
        public OrderItem[] OrderItems;

        public Order() { }
        public Order(DateTime orderDate, params OrderItem[] orderItems)
        {
            OrderDate = orderDate;
            OrderItems = orderItems;
        }
    }

    public class OrderItem
    {
        public string Description;
        public int Quantity;
        public decimal UnitPrice;

        public OrderItem() { }
        public OrderItem(string description, int quantity, decimal unitPrice)
        {
            Description = description;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
