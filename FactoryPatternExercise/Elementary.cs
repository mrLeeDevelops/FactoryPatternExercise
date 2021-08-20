using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Elementary : IStudent
    {
        public int NumberOfClasses = 4;
        public string Classification = "Elementary";
        public void Announcement()
        {
            Console.WriteLine($"I am a {Classification} student, and I have {NumberOfClasses} classes.");
        }
    }
}
