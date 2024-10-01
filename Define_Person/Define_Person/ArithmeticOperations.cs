using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_Person
{
    public static class ArithmeticOperations
    {
        
        static ArithmeticOperations()
        {
            Person.StaticMethod();
            Console.WriteLine("test");
        }
        public static long Add(int a, int b)
        {
            return (long)a + b;
        }

        public  static long Multiply(int a, int b)
        {
            return (long)a * b;
        }
    }
}
