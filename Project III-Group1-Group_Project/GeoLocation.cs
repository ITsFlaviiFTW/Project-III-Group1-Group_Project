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
        private string currLatitude;
        private string currLongitude;
        private CompassBearing currBearing;
        private string currProvinceState;
        private DateTime currEstimatedArrivalTime;

        public void setCurrLatitude(string currLatitude)
        {
            this.currLatitude = currLatitude;
        }
        public string getCurrLatitude()
        {
            return this.currLatitude;
        }

        public void setCurrLongitude(string currLongitude)
        {
            this.currLongitude = currLongitude;
        }
        public string getCurrLongitude()
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

         public string obtainNewLongitude()
         {
            if (!File.Exists("Resources\\longitudes.txt"))
            {
                throw new Exception("Longitudes File does not exist");
            }
            else
            {
                Random random = new Random();
                string decimalPoint = "", wholeNumber = "", filePath = "Resources\\longitudes.txt";
                string[] allLines = File.ReadAllLines(filePath);

                wholeNumber = allLines[random.Next(allLines.Length)];
                decimalPoint = random.Next(0, 1000000).ToString("D6");

                return wholeNumber + "." + decimalPoint;
            }                               
         }

        public string obtainNewLatitude()
        {
            if (!File.Exists("Resources\\latitudes.txt"))
            {
                throw new Exception("Latitudes File does not exist");
            }
            Random random = new Random();          
            string decimalPoint = "", wholeNumber = "", filePath = "Resources\\latitudes.txt";           
            string[] allLines = File.ReadAllLines(filePath);

            wholeNumber= allLines[random.Next(allLines.Length)];
            decimalPoint = random.Next(0, 1000000).ToString("D6");
            
            return wholeNumber + "." + decimalPoint;                    
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
