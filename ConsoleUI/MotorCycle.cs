using System;
namespace ConsoleUI
{
    public class MotorCycle : Vehicle
    {
       
        public string HandleBars { get; set; }


        public MotorCycle()
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
