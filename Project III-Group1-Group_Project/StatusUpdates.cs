using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
    internal class StatusUpdates
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
        public override string ToString()
        {
            return "Outter Door Status: " + StatusUpdatesData.getOutDoor() + " " + "Cockpit Door Status: " + StatusUpdatesData.getCockpitDoor() + " " + "Landing Gear Status: " + StatusUpdatesData.getLandingGear() + " "
                + "In Flight Status: " + StatusUpdatesData.getInFlight() + " " + "Auto Pilot Status: " + StatusUpdatesData.getAutoPilot();

        }
    }
}
