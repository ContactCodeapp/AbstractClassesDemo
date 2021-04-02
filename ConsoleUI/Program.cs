using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var vechiles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            Car c1 = new Car()
            {
                Year = "1990",
                Make = "Ford",
                Model = "Thunder Bird Super Coup",
                Rims = "alloy"
            };


            MotorCycle bike1 = new MotorCycle()
            {
                Year = "2005",
                Make = "Harley Davidson",
                Model = "Fat Boy",
                HandleBars = "Big Boy",
            };

            Vehicle jeep = new Car()
            {
                Year = "2021",
                Make = "Jeep",
                Model = "Wrangler",
            };

            Vehicle suzuki = new MotorCycle()
            {
                Year = "2015",
                Make = "Suzuki",
                Model = "C900"
            };


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vechiles.Add(c1);
            vechiles.Add(bike1);
            vechiles.Add(jeep);
            vechiles.Add(suzuki);

            foreach (var vehicle in vechiles)
            {
                Console.WriteLine($"Year: {vehicle.Year}\n" +
                                  $"Make: {vehicle.Make}\n" +
                                  $"Model: {vehicle.Model}");

                Console.WriteLine("");
                
            }


            // Call each of the drive methods for one car and one motorcycle
            c1.DriveAbstract();
            suzuki.DriveVirtual();

            #endregion
            Console.ReadLine();
        }
    }
}
