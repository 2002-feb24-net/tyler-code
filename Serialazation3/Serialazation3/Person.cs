using System;
using System.Collections.Generic;
using System.Text;

namespace Serialazation3
{
    class Person
    {
        //Make it a name, ID, and sub list of Children
        public string Name { get; set; }
        public int ID { get; set; }
        public List<Person> Children { get; set; } = new List<Person>();
    }
}
