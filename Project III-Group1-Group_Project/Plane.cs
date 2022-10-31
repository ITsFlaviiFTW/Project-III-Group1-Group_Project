using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_III_Group1_Group_Project
{
    public class Plane
    {
        private string planeName { get; set; }
        private string pilotFirstName { get; set; }
        private string pilotLastName { get; set; }
        private int planeCapacity { get; set; }
        private string startingLocation { get; set; }
        private string destination { get; set; }
        private string departureTime { get; set; }
        private string arrivalTime { get; set; }

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
            return planeName + " " + pilotFirstName + " " + pilotLastName + " " + planeCapacity + " " + startingLocation + " " + destination + " " + departureTime + " " + arrivalTime;
        }


    }
}
