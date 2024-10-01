using D05P01;
using System.Reflection;

Type personInterface = typeof(Citizen).GetInterface("IPerson");
PropertyInfo[] properties = personInterface.GetProperties();
string name = Console.ReadLine();   
int age = int.Parse(Console.ReadLine());
Citizen person = new Citizen(name, age);
Console.WriteLine();
Console.WriteLine(properties.Length);
Console.WriteLine(person.Name);
Console.WriteLine(person.Age);