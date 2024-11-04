string text = Console.ReadLine();

// Predicate<string> startsWithUpperLetter = str => str[0] > 64 && str[0] < 91;
Func<string, bool> startsWithUpperLetter = str => str[0] > 64 && str[0] < 91;

string[] wordsWithUpperLetter = text
.Split()
.Where(startsWithUpperLetter)
.ToArray();

Console.WriteLine(string.Join(Environment.NewLine, wordsWithUpperLetter));