using System;
using System.Collections.Generic;
using System.Text;

namespace CLearningApp
{
    public class Enterpreneur : Employee
    {
        private int agreementNumber;
        public Enterpreneur(string name, string email, string job, string title, float yearSalary, bool sex, int agreementNumber)
        {
            this.name = name;
            this.email = email;
            this.job = job;
            this.title = title;
            this.yearSalary = yearSalary;
            this.sex = sex;
            this.agreementNumber = agreementNumber;            
        }
        public Enterpreneur()
        {
        }

        public int GetAgreementNumber()
        {
            return agreementNumber;
        }

        public void SetAgreementNumber(int value)
        {            
            agreementNumber = value;            
        }        

        public string GetName()
        {
            return this.name;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public string GetJob()
        {
            return this.job;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public float GetYearSalary()
        {
            return this.yearSalary;
        }

        public bool GetSex()
        {
            return this.sex;
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
                Enterpreneur ent = (Enterpreneur)obj;
                return (name == ent.name) &&
                        (email == ent.email) &&
                        (job == ent.job) &&
                        (title == ent.title) &&
                        (yearSalary == ent.yearSalary) &&
                        (sex == ent.sex)&&
                        (agreementNumber == ent.agreementNumber);
            }
        }

        /*public override int GetHashCode()
        {
            return (name.GetHashCode(),
                email.GetHashCode(),
                job.GetHashCode(),
                title.GetHashCode(),
                yearSalary.GetHashCode(),
                sex.GetHashCode(),
                agreementNumber.GetHashCode());
        }*/

        public override string ToString()
        {
            return String.Format("Enterpreneur({0}, {1}, {2}, {3}, {4}, {5}, {6})", 
                name, email, job, title, yearSalary, sex, agreementNumber);
        }
    }
}