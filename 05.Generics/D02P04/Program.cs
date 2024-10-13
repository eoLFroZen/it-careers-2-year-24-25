using D02P04;

int count = int.Parse(Console.ReadLine());
List<Box<string>> boxes = new List<Box<string>>();

for (int i = 0; i < count; i++)
{
    string input = Console.ReadLine();

    Box<string> box = new Box<string>(input);

    boxes.Add(box);
}

string element = Console.ReadLine();
Box<string> boxElement = new Box<string>(element);

Console.WriteLine(GetBiggerElements(boxes, boxElement));


static int GetBiggerElements<T>(List<T> data, T element) where T : IComparable<T>
{
    int count = 0;

    data.ForEach(box => 
    {
        if(box.CompareTo(element)> 0)
        {
            count++;
        }
    });

    return count;
}