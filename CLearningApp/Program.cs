using System;
using System.Collections.Generic;
using System.Text;

namespace CLearningApp
{
    public class Program : Employee
    {
        static void Main(string[] args)
        {
            //1 Employee
            Employee tom = new Employee("Tom", "tom@office.com", "Manager", "middle", 330000, true);            
            Employee tomas = new Employee("Tom", "tom@office.com", "Manager", "middle", 330000, true);            
            Employee ann = new Employee("Ann", "ann@office.com", "hr", "senior", 450000, false);            
            Employee t = new Employee("Tom", "tomas@office.com", "QA", "Junior", 150000, true); 

            Console.WriteLine(tom == tomas);
            Console.WriteLine(t == tomas);
            Console.WriteLine(tom);
            Console.WriteLine(tom.Equals(tomas));
            Console.WriteLine(t.Equals(tomas));
           
            tom.Print();
            ann.PrintAll();
            //Enterpreneur kat = new Enterpreneur("Kat", "ann@office.com", "hr", "senior", 450000, false);
        }
    }
}