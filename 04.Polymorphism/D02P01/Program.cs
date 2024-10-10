using System;

namespace D02P01
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            Console.WriteLine(math.Add(2, 5));
            Console.WriteLine(math.Add(2.15, 5.12, 6.24));
            Console.WriteLine(math.Add(2.15m, 5.12m, 6.24m));
        }
    }
}
