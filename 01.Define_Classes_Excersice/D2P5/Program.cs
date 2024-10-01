using D2P5;

List<EvenNumber> evenNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .Where(num => num % 2 == 0)
    .Select(num => new EvenNumber(num))
    .ToList();

//List<EvenNumber> evenNumbers = new List<EvenNumber>();

//for (int i = 0; i < numbers.Count; i++)
//{
//    int num = numbers[i];

//    if (num % 2 == 0)
//    {
//        EvenNumber evenNumber = new EvenNumber(num);

//        evenNumbers.Add(evenNumber);
//    }
//}

Console.WriteLine(string.Join(", ", evenNumbers
    .Select(evenNum => evenNum.Number)));
