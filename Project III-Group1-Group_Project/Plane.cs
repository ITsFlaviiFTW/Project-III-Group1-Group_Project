using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_III_Group1_Group_Project
{
    public struct PlaneData
    {
        private string planeName;
        private string pilotFirstName;
        private string pilotLastName;
        private int planeCapacity;
        private string startingLocation;
        private string destination;
        private string departureTime;
        private string arrivalTime; 
        public void setPlaneName(string planeName)
        {
            this.planeName = planeName;
        }
        public string getPlaneName()
        {
            return this.planeName;
        }

        public void setPilotFirstName(string pilotFirstName)
        {
            this.pilotFirstName = pilotFirstName;
        }
        public string getPilotFirstName()
        {
            return this.pilotFirstName;
        }

        public void setPilotLastName(string pilotLastName)
        {
            this.pilotLastName = pilotLastName;
        }
        public string getPilotLastName()
        {
            return this.pilotLastName;
        }

        public void setPlaneCapacity(int planeCapacity)
        {
            this.planeCapacity = planeCapacity;
        }
        public int getPlaneCapacity()
        {
            return this.planeCapacity;
        }

        public void setStartingLocation(string startingLocation)
        {
            this.startingLocation = startingLocation;
        }
        public string getStartingLocation()
        {
            return this.startingLocation;
        }

        public void setDestination(string destination)
        {
            this.destination = destination;
            
        }
        public string getDestination()
        {
            return this.destination;
        }

        public void setDepartureTime(string departureTime)
        {
            this.departureTime = departureTime;            
        }

        public string getDepartureTime()
        {
            return this.departureTime;
        }

        public void setArrivialTime(string arrivalTime)
        {
            this.arrivalTime = arrivalTime;
        }
        public string getArrivalTime()
        {
            return this.arrivalTime;
        }


    }
    public class Plane
    {
        public PlaneData planeData;

        public Plane(PlaneData data)
        {
            this.planeData.setPlaneName(data.getPlaneName());
            this.planeData.setPilotFirstName(data.getPilotFirstName());
            this.planeData.setPilotLastName(data.getPilotLastName());
            this.planeData.setPlaneCapacity(data.getPlaneCapacity());
            this.planeData.setStartingLocation(data.getStartingLocation());
            this.planeData.setDestination(data.getDestination());
            this.planeData.setDepartureTime(data.getDepartureTime());
            this.planeData.setArrivialTime(data.getArrivalTime());
        }
        public override string ToString()
        {
            return "Plane Name: " + planeData.getPlaneName() + " " + "Pilot Name: " + planeData.getPilotFirstName() + planeData.getPilotLastName() + " " + "Plane Passenger Capacity: " + planeData.getPlaneCapacity() + " " 
                + "Starting Location: " + planeData.getStartingLocation() + " " + "End Destination: " + planeData.getDestination() + " " + "Flight Depature Time: " + planeData.getDepartureTime() + " " + "Estimated Flight Arrival Time" + planeData.getArrivalTime();

        }
    }
}
