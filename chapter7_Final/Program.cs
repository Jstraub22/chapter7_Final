using System;
using System.Collections.Generic;

namespace chapter7_Final
{
    class Rocketleague
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats up brother!!");
            System.Console.WriteLine("Hello");
            System.Console.WriteLine("Jacob_Straub!");
            {
                System.Console.WriteLine(36 / 6);
            }

            {
                System.Console.WriteLine(15 + 17);
            }




        }
       

        public string CohortName { get; set; }
        public string Cohortname { get; set; }

        private List<student> students;
        private string cohortname;

        private List<student> Students { get; set; }

        public Rocketleague(string cohortname)
        {
            Cohortname = cohortname;
            students = new List<student>();
            instructor = new list<Instructor>();




        }

        public void Addstudent(Student newStudent)
        {
            newStudent.Cohort = this;
            Students.Add(newStudent);
        

        
        
            




        

        
        
            NewStudent.Cohort = this;
            Students.Add(NewStudent);
        }

        











    }

    internal class list<T>
    {
        public list()
        {
        }
    }

    internal class student
    {
    }
}


