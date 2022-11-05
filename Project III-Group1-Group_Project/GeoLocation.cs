using System;
using System.Collections.Generic;
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
        private string currCountry;
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

        public void setCurrCountry(string currCountry)
        {
            this.currCountry = currCountry;
        }
        public string getCurrCountry()
        {
            return this.currCountry;
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
        public LocationData locationData;        
          public GeoLocation(LocationData locationData)
          {
                this.locationData.setCurrLongitude(locationData.getCurrLongitude());
                this.locationData.setCurrLatitude(locationData.getCurrLatitude());
                this.locationData.setCompassBearing(locationData.GetCompassBearing());
                this.locationData.setCurrCountry(locationData.getCurrCountry());
                this.locationData.setCurrEstimatedArrivalTime(locationData.getCurrEstimatedArrivalTime());
          }

         
    }
}
