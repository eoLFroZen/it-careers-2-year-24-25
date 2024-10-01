namespace D08P02
{
    public class Citizen : IIdentifiable, IBirthable
    {
        private string name;
        private int age;

        public Citizen(string id, string name, int age, string birthdate)
        {
            Id = id;
            this.name = name;
            this.age = age;
            Birthdate = birthdate;
        }

        public string Id { get; }
        public string Birthdate { get; }
    }
}
