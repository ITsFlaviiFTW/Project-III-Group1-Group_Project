using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_III_Group1_Group_Project
{
    //create an enum containing air pressure values from 0 to 100 incrementing by 25
    public enum AirPressureValues
    {
        Critical = 0,
        Danger = 25,
        Low = 50,
        Normal = 75,
        Stable = 100
    }

    public struct MeteorologicalData
    {
        private AirPressureValues airPressureVal;
        private string weather;
        private string temperature;
        private string airPressure;
        private bool dayType;


        public void setAirPressureValues(AirPressureValues airPressureValues)
        {
            this.airPressureVal = airPressureValues;
        }

        public AirPressureValues getAirPressureValues()
        {
            return this.airPressureVal;
        }
        public void setWeather(string weather)
        {
            this.weather = weather;
        }
        public string getWeather()
        {
            return this.weather;
        }


        public void setTemperature(string temperature)
        {
            this.temperature = temperature;
        }

        public string getTemperature()
        {
            return this.temperature;
        }


        public void setAirPressure(string airPressure)
        {
            this.airPressure = airPressure;
        }

        public string getAirPressure()
        {
            return this.airPressure;
        }


        public void setDayType(bool dayType)
        {
            this.dayType = dayType;
        }

        public bool getDayType()
        {
            return this.dayType;
        }

    }
    public class Meteorological
    {
        public MeteorologicalData meteorologicalDataStruct;
        public Meteorological(MeteorologicalData meteorologicalData)
        {
            this.meteorologicalDataStruct.setAirPressureValues(meteorologicalData.getAirPressureValues());
            this.meteorologicalDataStruct.setWeather(meteorologicalData.getWeather());
            this.meteorologicalDataStruct.setTemperature(meteorologicalData.getTemperature());
            this.meteorologicalDataStruct.setAirPressure(meteorologicalData.getAirPressure());
            this.meteorologicalDataStruct.setDayType(meteorologicalData.getDayType());
        }
        public string obtainNewAirPressure()
        {
            int airPressureNum = 0;
            if (!File.Exists("Resources\\airpressure.txt"))
            {
                throw new Exception("Air Pressure File does not exist");
            }
            string airPressure = "Resources\\airpressure.txt";
            string[] airPressureArray = File.ReadAllLines(airPressure);
            airPressureNum = int.Parse(airPressureArray[0]);
            airPressureNum -= 1;
            if (airPressureNum <= 0)
            {
                airPressureNum = 0;
            }
            File.WriteAllText(airPressure, airPressureNum.ToString());
            return airPressureNum.ToString();
        }
        public string buttonGoUpPressure()
        {
            int airPressureNum = 0;
            if (!File.Exists("Resources\\airpressure.txt"))
            {
                throw new Exception("Air Pressure File does not exist");
            }
            string airPressure = "Resources\\airpressure.txt";
            string[] airPressureArray = File.ReadAllLines(airPressure);
            airPressureNum = int.Parse(airPressureArray[0]);
            airPressureNum += 1;
            if (airPressureNum >= 100)
            {
                airPressureNum = 100;
            }
            File.WriteAllText(airPressure, airPressureNum.ToString());
            return airPressureNum.ToString();
        }
      

        public AirPressureValues obtainNewAirPressureMessage(int airPressureValue)
        {
            if (airPressureValue >= 0 && airPressureValue <= 5)
            {
                return AirPressureValues.Critical;
            }
            else if (airPressureValue > 5 && airPressureValue <= 25)
            {
                return AirPressureValues.Danger;
            }
            else if (airPressureValue > 25 && airPressureValue <= 50)
            {
                return AirPressureValues.Low;
            }
            else if (airPressureValue > 50 && airPressureValue <= 75)
            {
                return AirPressureValues.Normal;
            }
            else
            {
                return AirPressureValues.Stable;
            }
        }




        public override string ToString()
        {
            return "Weather: " + meteorologicalDataStruct.getWeather() + " Temperature: " + meteorologicalDataStruct.getTemperature() + " Air Pressure: " + meteorologicalDataStruct.getAirPressure() + " Day Type: " + meteorologicalDataStruct.getDayType();
        }
    }
}



