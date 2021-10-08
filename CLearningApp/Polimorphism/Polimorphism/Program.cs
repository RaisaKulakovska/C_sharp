using System;

namespace Polimorphism
{
    class Program : BirdSkilsDemo
    {        
        static void Main(string[] args)
        {
            BirdSkilsDemo  birdSkilsDemo = new BirdSkilsDemo();
            Penguin petro = new Penguin("Petro", 2, "walk");
            Penguin penguinLord = new Penguin("Lord", 3, "walk");
            Hawk hawk = new Hawk();
            string havkName = hawk.GetType().Name;
            Hen hen = new Hen();

            BigPenguin bigLord = new BigPenguin("Lord", 2, 15);
            string ss = bigLord.name;
            birdSkilsDemo.ShowSkils(penguinLord);            
            birdSkilsDemo.ShowSkils(hawk);
            birdSkilsDemo.ShowSkils(hen);
            GetBird();
            penguinLord.GetInfo();
            bigLord.GetWeith();
        }
        static void GetBird() { }
    }
}