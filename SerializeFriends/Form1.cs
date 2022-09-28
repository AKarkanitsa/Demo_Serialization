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

namespace SerializeFriends
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The people.
        private List<Person> People = null;

        // The currently selected person.
        private Person SelectedPerson = null;

        // Reload saved data.
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Friends.dat"))
            {
                // Deserialize the data.
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream("Friends.dat", FileMode.Open))
                {
                    People = (List<Person>)formatter.Deserialize(stream);
                }
            }
            else
            {
                // Create some initial people.
                People = new List<Person>();
                People.Add(new Person() { Name = "Archibald" });
                People.Add(new Person() { Name = "Beatrix" });
                People.Add(new Person() { Name = "Charles" });
                People.Add(new Person() { Name = "Delilah" });
                People.Add(new Person() { Name = "Edgar" });
                People.Add(new Person() { Name = "Francine" });
            }

            // Add all people to the friends list.
            foreach (Person person in People)
                friendsCheckedListBox.Items.Add(person);

            // Display the people.
            personListBox.DataSource = People;
        }

        // Select this person's friends.
        private void personListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the currently selected person's friends.
            UpdateFriends();

            // Update the selected person.
            SelectedPerson = (Person)personListBox.SelectedItem;

            // Check the newly selected person's friends.
            for (int i=0; i<friendsCheckedListBox.Items.Count; i++)
            {
                bool isFriend =
                    SelectedPerson.Friends.Contains(friendsCheckedListBox.Items[i]);
                friendsCheckedListBox.SetItemChecked(i, isFriend);
            }
        }

        // Update the currently selected person's friends.
        private void UpdateFriends()
        {
            if (SelectedPerson != null)
            {
                SelectedPerson.Friends = new List<Person>();
                foreach (object friend in friendsCheckedListBox.CheckedItems)
                    SelectedPerson.Friends.Add((Person)friend);
            }
        }

        // Save the friend data.
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Update the currently selected person's friends.
            UpdateFriends();

            // Save the data.
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream("Friends.dat", FileMode.Create))
            {
                formatter.Serialize(stream, People);
            }
        }
    }
}
