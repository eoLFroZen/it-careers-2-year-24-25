namespace D08P01
{
    public class Person : IIdentifiable
    {
        private string name;
        private int age;

        public Person(string id, string name, int age)
        {
            Id = id;
            this.name = name;
            this.age = age;
        }

        public string Id { get; private set; }
    }
}
