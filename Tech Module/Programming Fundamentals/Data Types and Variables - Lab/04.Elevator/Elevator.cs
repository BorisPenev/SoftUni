using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorPeopleCapacity = int.Parse(Console.ReadLine());
            int elevatorTrips = 0;

            elevatorTrips = (int)Math.Ceiling((double)numberOfPeople / elevatorPeopleCapacity);
            Console.WriteLine(elevatorTrips);
        }
    }
}
