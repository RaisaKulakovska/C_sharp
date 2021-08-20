using System;
using System.Collections.Generic;
using System.Text;

namespace CLearningApp
{
    public class Employee
    {
        protected string name;
        protected string email;
        protected string job;
        protected string title;
        protected float yearSalary;
        protected bool sex; //true if male, false if female

        public Employee(string name, string email, string job, string title, float yearSalary, bool sex)
        {
            this.name = name;
            this.email = email;
            this.job = job;
            this.title = title;
            this.yearSalary = yearSalary;
            this.sex = sex;
        }
        public Employee()
        {
        }
        protected float countMonthSalary()
        {
            return yearSalary / 12;
        }

        //Print Name, Email, Sex
        public void Print()
        {
            Console.WriteLine($"Name: {name}, Email: {email}, Sex: {sex}");
        }

        //Print all fields: name, email, job, title, year salary, sex
        public void PrintAll()
        {
            Console.WriteLine($"Name: {1}, Email: {2}, Job: {3}, Title: {4}, Year salary: {5}, Sex: {6}", name, email, job, title, yearSalary, sex);
        }

        public override bool Equals(Object obj)
        {
            // Check for null and compare run - time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Employee emp = (Employee)obj;
                return (name == emp.name) &&
                        (email == emp.email) &&
                        (job == emp.job) &&
                        (title == emp.title) &&
                        (yearSalary == emp.yearSalary) &&
                        (sex == emp.sex);
            }
        }
    }
}