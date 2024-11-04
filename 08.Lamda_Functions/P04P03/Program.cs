Func<decimal, decimal> addVat = num => Math.Round(num *= 1.2m, 2);

List<decimal> prices = Console.ReadLine()
.Split(", ")
.Select(decimal.Parse)
.Select(addVat)
.ToList();

Console.WriteLine("with VAT prices");
Console.WriteLine(string.Join(Environment.NewLine, prices));