using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_III_Group1_Group_Project
{
    public class Meteorological
    {
        private string weather { get; set; }
        private string temperature { get; set; }
        private string airPressure { get; set; }
        private bool dayType { get; set; }

        public Meteorological(string weather, string temperature, string airPressure, bool dayType)
        {
            this.weather = weather;
            this.temperature = temperature;
            this.airPressure = airPressure;
            this.dayType = dayType;
        }

        public override string ToString()
        {
            return "Weather: " + weather + " Temperature: " + temperature + " Air Pressure: " + airPressure + " Day Type: " + dayType;
        }
    }
}
