using D01P03;

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string input = Console.ReadLine();

    Box<string> box = new Box<string>(input);

    Console.WriteLine(box);
}