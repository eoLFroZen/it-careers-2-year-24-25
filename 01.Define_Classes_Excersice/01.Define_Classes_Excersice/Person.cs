namespace _01.Define_Classes_Excersice
{
    public class Person
    {
        public string name;
        public int age;

        public override string ToString()
        {
            return $"{name} is {age} years old.";
        }
    }
}
