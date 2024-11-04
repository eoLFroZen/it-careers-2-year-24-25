// List<int> nums = Console.ReadLine()
//     .Split(", ")
//     .Select(int.Parse)
//     .ToList();

// List<int> orderedEvenNums = nums
//     .Where(num => num % 2 == 0)
//     .OrderBy(num => num)
//     .ToList();

// Console.WriteLine(string.Join(", ", orderedEvenNums));


Console.WriteLine(string.Join(", ", Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .Where(num => num % 2 == 0)
    .OrderBy(num => num)));



int minValue = int.MaxValue;

foreach (int a in Console.ReadLine()
    .Split(", ")
    .Select(int.Parse))
    {
        if(a < minValue)
        {
            minValue = a;
        }
    }











