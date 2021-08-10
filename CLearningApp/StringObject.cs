using System;
using System.Collections.Generic;
using System.Text;

namespace CLearningApp
{    
    public class Employee
    {
        public string Name;
        public string Email;
        public string Job;
        public string Title;
        public float YearSalary;
        public bool Sex; //true if male, false if female

        protected float countMonthSalary()
        {
            return YearSalary / 12;
        }

        //Print Name, Email, Sex
        public void print()
        {
            Console.WriteLine($"Name: {1}, Email: {2}, Sex: {3}", Name, Email, Sex);
        }

        //Print all fields: name, email, job, title, year salary, sex
        public void printAll()
        {
            Console.WriteLine($"Name: {1}, Email: {2}, Job: {3}, Title: {4}, Year salary: {5}, Sex: {6}", Name, Email, Job, Title, YearSalary, Sex);
        }
    }
    public class Program1
    {
        static void Main(string[] args)
        {
            //1 Employee
            Employee tom = new Employee();
            tom.Name = "Tom";
            tom.Email = "tom@office.com";
            tom.Job = "Manager";
            tom.Title = "middle";
            tom.YearSalary = 330000;
            tom.Sex = true;

            //2 Employee
            Employee tomas = new Employee();
            tomas.Name = "Tom";
            tomas.Email = "tomas@office.com";
            tomas.Job = "QA";
            tomas.Title = "junior";
            tomas.YearSalary = 150000;
            tomas.Sex = true;

            //3 Employee
            Employee ann = new Employee();
            ann.Name = "Ann";
            ann.Email = "ann@office.com";
            ann.Job = "hr";
            ann.Title = "senior";
            ann.YearSalary = 450000;
            ann.Sex = false;

            Console.WriteLine("tom == tomas: ", tom == tomas);
            Console.WriteLine("tom Equals tomas: ", tom.Equals(tomas));

            tom.print();
            ann.printAll();
        }
        //Object's methods: ToString, GetHeshCode, GetType, Equals
        public class Enterpreneur : Employee
        {
            public string agreementNumber { get; private set; }

            Enterpreneur enterprNick = new Enterpreneur();
            public float nickSalary = enterprNick.YearSalary;
            nickSalary = 500000;
            Console.WriteLine(nickSalary.ToString());
            Console.WriteLine(enterprNick.ToString());

            Enterpreneur enterprMike = new Enterpreneur();
            enterprMike.Name = "Mike";

            enterprMike.GetType();
        }
    }        
}