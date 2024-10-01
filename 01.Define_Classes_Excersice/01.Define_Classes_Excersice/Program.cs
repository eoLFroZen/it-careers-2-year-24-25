using _01.Define_Classes_Excersice;
using System.Reflection;

Type personType = typeof(Person);
FieldInfo[] fields = personType.GetFields(BindingFlags.Instance | BindingFlags.Public);
Console.WriteLine(fields.Length);

Person person = new Person();
person.name = "Pesho";
person.age = 20;

Console.WriteLine(person);

Person person2 = new Person();
person2.name = "Gosho";
person2.age = 18;

Console.WriteLine(person2);

Person person3 = new Person();
person3.name = "Stamat";
person3.age = 43;

Console.WriteLine(person3);