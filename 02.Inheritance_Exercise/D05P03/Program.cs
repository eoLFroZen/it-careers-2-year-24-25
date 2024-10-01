using D05P03;

List<string> phoneNumbers = Console.ReadLine()
    .Split()
    .ToList();

List<string> webSites = Console.ReadLine()
    .Split()
    .ToList();

Smartphone smartphone = new Smartphone(phoneNumbers, webSites);

smartphone.CallNumbers();
smartphone.Browse();