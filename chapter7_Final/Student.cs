using System;
using System.Collections.Generic;
using System.Text;

namespace chapter7_Final
{
    class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public List<Exericse> Assignments { get; }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Assignments = new List<Exericse>();


        }

        
        
        private string SlackHandle { get; }
        public Cohort Cohort { get; set; }
        



    }

    
}
