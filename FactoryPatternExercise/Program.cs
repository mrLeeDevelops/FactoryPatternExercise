using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create a new console app that utilizes factory pattern by taking a user’s input of how many tires 
             * are on a vehicle and based on their input, creates that type of vehicle. Complete this using an interface.
             * You must have at least 2 subclasses. For instance, if I type 4 into the console, the program would create
             * a car or truck, or if someone types 2 it would create a motorcycle. 
             * Feel free to use something other than vehicles if you want to be creative, but the other constraints still apply!

            * Possible steps:
            * 
            * 1. DONE--Create an Interface named IVehicle that has a stubbed out public void Drive method
            * 2. DONE--Create 2 new public classes that will conform to IVehicle
            * Example) Car, Motorcycle,  BigRig
            * 3. DONE--These classes must conform to IVehicle and implement the Drive() method - which will just
            * Console.WriteLine(“Building a new Car!”)
            * 4. DONE--Now we will make our static VehicleFactory class
            * 5. DONE--It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of
            * tires it’s given as a parameter
            * 6. DONE--Call this functionality in the Main method
            */
            Console.WriteLine("Enter the number of Classes for your student: 4, 6, or 8.");
            int classes = int.Parse(Console.ReadLine());
            StudentFactory.GetStudent(classes);

        }
    }
}
