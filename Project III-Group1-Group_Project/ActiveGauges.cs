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
    }
    public class ActiveGauges
    {
        public GaugesData gaugesData;

        public ActiveGauges(GaugesData gaugesData)
        {
            this.gaugesData.setPlaneSpeed(gaugesData.getPlaneSpeed());
            this.gaugesData.setPlaneAltitude(gaugesData.getPlaneAltitude()); 
            this.gaugesData.setFuelLevel(gaugesData.getFuelLevel());
            this.gaugesData.setOxygenLevel(gaugesData.getOxygenLevel());
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
