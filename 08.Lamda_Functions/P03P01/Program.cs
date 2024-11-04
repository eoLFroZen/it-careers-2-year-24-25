List<string> words = Console.ReadLine().ToLower()
.Split(new char[] {'.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '/', '\\', '!', '?', ' '}, StringSplitOptions.RemoveEmptyEntries)
.Where(word => word.Length < 5)
.OrderBy(x => x)
.Distinct()
.ToList();

Console.WriteLine(string.Join(", ", words));