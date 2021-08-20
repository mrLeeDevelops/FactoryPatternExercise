using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class SeniorHigh : IStudent
    {
        public int NumberOfClasses = 8; 
        public string Classification = "Senior High";
        public void Announcement()
        {
            Console.WriteLine($"I am a {Classification} student, and I have {NumberOfClasses} classes.");
        }
    }
}
