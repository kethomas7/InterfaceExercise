using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV:IVehicle,ICompany
    {
        public int NumberOfSeats { get; set; }
         public bool HasSlidingDoor { get; set; }

        public int NumberOfWheels { get; set; }
        public bool HasTrunk { get  ; set; }
        public int NumberOfDoors { get; set  ; }
        public string Color { get; set  ; }
        public string Address { get  ; set  ; }
        public string Name { get  ; set  ; }

        public void DisplayDetails()


        {
            Console.WriteLine($"This SUV is from the company {Name} located on {Address}.\nHere are more deatils:\nNumber of seats: {NumberOfSeats}\nNumber of wheels: {NumberOfWheels}\nColor: {Color}\nHas sliding doors: {HasSlidingDoor}\nHas a trunk: {HasTrunk}\nNumber of doors: {NumberOfDoors}\n");
        }
    }
}
