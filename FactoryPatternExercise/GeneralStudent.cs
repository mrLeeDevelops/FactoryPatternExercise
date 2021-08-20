using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class GeneralStudent : IStudent
    {
        public void Announcement()
        {
            Console.WriteLine("I am a general student.");
        }
    }
}
