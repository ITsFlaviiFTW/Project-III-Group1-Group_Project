using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_III_Group1_Group_Project
{
    public struct GaugesData
    {
        private int speed;
        private float altitude;
        private float fuelLevel;
        private float oxygenLevel;
        private bool startUpSpeed;
        private bool startUpAltitude;
        private bool startUpFuel;
        private bool startUpOxygen;
        private bool firstRefuel;

        public int getPlaneSpeed()
        {
            return speed;
        }

        public void setPlaneSpeed(int speed)
        {
            this.speed = speed;
        }

        public float getPlaneAltitude()
        {
            return altitude;
        }

        public void setPlaneAltitude(float altitude)
        {
            this.altitude = altitude;
        }

        public float getFuelLevel()
        {
            return fuelLevel;
        }

        public void setFuelLevel(float fuelLevel)
        {
            this.fuelLevel = fuelLevel;
        }

        public float getOxygenLevel()
        {
            return oxygenLevel;
        }

        public void setOxygenLevel(float oxygenLevel)
        {
            this.oxygenLevel = oxygenLevel;
        }

        public bool getSetUpSpeed()
        {
            return startUpSpeed;
        }

        public void setSetUpSpeed(bool setUp)
        {
            this.startUpSpeed = setUp;
        }

        public bool getSetUpAltitude()
        {
            return startUpAltitude;
        }

        public void setSetUpAltitude(bool setUp)
        {
            this.startUpAltitude = setUp;
        }

        public bool getSetUpFuel()
        {
            return startUpFuel;
        }

        public void setSetUpFuel(bool setUp)
        {
            this.startUpFuel = setUp;
        }

        public bool getSetUpOxygen()
        {
            return startUpOxygen;
        }

        public void setSetUpOxygen(bool setUp)
        {
            this.startUpOxygen = setUp;
        }

        public bool getFirstRefuel()
        {
            return firstRefuel;
        }
        
        public void setFirstRefuel(bool firstRefuel)
        {
            this.firstRefuel = firstRefuel;
        }
    }
    public class ActiveGauges
    {
        public GaugesData gaugesData;

        public ActiveGauges(GaugesData gaugesData)
        {
            gaugesData.setPlaneSpeed(1);
            gaugesData.setPlaneAltitude(1); 
            gaugesData.setFuelLevel(1);
            gaugesData.setOxygenLevel(1);
        }

        public int determineSafeSpeed(int currentSpeed, int limitSpeed, int maxSpeed)
        {
            Random rand = new Random();
            return rand.Next(currentSpeed - limitSpeed, maxSpeed);
        }

        public int determineSafeAltitude(int currentAltitude, int limitAltitude, int maxAltitude)
        {
            Random rand = new Random();
            return rand.Next(currentAltitude - limitAltitude, maxAltitude);
        }

        void determineTurbulence(string weather, int airPressure)
        {
            // Take in air pressure and weather
            // Determine if the weather is good or bad and if the pressure is high or low
            // Then if the weather is bad and if air pressure is low
            // Ajust by a percentage based on how bad the weather really is and if air pressure is low
            // Reduce speed by 15% if thunder, lightning and pouring rain as well as low pressure
        }

        public float determineSafeOxygenLevel(float airPressure, float maxValue)
        {
            float temp = maxValue - airPressure;
            airPressure += (temp / 2);
            return airPressure;
        }

        public float dedtermineFuelEfficiency(float fuelLevel, float incrementingValue)
        {
            fuelLevel += incrementingValue;
            return fuelLevel;
        }
    }
}
