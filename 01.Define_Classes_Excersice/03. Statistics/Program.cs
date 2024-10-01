using _03._Statistics;

int count = int.Parse(Console.ReadLine());

List<Person> persons = new List<Person>();

for (int i = 0; i < count; i++)
{
    List<string> arguments = Console.ReadLine()
        .Split()
        .ToList();

    string name = arguments[0];
    int age = int.Parse(arguments[1]);

    if (age > 30)
    {
        Person person = new Person(name, age);

        persons.Add(person);
    }
}

List<Person> sortedPersons = persons
    .OrderBy(x => x.Name)
    .ToList();

Console.WriteLine(string.Join(Environment.NewLine, sortedPersons));

