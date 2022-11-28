using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_III_Group1_Group_Project.Properties;

namespace Project_III_Group1_Group_Project
{

    public struct StatusUpdatesData

    {
        private bool OutDoor;
        private bool CockpitDoor;
        private bool LandingGear;
        private bool InFlight;
        private bool AutoPilot;
        public void setOutDoor(bool outDoor)
        {
            this.OutDoor = outDoor;
        }
        public bool getOutDoor()
        {
            return this.OutDoor;
        }
        public void setCockpitDoor(bool cockpitDoor)
        {
            this.CockpitDoor = cockpitDoor;
        }
        public bool getCockpitDoor()
        {
            return this.CockpitDoor;
        }
        public void setLandingGear(bool landingGear)
        {
            this.LandingGear = landingGear;
        }
        public bool getLandingGear()
        {
            return this.LandingGear;

        }
        public void setInFlight(bool inFlight)
        {
            this.InFlight = inFlight;
        }
        public bool getInFlight()
        {
            return this.InFlight;
        }
        public void setAutoPilot(bool autoPilot)
        {
            this.AutoPilot = autoPilot;
        }
        public bool getAutoPilot()
        {
            return this.AutoPilot;
        }
    }

    public class StatusUpdates
    {
        public StatusUpdatesData StatusUpdatesData;

       
        public StatusUpdates(StatusUpdatesData data)
        {
            this.StatusUpdatesData.setOutDoor(data.getOutDoor());
            this.StatusUpdatesData.setCockpitDoor(data.getCockpitDoor());
            this.StatusUpdatesData.setLandingGear(data.getLandingGear());
            this.StatusUpdatesData.setInFlight(data.getInFlight());
            this.StatusUpdatesData.setAutoPilot(data.getAutoPilot());

        }
        public string obtainDoorStatus()
        {
            //create an array for door numbers values
            // good for traversing the pictures? or better to have 4 doors and cycle?

            string wholeNumber = "";

            if (File.Exists("Resources\\doors.txt"))
            {
                // Read a text file line by line.
                // all of the file will contain is the door status? maybe something better 
                Random random = new Random();
                string[] lines = File.ReadAllLines("Resources\\doors.txt");
                wholeNumber = lines[random.Next(lines.Length)];

            }
            return wholeNumber;
        }
    
        public bool obtainCPDoorStatus()
        {
            Random random = new Random();

            bool cpDoorStatus = false;

            if (StatusUpdatesData.getOutDoor() == false)
            {
                cpDoorStatus = false;

                if (StatusUpdatesData.getOutDoor() == true)
                // probably better logic in here to time the door opening and closing 
                {
                    if (random.Next(1, 4) == 1)
                    {
                        cpDoorStatus = false;
                    }
                    else
                    {
                        cpDoorStatus = true;
                    }
                }
            }

            return cpDoorStatus;
        }

        public bool obtainLandingGearstatus()
        {
            Random random = new Random();

            bool landingGear = true;

            if (StatusUpdatesData.getInFlight() == true)
                landingGear = false;
            // logic here if the speed is under *x* then the landing gear comes out 
            //elseif (ActiveGauges.getSpeed < *x*)
            //    landingGear = true;

            return landingGear;
        }
        public bool obtainAutoPilotstatus()
        {
            Random random = new Random();

            bool autoPilot = false;
            // cant auto pilot if not inflight
            if (StatusUpdatesData.getInFlight() == false)
                autoPilot = false;
            // cant auto pilot if the cockpitdoor is open
            if (StatusUpdatesData.getCockpitDoor() == false)
                autoPilot = false;
            // cant autopilot if the weather is bad 
            else if (StatusUpdatesData.getCockpitDoor() == true) // && MeteorologicalData.getWeater == good)
            {
                if (random.Next(1, 2) == 1)
                {
                    autoPilot = false;
                }
                else
                {
                    autoPilot = true;
                }
            }

            return autoPilot;
        }
        public bool obtainInFlightstatus()
        {
            Random random = new Random();

            bool inFlight = false;
            // cant be inflight is landing gear is down
            if (StatusUpdatesData.getLandingGear() == true)
                inFlight = false;
            if (StatusUpdatesData.getLandingGear() == false)
                inFlight = true;

            return inFlight;
        }
        public override string ToString()
        {
            return "Door: " + StatusUpdatesData.getOutDoor() + " InFlight: " + StatusUpdatesData.getInFlight() + " Landing Gear: " + StatusUpdatesData.getLandingGear() + " CockPit Door: "
                + StatusUpdatesData.getCockpitDoor() + "Auto Pilot: " + StatusUpdatesData.getAutoPilot();
        }
    }

}