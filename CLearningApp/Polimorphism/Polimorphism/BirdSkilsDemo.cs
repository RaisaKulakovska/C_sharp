using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphism
{
    public class BirdSkilsDemo
    {
        public void ShowSkils(IBird bird)
        {            
            bird.Move();
        }
    }
}