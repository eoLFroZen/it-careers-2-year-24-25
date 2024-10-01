namespace D08P03
{
    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        private int age;

        public Citizen(string id, string name, int age, string birthdate)
        {
            Id = id;
            Name = name;
            this.age = age;
            Birthdate = birthdate;
            Food = 0;
        }

        public string Id { get; }

        public string Name { get; }

        public string Birthdate { get; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
