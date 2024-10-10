using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace D03P01
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            PrintArea(circle);
            PrintPerimeter(circle);

            Rectangle rectangle = new Rectangle(5, 6);
            PrintArea(rectangle);
            PrintPerimeter(rectangle);
        }

        static void PrintArea(Shape shape)
        {
            Console.WriteLine(shape.CalculateArea());
        }

        static void PrintPerimeter(Shape shape)
        {
            Console.WriteLine(shape.CalculatePerimeter());
        }
    }
}
