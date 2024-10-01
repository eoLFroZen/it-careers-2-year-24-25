using D2P1.Define_Racional_Number;

int count = 3;

List<RacionalNumber> racionalNumbers = new List<RacionalNumber>();

for (int i = 0; i < count; i++)
{
    int numerator = int.Parse(Console.ReadLine());
    int denumerator = int.Parse(Console.ReadLine());

    RacionalNumber racionalNumber = new RacionalNumber(numerator, denumerator);

    racionalNumbers.Add(racionalNumber);
}

// with overriden ToString method in RactionalNumber class
//Console.WriteLine(string.Join(Environment.NewLine, racionalNumbers));

Console.WriteLine(string.Join(Environment.NewLine, racionalNumbers
    .Select(racionalNumber => $"{racionalNumber.Numerator}/{racionalNumber.Denumerator}")));

// without overriden ToString method in RactionalNumber class
//for (int i = 0; i < racionalNumbers.Count; i++)
//{
//    RacionalNumber racionalNumber = racionalNumbers[i];
//    Console.WriteLine($"{racionalNumber.Numerator}/{racionalNumber.Denumerator}");
//}