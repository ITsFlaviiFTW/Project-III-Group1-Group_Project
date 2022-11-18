﻿using System;
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
        private bool turbulance; // Not sure if the implementation of this is still probable 

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

        public bool getTurbulence()
        {
            return turbulance;
        }

        public void setTurbulence(bool turbulence)
        {
            this.turbulance = turbulence;
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
            this.gaugesData.setTurbulence(gaugesData.getTurbulence());
        }

        void determineSafeSpeed(bool turbulence, string weather)
        {
            
            // Take in speed and weather
            // Determine if the weather is good or bad
            // Then if the weather is bad ajust accordingly 
            // Maybe ajust by a percentage based on how bad the weather really is
            // Reduce speed by 5% if raining, reduce by 15% if thunder, lightning and pouring rain
        }

        void determineSafeAltitude(string weather)
        {
            // Take in weather
            // Determine if the weather is good or bad
            // Then if the weather is bad ajust accordingly 
            // Maybe ajust by a percentage based on how bad the weather really is
            // Reduce altitude by 5% if raining, reduce by 15% if thunder, lightning and pouring rain
        }

        void determineTurbulence(string weather, int airPressure)
        {
            // Take in air pressure and weather
            // Determine if the weather is good or bad and if the pressure is high or low
            // Then if the weather is bad and if air pressure is low
            // Ajust by a percentage based on how bad the weather really is and if air pressure is low
            // Reduce speed by 15% if thunder, lightning and pouring rain as well as low pressure
        }

        void determineSafeOxygenLevel(float altitude)
        {
            // if the plane is too high the oxygen level will be too low 
            // if the plane is too high reduce altitude
        }

        void dedtermineFuelEfficiency(int speed)
        {
            // if the plane speed is reduced increase fuel efficiency
            // and like wise if the plane speed is increased reduce fuel efficiency
            // fuel efficiency could be measured in 
        }
    }
}
