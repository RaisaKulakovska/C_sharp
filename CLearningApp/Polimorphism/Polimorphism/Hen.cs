using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphism
{
    class Hen : IBird, IPrintable
    {
        public void Move()
        {
            Console.WriteLine("I am a Hen, I can run");
        }

        public void Print()
        {
            
        }
    }
}