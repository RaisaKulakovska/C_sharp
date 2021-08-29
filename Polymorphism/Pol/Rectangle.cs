namespace Pol
{
    public class Square : Figure
    {
        public double a;
        public double b;

        public override double GetArea()
        {
            return a * b;
        }
    }
}
