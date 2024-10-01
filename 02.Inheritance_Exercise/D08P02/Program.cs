using D08P02;

string input;

List<IBirthable> birthables = new List<IBirthable>();

while ((input = Console.ReadLine()) != "End")
{
    List<string> arguments = input
        .Split()
        .ToList();

    string type = arguments[0];

    IBirthable birthable = null;

    if(type == "Citizen")
    {
        string name = arguments[1]; 
        int age = int.Parse(arguments[2]);
        string id = arguments[3];
        string birthdate = arguments[4];

        birthable = new Citizen(id, name, age, birthdate);
        birthables.Add(birthable);
    } else if(type == "Pet")
    {
        string name = arguments[1];
        string birthdate = arguments[2];

        birthable = new Pet(name, birthdate);
        birthables.Add(birthable);
    }
}

string year = Console.ReadLine();

Console.WriteLine();

birthables
    .Where(birthables => birthables.Birthdate.Split("/")[2] == year)
    .ToList()
    .ForEach(birtable => Console.WriteLine(birtable.Birthdate));