using System.Reflection;
using Demo;

Type bookType = typeof(Book);

FieldInfo? fieldInfo = bookType.GetField("privateField", BindingFlags.Instance | BindingFlags.NonPublic);

FieldInfo[] fieldInfos  = bookType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
PropertyInfo[] propertyInfos = bookType.GetProperties();
ConstructorInfo[] constructorInfos = bookType.GetConstructors();
MethodInfo[] methodInfos = bookType.GetMethods(BindingFlags.Static | BindingFlags.NonPublic);

Book book = (Book)constructorInfos[0].Invoke(new object[]{});
Book book2 = (Book) Activator.CreateInstance(bookType,  "Title");

FieldInfo privateFieldInfo = fieldInfos.First(x => x.Name == "privateField");
privateFieldInfo.SetValue(book, 15);

PropertyInfo titlePropertyInfo = propertyInfos.First(x=> x.Name == "Title");
titlePropertyInfo.SetValue(book, "Title");

methodInfos[0].Invoke(book, new object[] {});


Console.WriteLine();

// Type.GetType("Demo.Book");