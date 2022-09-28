using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeFriends
{
    [Serializable]
    public class Person
    {
        public string Name;
        public List<Person> Friends = new List<Person>();
        public override string ToString()
        {
            return Name;
        }
    }
}
