using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_III_Group1_Group_Project
{
    public class Plane
    {
        public string planeName { get; set; }
        public string pilotFirstName { get; set; }
        public string pilotLastName { get; set; }
        public int planeCapacity { get; set; }
        public string startingLocation { get; set; }
        public string destination { get; set; }
        public string departureTime { get; set; }
        public string arrivalTime { get; set; }

        public Plane(string planeName, string pilotFirstName, string pilotLastName, int planeCapacity, string startingLocation, string destination, string departureTime, string arrivalTime)
        {
            this.planeName = planeName;
            this.pilotFirstName = pilotFirstName;
            this.pilotLastName = pilotLastName;
            this.planeCapacity = planeCapacity;
            this.startingLocation = startingLocation;
            this.destination = destination;
            this.departureTime = departureTime;
            this.arrivalTime = arrivalTime;
        }
        public override string ToString()
        {
            return "\nPlane Name: " + planeName + "\n" + "Pilot Name: " + pilotFirstName + pilotLastName + "\n" + "Plane Passenger Capacity: " + planeCapacity + "\n" + "Starting Location: " + 
                startingLocation + "\n" + "End Destination: " + destination + "\n" + "Flight Depature Time: " + departureTime + "\n" + "Estimated Flight Arrival Time" + arrivalTime;
        }


    }
}
