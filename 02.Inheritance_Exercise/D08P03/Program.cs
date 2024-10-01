using D08P03;

int peopleCount = int.Parse(Console.ReadLine());

List<Citizen> citizens = new List<Citizen>();
List<Rebel> rebels = new List<Rebel>();

for (int i = 0; i < peopleCount; i++)
{
    List<string> arguments = Console.ReadLine()
        .Split()
        .ToList();

    string name = arguments[0];
    int age = int.Parse(arguments[1]);

    if (arguments.Count == 3)
    {
        string group = arguments[2];

        rebels.Add(new Rebel(name, age, group));
    }
    else if (arguments.Count == 4)
    {
        string id = arguments[2];
        string birthdate = arguments[3];

        citizens.Add(new Citizen(id, name, age, birthdate));
    }
}

string input;

while ((input = Console.ReadLine()) != "End")
{
    string name = input;

    Citizen citizen = citizens.Find(c => c.Name == name);

    if (citizen != null)
    {
        citizen.BuyFood();
        continue;
    }

    Rebel rebel = rebels.Find(r => r.Name == name);

    if (rebel != null)
    {
        rebel.BuyFood();
    }
}

int food = 0;

// Same as below but longer version!!!
//for (int i = 0; i < citizens.Count; i++)
//{
//    Citizen citizen = citizens[i];

//    food += citizen.Food;
//}
    
citizens.ForEach(c => food += c.Food);
rebels.ForEach(r => food += r.Food);

Console.WriteLine();
Console.WriteLine(food);