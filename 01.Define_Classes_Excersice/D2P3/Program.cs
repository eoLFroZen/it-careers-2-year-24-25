using D2P3;

List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<RacionalNumber> racionalNumbers = new List<RacionalNumber>();

for (int i = 0; i < numbers.Count; i += 2)
{
    int numerator = numbers[i];
    int denominator = numbers[i + 1];

    int biggestDevider = BiggestDevider(numerator, denominator);

    RacionalNumber racionalNumber = new RacionalNumber(numerator/biggestDevider, denominator/biggestDevider);

    racionalNumbers.Add(racionalNumber);
}

Console.WriteLine(string.Join("; ", racionalNumbers
    .Select(racionalNumber => $"{racionalNumber.Numerator}/{racionalNumber.Denumerator}")));


// 25/100
static int BiggestDevider(int numerator, int denumerator)
{
    int minValue = Math.Min(numerator, denumerator);

    for (int i = minValue; i > 0; i--)
    {
        if (numerator % i == 0 && denumerator % i == 0)
        {
            return i;
        }
    }

    return 1;
}