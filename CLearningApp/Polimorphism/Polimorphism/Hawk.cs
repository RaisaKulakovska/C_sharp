using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphism
{
    class Hawk : IBird
    {   
        public void Move()
        {
            Console.WriteLine("I am a Hawk I can fly");
        }

        public Hawk()
        {
        }

        public void Hunt()
        {
            Console.WriteLine("I am flying hunter");
        }

        public void Print()
        {
            Console.WriteLine("I am a ...");
        }
    }
}