using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_III_Group1_Group_Project
{
    public struct MeteorologicalData
    {
        private string weather;
        private int temperature;
        private int airPressure;
        private bool dayType;

        public void setWeather(string weather)
        {
            this.weather = weather;
        }
        public string getWeather()
        {
            return this.weather;
        }


        public void setTemperature(int temperature)
        {
            this.temperature = temperature;
        }

        public int getTemperature()
        {
            return this.temperature;
        }


        public void setAirPressure(int airPressure)
        {
            this.airPressure = airPressure;
        }

        public int getAirPressure()
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
        public Meteorological(MeteorologicalData data)
        {
            this.meteorologicalDataStruct.setWeather(data.getWeather());
            this.meteorologicalDataStruct.setTemperature(data.getTemperature());
            this.meteorologicalDataStruct.setAirPressure(data.getAirPressure());
            this.meteorologicalDataStruct.setDayType(data.getDayType());
        }
        public int AirPressure()
        {
            //create an array for air pressure values
            int[] airPressure = new int[5];
            airPressure[0] = 0;
            airPressure[1] = 25;
            airPressure[2] = 50;
            airPressure[3] = 75;
            airPressure[4] = 100;


            //create a for loop to iterate through the array
            for (int i = 0; i < airPressure.Length; i++)
            {
                //create if statement to determine if the air pressure is in the normal range
                if (airPressure[i] >= 50 && airPressure[i] <= 75)
                {
                    Console.WriteLine("The air pressure is normal.");
                }
                else if (airPressure[i] >= 0 && airPressure[i] <= 25)
                {
                    Console.WriteLine("The air pressure is extremely low, you must do something!");
                }
                else if (airPressure[i] >= 26 && airPressure[i] <= 49)
                {
                    Console.WriteLine("The air pressure is low, change the dials and fix the issue!");
                }
                else if (airPressure[i] >= 76 && airPressure[i] <= 100)
                {
                    Console.WriteLine("The air pressure is high, reduce the pressure!");
                }
            }
            return airPressure[0];
        }


        public override string ToString()
        {
            return "Weather: " + meteorologicalData.getWeather() + " Temperature: " + meteorologicalData.getTemperature() + " Air Pressure: " + meteorologicalData.getAirPressure() + " Day Type: " + meteorologicalData.getDayType();
        }


    }
}

