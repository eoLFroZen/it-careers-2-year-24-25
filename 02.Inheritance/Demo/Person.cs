namespace Demo
{
    public class Person
    {
        public Person() { }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public string Name { get; set; }
        public string Address { get; set; }
    }
}
