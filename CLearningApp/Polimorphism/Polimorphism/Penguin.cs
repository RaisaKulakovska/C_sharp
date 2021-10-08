using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphism
{
    class Penguin : IBird, IPredator
    {
        public string name;
        public int age;
        public string move;


        //public Penguin() { name = "Unknown"; age = 2; }      // 1 конструктор

        //  public Penguin(string n) { name = n; age = 2; }    // 2 конструктор

        
        public Penguin(string n, int a, string m) 
        {
            name = n; 
            age = a;
            move = m; 
        }   
        
        /*public Penguin(string n, int a)
            {
                this.name = n;
                this.age = a;
            }*/

        public void GetInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
        public void Move()
        {
            Console.WriteLine($"I am a {this.GetType().Name}, I can {move}");
        }

        public void Hunt()
        {
            Console.WriteLine("I am swiming hunter");
        }
    }
}
