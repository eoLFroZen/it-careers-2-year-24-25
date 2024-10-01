using D08P01;

string line;

List<IIdentifiable> identifiers = new List<IIdentifiable>();

while ((line = Console.ReadLine()) != "End")
{
    List<string> arguments = line
        .Split()
        .ToList();

    string id = arguments[arguments.Count - 1];

    IIdentifiable identifiable = null;

    if (arguments.Count == 2)
    {
        string model = arguments[0];

        identifiable = new Robot(id, model);
    }
    else if (arguments.Count == 3)
    {
        string name = arguments[0];
        int age = int.Parse(arguments[1]);

        identifiable = new Person(id, name, age);
    }

    identifiers.Add(identifiable);
}

string fakeIdEnd = Console.ReadLine();

identifiers
    .Where(i => i.Id.EndsWith(fakeIdEnd))
    .ToList()
    .ForEach(i => Console.WriteLine(i.Id));