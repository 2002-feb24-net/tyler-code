namespace PersonList
{
    public class Person
    {
        private string _name;
        private int _age;
        public string Name
        {
            get
            {
            return _name;
            }

            set
            {
                if(!(value == ""))
                {
                    _name = value;
                }
            }
            
        }

        public Person(string Name, int Age)
        {
            _name = Name;
            _age = Age;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}