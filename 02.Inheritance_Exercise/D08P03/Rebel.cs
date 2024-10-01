namespace D08P03
{
    public class Rebel : IBuyer
    {
        private int age;
        private string group;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            this.age = age;
            this.group = group;
            Food = 0;
        }

        public string Name { get; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
