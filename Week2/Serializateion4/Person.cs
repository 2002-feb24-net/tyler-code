using System;
using System.Collections.Generic;
using System.Text;

namespace Serializateion4
{
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Person> Children { get; set; }
    }

    //You need an context class
}
