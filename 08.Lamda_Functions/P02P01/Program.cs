﻿int n = int.Parse(Console.ReadLine());
List<int> nums = new List<int>();

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());

    nums.Add(num);
}

Console.WriteLine($"Sum: {nums.Sum()}");
Console.WriteLine($"Min: {nums.Min()}");
Console.WriteLine($"Max: {nums.Max()}");
Console.WriteLine($"Average: {nums.Average()}");