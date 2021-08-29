using System;

namespace Pol
{
    public class Circle : Figure
    {
        public double radius;
        private const double PI = 3.1416;

        public override double GetArea()
        {
            return 2 * PI * radius;        
        }
    }
}
