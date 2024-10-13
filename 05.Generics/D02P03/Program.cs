int count = int.Parse(Console.ReadLine());

List<string> elements = new List<string>();

for (int i = 0; i < count; i++)
{
    int num = int.Parse(Console.ReadLine());

    elements.Add($"{num.GetType().FullName}: {num}");
}

List<int> indexes = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

int index1 = indexes[0];
int index2 = indexes[1];

SwapElements(elements, index1, index2);

Console.WriteLine(string.Join(Environment.NewLine, elements));

static void SwapElements<T>(List<T> values, int index1, int index2)
{
    T element = values[index1];
    values[index1] = values[index2];
    values[index2] = element;
}