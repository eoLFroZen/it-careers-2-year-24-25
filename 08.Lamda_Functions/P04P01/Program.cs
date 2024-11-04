Func<string, int> parser = str => int.Parse(str);

Action<List<int>> printCount = collection => Console.WriteLine(collection.Count);

Func<List<int>, long> sum = colelction => 
{
    long result = 0;

    foreach(int num in colelction)
    {
        result += num;
    }

    return result;
};

List<int> nums = Console.ReadLine()
.Split(", ")
.Select(parser)
.ToList();

printCount(nums);
Console.WriteLine(sum(nums));