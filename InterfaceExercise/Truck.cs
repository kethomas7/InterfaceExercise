using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck:IVehicle,ICompany
    {

        public bool Flatbed { get; set; }
        public bool CanTow { get; set; }

        public int NumberOfWheels { get; set; }
        public bool HasTrunk { get; set; }
        public int NumberOfDoors { get; set; }
        public string Color { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }


        public void DisplayDetails()
        {

            Console.WriteLine($"This truck is from the company {Name} located on {Address}.\nHere are more deatils:\nDoes it have a flatbed: {Flatbed}\nNumber of wheels: {NumberOfWheels}\nColor: {Color}\nCan it tow: {CanTow}\nHas a trunk: {HasTrunk}\nNumber of doors: {NumberOfDoors}\n");
        }
    }
}
