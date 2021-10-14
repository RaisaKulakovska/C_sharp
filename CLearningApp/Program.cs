using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CLearningApp
{
    public class Program : Employee
    {
        static void Main(string[] args)
        {
            // Employees:
            Employee tom = new Employee("Tom", "tom@office.com", "Manager", "middle", 330000, true);            
            Employee tomas = new Employee("Tomas", "tomas@office.com", "Manager", "middle", 330000, true);            
            Employee ann = new Employee("Ann", "ann@office.com", "hr", "senior", 450000, false);            
            Employee t = new Employee("t", "tomas@office.com", "QA", "Junior", 150000, true);

            Console.WriteLine(tom);
            tom.Print();
            ann.PrintAll();
            Console.WriteLine(tom == tomas);
            Console.WriteLine(t == tomas);   
            Console.WriteLine(t.Equals(tomas));
            Console.WriteLine(tom.Equals(tomas));
            
            Enterpreneur kat = new Enterpreneur("Kat", "kat@office.com", "hr", "senior", 450000, false, 15530);
            Enterpreneur bob = new Enterpreneur("Bob", "kat@office.com", "hr", "senior", 450000, false, 15530);
            Enterpreneur nick = new Enterpreneur("Nick", "nick@office.com", ".Net", "tranee", 170000, false, 16531);

            kat.Print();

            // Object's methods: ToString, GetHeshCode, GetType, Equals
            Console.WriteLine("Kat vs Bob: "+ kat.Equals(bob));
            Console.WriteLine(kat.Equals(nick));
            Console.WriteLine(kat.ToString());
            Console.WriteLine(kat.GetName());            
            Console.WriteLine(nick.GetHashCode()); 
            Console.WriteLine(bob.GetType());

            //Collections
            var emps = new List<Employee> { kat, nick, bob };
            foreach (var emp in emps)
            {
                Console.WriteLine($"Hello {emp.GetName().ToUpper()}!");
            }

            var employees = new Dictionary<string, string>
            {
                [kat.GetName()] = kat.GetEmail(),
                [nick.GetName()] = nick.GetEmail(),
                [bob.GetName()] = bob.GetEmail()
            };

            employees.Add("Mike", "mike@oficce.com");
            var nickName = employees[nick.GetName()];

            foreach (KeyValuePair<string, string> keyValue in employees)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }            

            WriteCSV(kat);
            WriteCSV(nick);
            Enterpreneur kat2 = ReadCSV();
            Console.WriteLine(kat2);
        }

        public const string FilePath = @"C:\CSVFiles\test.csv";        

        public static void WriteCSV(Enterpreneur ent)
        {
            var file = File.OpenWrite(FilePath);
            StreamWriter fileStream = new StreamWriter(file);
            fileStream.WriteLine($"{ent.GetName()}, {ent.GetJob()}, {ent.GetEmail()}");
            fileStream.Flush();
            fileStream.Close();
            file.Close();
        }        

        public static Enterpreneur ReadCSV()
        {
            var file = File.OpenRead(FilePath);
            StreamReader fileStream = new StreamReader(file);
            var textLine = fileStream.ReadLine();
            var lineCollection = textLine.Split(new[] {','});
            var name = lineCollection[0].Trim();
            var job = lineCollection[1].Trim();
            var email = lineCollection[2].Trim();
            fileStream.Close();
            file.Close();
            return new Enterpreneur(name, email, job, "senior", 450000, false, 15530);
        }
    }
}