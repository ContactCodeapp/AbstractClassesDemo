using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {

       
        public string Rims { get; set; }

        public Car()
        {
           
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("Smooth");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("real fast!");
        }
    }
}
