using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class JuniorHigh : IStudent
    {
        public int NumberOfClasses = 6;
        public string Classification = "Junior High";
        public void Announcement()
        {
            Console.WriteLine($"I am a {Classification} student, and I have {NumberOfClasses} classes.");
        }
    }
}
