using D2P2.Define_Racional_Number_2;

List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<RacionalNumber> racionalNumbers = new List<RacionalNumber>();

for (int i = 0; i < numbers.Count; i+=2)
{
    int numerator = numbers[i];
    int denominator = numbers[i+1];

    RacionalNumber racionalNumber = new RacionalNumber(numerator, denominator);

    racionalNumbers.Add(racionalNumber);
}

//Console.WriteLine(string.Join("; ", racionalNumbers
//    .Select(racionalNumber => $"{racionalNumber.Numerator}/{racionalNumber.Denumerator}")));

for (int i = 0; i < racionalNumbers.Count; i++)
{
    RacionalNumber racionalNumber = racionalNumbers[i];

    Console.Write($"{racionalNumber.Numerator}/{racionalNumber.Denumerator}");

    if (i != racionalNumbers.Count - 1)
    {
        Console.Write("; ");
    }
}

Console.WriteLine();