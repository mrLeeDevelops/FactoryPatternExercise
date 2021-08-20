using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public static class StudentFactory
    {
        public static IStudent GetStudent(int numberOfClasses)
        {
            IStudent answer = null;
            switch (numberOfClasses)
            {
                case 4:
                    answer = new Elementary();
                    answer.Announcement();
                    break;
                case 6:
                    answer =  new JuniorHigh();
                    answer.Announcement();
                    break;
                case 8:
                    answer =  new SeniorHigh();
                    answer.Announcement();
                    break;
                default:
                    answer = new GeneralStudent();
                    answer.Announcement();
                    break;
            }
            return answer;

        }
    }
}
