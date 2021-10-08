using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphism
{
    class BigPenguin : Penguin
    {
        public int weight;

        public BigPenguin(string name, int age, string move, int weight) : base(name, age, move)
        {            
            this.weight = weight;
        }

        public void GetWeith()
        {
            Console.WriteLine($"Weight: {weight}");
        }
    }
}
