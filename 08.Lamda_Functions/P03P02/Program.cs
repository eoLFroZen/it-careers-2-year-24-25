List<int> nums = Console.ReadLine()
.Split()
.Select(int.Parse)
.ToList();

int k = nums.Count / 4;

int firstPartLength = k;
int middlePartLength = 2 * k;
int lastPartLength = k;

List<int> firstNums = nums
.Take(k)
.Reverse()
.ToList();

List<int> lastNums = ((IEnumerable<int>)nums)
.Reverse()
.Take(k)
.ToList();

List<int> firstList = firstNums.Concat(lastNums)
.ToList();

List<int> middle = nums
.Skip(k)
.Take(2 * k)
.ToList();

// List<int> result = new List<int>();

// for (int i = 0; i < middle.Count; i++)
// {
//     result.Add(firstList[i] + middle[i]);
// }

List<int> result = firstList
.Select((x, index) => x + middle[index])
.ToList();

Console.WriteLine(string.Join(" ", result));