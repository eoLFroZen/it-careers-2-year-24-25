Func<int, string> func = x => x.ToString();
Func<int, bool> func2 = x => x > 10;


string result = func.Invoke(5);

Console.WriteLine(result is string);
Console.WriteLine(result);

Action<string> helloAction = (msg) => Console.WriteLine(msg);
Predicate<int> predicate = (num) => num > 5;

helloAction.Invoke("Hi");
