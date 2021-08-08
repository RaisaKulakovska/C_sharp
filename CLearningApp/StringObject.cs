using System;
using System.Collections.Generic;
using System.Text;

namespace CLearningApp
{    
    public class Employee
    {
        public string name;
        public string email;
        public string job;
        public string title;
        public float yearSalary;
        public bool sex; //true if male, false if female

        private float countMonthSalary()
        {
            return yearSalary / 12;
        }

        //Print Name, Email, Sex
        private void print()
        {
            Console.WriteLine($"Name: {1}, Email: {2}, Sex: {3}", name, email, sex);
        }

        //Print all fields: name, email, job, title, year salary, sex
        private void printAll()
        {
            Console.WriteLine($"Name: {1}, Email: {2}, Job: {3}, Title: {4}, Year salary: {5}, Sex: {6}", name, email, job, title, yearSalary, sex);
        }
    }
    public class Program1
    {
        static void Main(string[] args)
        {
            //1 Employee
            Employee tom = new Employee();
            tom.name = "Tom";
            tom.email = "tom@office.com";
            tom.job = "Manager";
            tom.title = "middle";
            tom.yearSalary = 330000;
            tom.sex = true;

            //2 Employee
            Employee tomas = new Employee();
            tomas.name = "Tom";
            tomas.email = "tomas@office.com";
            tomas.job = "QA";
            tomas.title = "junior";
            tomas.yearSalary = 150000;
            tomas.sex = true;

            //3 Employee
            Employee ann = new Employee();
            ann.name = "Ann";
            ann.email = "ann@office.com";
            ann.job = "hr";
            ann.title = "senior";
            ann.yearSalary = 450000;
            ann.sex = false;

            Console.WriteLine("tom == tomas: ", tom == tomas);
            Console.WriteLine("tom Equals tomas: ", tom.Equals(tomas));
        }

        //4 Employee - enterpreneur
        public class Enterpreneur : Employee
        {            
            public string agreementNumber { get; private set; }
            Enterpreneur enterpreneur1 = new Enterpreneur();
            Enterpreneur enterpreneur2 = new Enterpreneur();
        }
    }
}