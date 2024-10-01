namespace _02._Family
{
    public class Family
    {
        private List<Person> persons;

        public Family()
        {
            persons = new List<Person>();
        }

        public List<Person> Persons
        {
            get { return persons; }
            set { persons = value; }
        }

        public void Print()
        {
            List<Person> sortedPersons = Persons
                .OrderBy(x => x.Name)
                .ToList();

            for (int i = 0; i < sortedPersons.Count; i++)
            {
                Person person = sortedPersons[i];
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
    }
}
