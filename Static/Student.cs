using System;
using System.Collections.Generic;
using System.Text;

namespace Static
{
    class Student
    {
        protected string name;
        protected int studyYear;
        protected string faculty;
        protected string section;
        protected float grade;
        private static float id;

        public Student(string name, int studyYear, string faculty, string section, float grade)
        {
            this.name = name;
            this.studyYear = studyYear;
            this.faculty = faculty;
            this.section = section;
            this.grade = grade;
        }
        public Student()
        {
        }

        static Student()
        {
            id = 0;
        }

        public static float GetID()
        {
            return id++;
        }

        public string GetName()
        {
            return this.name;
        }

        public void PrintAll()
        {
            Console.WriteLine($"Name: {1}, StudyYear: {2}, Faculty: {3}, Section: {4}, Grade: {5}, Id: {6}", name, studyYear, faculty, section, grade, id);
        }

        public bool BetterStudent(Student s1) => this.grade>s1.grade ? true : false;  
        
        public static float CalculateTreeAvarageGrade(Student s1, Student s2, Student s3)
        {
            float averageGrade = (s1.grade + s2.grade + s3.grade) / 3;
            return averageGrade;
        }
    }
}