using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_III_Group1_Group_Project
{
    public enum CompassBearing
    {
        N,
        NE,
        E,
        SE,
        S,
        SW,
        W,
        NW
    }
    public struct LocationData
    {
        private double currLatitude;
        private double currLongitude;
        private CompassBearing currBearing;
        private string currProvinceState;
        private DateTime currEstimatedArrivalTime;

        public void setCurrLatitude(double currLatitude)
        {
            this.currLatitude = currLatitude;
        }
        public double getCurrLatitude()
        {
            return this.currLatitude;
        }

        public void setCurrLongitude(double currLongitude)
        {
            this.currLongitude = currLongitude;
        }
        public double getCurrLongitude()
        {
            return this.currLongitude;
        }

        public void setCompassBearing(CompassBearing compassBearing)
        {                    
            this.currBearing = compassBearing;
        }
        public CompassBearing GetCompassBearing()
        {
            return this.currBearing;
        }

        public void setCurrProvinceState(string currProvinceState)
        {
            this.currProvinceState = currProvinceState;
        }
        public string getCurrProvinceState()
        {
            return this.currProvinceState;
        }

        public void setCurrEstimatedArrivalTime(DateTime time)
        {
            this.currEstimatedArrivalTime = time;
        }
        public DateTime getCurrEstimatedArrivalTime()
        {
            return this.currEstimatedArrivalTime;
        }
    } 
    public class GeoLocation
    {
        public LocationData locationDataStruct;        
          public GeoLocation(LocationData locationData)
          {
                this.locationDataStruct.setCurrLongitude(locationData.getCurrLongitude());
                this.locationDataStruct.setCurrLatitude(locationData.getCurrLatitude());
                this.locationDataStruct.setCompassBearing(locationData.GetCompassBearing());
                this.locationDataStruct.setCurrProvinceState(locationData.getCurrProvinceState());
                this.locationDataStruct.setCurrEstimatedArrivalTime(locationData.getCurrEstimatedArrivalTime());
          }

         public double obtainNewLongitude()
         {
            return 5.5;
         }

        public double obtainNewLatitude()
        {
            Random random = new Random();

            string filePath = "Resources\\latitudes.txt";

            string[] allLines = File.ReadAllLines(filePath);
            double newLatitude = Convert.ToDouble(allLines[random.Next(allLines.Length)]);
            return newLatitude;
        }

        public DateTime obtainNewEstimatedTimeUntilArrival(int planeSpeed)
        {
            return new DateTime();
        }

        public string obtainCurrentProvinceState()
        {
            return "";
        }


        public CompassBearing calculateNewCompassBearing(CompassBearing currentBearing, string directionToTurn, int angleToTurn)
        {
            return CompassBearing.NE;
        }




         
    }
}
