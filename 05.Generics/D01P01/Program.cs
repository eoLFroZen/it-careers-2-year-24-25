using D01P01;

Box<string> strings = new Box<string>();

strings.Add("element one");
strings.Add("element two");
strings.Add("element three");

Console.WriteLine(strings.Count);
Console.WriteLine(strings.Remove());
Console.WriteLine(strings.Remove());
Console.WriteLine(strings.Remove());
Console.WriteLine(strings.Remove());

Box<int> ints = new Box<int>();

ints.Add(1);
ints.Add(2);
ints.Add(3);
ints.Add(4);

Console.WriteLine(ints.Remove());

