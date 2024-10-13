using D01P04;

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    int num = int.Parse(Console.ReadLine());

    Box<int> box = new Box<int>(num);

    Console.WriteLine(box);
}