using System;
using System.Xml.Schema;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany-Done

            //Create 3 classes called Car , Truck , & SUV-Done

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.-Done
             * Example: public int NumberOfWheels { get; set; }-Done
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company-DONE
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class-DONE
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.-Done
             */

            //Now, create objects of your 3 classes and give their members values.

            var Truck1 = new Truck()
            {
                CanTow = true,
                Flatbed = true,
                NumberOfDoors = 4,
                HasTrunk = false,
                Color = "Red",
                Name="Honda",
                Address="109 Southside Street",
                NumberOfWheels =4
            
            };
  
            var Car1 = new Car()
            {
                HasSunRoof =true,
                HasTrunk=true,
                HasChargingPort=true,
                NumberOfDoors=2,
                NumberOfWheels=4,
                Name="Mercedez",
                Address= "768 Updown Street",
                Color = "Green"

            };
           

            var SUV1 = new SUV() 
            { 
                NumberOfWheels =4,
                NumberOfDoors=4,
                NumberOfSeats=6,
                Color = "White",
                HasTrunk=true,
                HasSlidingDoor =true,
                Name = "Range Rover",
                Address = "123 Left Right Street"
            };

            SUV1.DisplayDetails();
            Truck1.DisplayDetails(); 
            Car1.DisplayDetails();

            //Creatively display and organize their values
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.-done
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.-done
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        }
    }
}
