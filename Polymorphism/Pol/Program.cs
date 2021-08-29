using System;

namespace Pol
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.radius = 24;

            Rectangle rectangle = new Rectangle();
            rectangle.a = 2;
            rectangle.b = 5;

            PrintFguresArea(circle);
            PrintFguresArea(rectangle);
        }

        public static void PrintFguresArea(Figure f) 
        {
            Console.WriteLine(f.GetArea());
        }
    }
}
