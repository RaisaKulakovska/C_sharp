using System;
using System.Collections.Generic;
using System.Text;

namespace CLearningApp
{
    public class Program : Employee
    {
        static void Main(string[] args)
        {
            // Employees:
            Employee tom = new Employee("Tom", "tom@office.com", "Manager", "middle", 330000, true);            
            Employee tomas = new Employee("Tom", "tom@office.com", "Manager", "middle", 330000, true);            
            Employee ann = new Employee("Ann", "ann@office.com", "hr", "senior", 450000, false);            
            Employee t = new Employee("Tom", "tomas@office.com", "QA", "Junior", 150000, true);

            Console.WriteLine(tom);
            tom.Print();
            ann.PrintAll();
            Console.WriteLine(tom == tomas);
            Console.WriteLine(t == tomas);   
            Console.WriteLine(t.Equals(tomas));
            Console.WriteLine(tom.Equals(tomas));
            
            Enterpreneur kat = new Enterpreneur("Kat", "kat@office.com", "hr", "senior", 450000, false, 15530);
            Enterpreneur kat1 = new Enterpreneur("Kat1", "kat@office.com", "hr", "senior", 450000, false, 15530);
            Enterpreneur nick = new Enterpreneur("Nick", "nick@office.com", ".Net", "tranee", 170000, false, 16531);

            kat.Print();

            // Object's methods: ToString, GetHeshCode, GetType, Equals
            Console.WriteLine("Kat vs Kat1: "+ kat.Equals(kat1));
            Console.WriteLine(kat.Equals(nick));
            Console.WriteLine(kat.ToString());
            Console.WriteLine(kat.GetName());            
            Console.WriteLine(nick.GetHashCode()); 
            Console.WriteLine(kat1.GetType()); 
        }
    }
}