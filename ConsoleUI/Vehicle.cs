using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {

        public string Year { get; set; } = "2000";
        public  string Make  { get; set; } = "Ford";
        public string Model { get; set; } = "escort";


        public Vehicle()
        {
           
        }

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("real fast!");
        }
    }
}
