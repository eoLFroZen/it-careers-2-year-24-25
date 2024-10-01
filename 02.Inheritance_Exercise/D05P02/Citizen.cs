namespace D05P02
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Id { get; }
        public string Name { get; }
        public int Age { get; }
        public string Birthdate { get; }
    }
}
