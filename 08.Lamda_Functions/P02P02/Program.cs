// List<int> nums = Console.ReadLine()
//     .Split()
//     .Select(int.Parse)
//     .ToList();


// IEnumerable<int> biggestThreeNums = nums
//     .OrderByDescending(n => n)
//     .Take(3);

// Console.WriteLine(string.Join(", ", biggestThreeNums));


Console.WriteLine(string.Join(", ", Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .OrderByDescending(n => n)
    .Take(3)));