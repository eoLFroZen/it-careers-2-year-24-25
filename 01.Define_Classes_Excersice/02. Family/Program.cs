using _02._Family;

int count = int.Parse(Console.ReadLine());
Family family = new Family();

for (int i = 0; i < count; i++)
{
    List<string> arguments = Console.ReadLine()
        .Split()
        .ToList();

    string name = arguments[0];
    int age = int.Parse(arguments[1]);

    Person person = new Person(name, age);

    family.Persons.Add(person);
}

family.Print();