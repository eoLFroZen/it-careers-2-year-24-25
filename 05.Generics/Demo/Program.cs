using System.Collections;
using System.Runtime.CompilerServices;
using Demo;


ArrayList arrayList = new ArrayList();
arrayList.Add("1");
arrayList.Add("2");
arrayList.Add(3);

string el1 = (string) arrayList[0];
string el2 = (string) arrayList[1];
int el3 =  (int) arrayList[2];

Console.WriteLine(el1);
Console.WriteLine(el2);
Console.WriteLine(el3);

static List<T> CreateList<T>(T item, int count) {
  List<T> list = new List<T>();
  for (int i = 0; i < count; i++) 
  {
    list.Add(item);
  }
  return list;
}
