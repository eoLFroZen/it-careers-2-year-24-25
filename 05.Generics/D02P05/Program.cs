using D02P05;

int count = int.Parse(Console.ReadLine());
List<Box<double>> boxes = new List<Box<double>>();

for (int i = 0; i < count; i++)
{
    double num = double.Parse(Console.ReadLine());

    Box<double> box = new Box<double>(num);

    boxes.Add(box);
}

double element = double.Parse(Console.ReadLine());
Box<double> boxElement = new Box<double>(element);

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