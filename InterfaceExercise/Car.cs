using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car:IVehicle,ICompany
    {
        public bool HasSunRoof { get; set; }
        public bool HasChargingPort { get; set; }

        public int NumberOfWheels { get; set; }
        public bool HasTrunk { get; set; }
        public int NumberOfDoors { get; set; }
        public string Color { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }

        public void DisplayDetails()
        {

            Console.WriteLine($"This car is from the company {Name} located on {Address}.\nHere are more deatils:\nHas a charging port: {HasChargingPort}\nNumber of wheels: {NumberOfWheels}\nColor: {Color}\nHas a sunroof: {HasSunRoof}\nHas a trunk: {HasTrunk}\nNumber of doors: {NumberOfDoors}\n");
            

        }
    }
}
