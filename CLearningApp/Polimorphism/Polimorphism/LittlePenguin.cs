using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphism
{
    class LittlePenguin : Penguin
    {
        public string color;

        public LittlePenguin(string name, int age, string color) : base(name, age, move)
        {
            this.color = color;
        }

        public void GetColor()
        {
            Console.WriteLine($"Color: {color}");
        }
    }
}