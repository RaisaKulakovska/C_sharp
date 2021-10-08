using System;

namespace Static
{
    class Program 
    {
        static void Main(string[] args)
        {
            Student piter = new Student("Piter", 1, "economy", "box", 135);
            Student bob = new Student("Bob", 4, "Lingvistic", "swimming", 160);
            Student ann = new Student("Ann", 2, "Teacher", "music", 167);
            Student john = new Student("John", 3, "IT", "chess", 199);

            piter.PrintAll();

            void Comparer(Student a, Student b)
            {
                if (a.BetterStudent(b))
                {
                    Console.WriteLine($"Student {a.GetName()} better student than student {b.GetName()}");
                }
                else
                {
                    Console.WriteLine($"Student {a.GetName()} not better student than student {b.GetName()}");
                }
            }            

            void NamesOperations(Student a, Student b)
            {
                string piterName = piter.GetName();
                string annName = ann.GetName();
                string bobName = bob.GetName();

                string firstGroup = piterName + ", " + annName;
                string goodStudent = String.Concat(annName, " is good student!");
                string[] names = new string[] { piterName, annName, bobName };
                string listNames = String.Join(" ", names);
                

                void NameLenthComparer(Student a, Student b)                    
                {
                    int result = String.Compare(a.GetName(), b.GetName());
                    if (result < 0)
                    {
                        Console.WriteLine($"name {a.GetName()} is shorter than name {b.GetName()}");
                    }
                    else
                    {
                        Console.WriteLine($"name {a.GetName()} is not shorter than name {b.GetName()}");
                    }
                }
                Console.WriteLine($"{piterName.IndexOf('r')}");
                Console.WriteLine($"{piterName.ToUpper()}");
                Console.WriteLine($"{bobName.Replace("b", "bik")}");
                Console.WriteLine($"{piterName.Trim(new char[] { 'P', 'r' })}");
            }
        }
    }
}