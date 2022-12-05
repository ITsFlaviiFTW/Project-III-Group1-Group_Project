using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_III_Group1_Group_Project
{


    public partial class Form1 : Form
    {
        //Classes and structs
        Meteorological meteorologicalData;
        MeteorologicalData meteorologicalDataStruct;

        ActiveGauges activeGauges;
        GaugesData gaugesData = new GaugesData();
        Random rand = new Random();

        GeoLocation locationData;
        LocationData locationDataStruct = new LocationData();

        StatusUpdates statusUpdatesData;
        StatusUpdatesData statusUpdatesDataStruct = new StatusUpdatesData();

        public Plane currentFlight { get; set; }
        PlaneData planeDataStruct = new PlaneData();
        DateTime startingTime;
        //Flights text file
        string filePath = "Resources\\flights.txt";

        //Global random you can use
        Random random = new Random();
        int i = 1;
        int counter = 0;
        int autoPilotCounter = 0;
        int weatherimageNum = 0;
        int tempimageNum = 0;
        bool startingUpSequence = true;
        

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // pre-existing flight information here
                string[] flights = File.ReadAllLines(filePath);
                string[] flightToUse = flights[random.Next(flights.Length)].Split(',');

                planeDataStruct.setPlaneName(flightToUse[0].Trim());
                planeDataStruct.setPilotFirstName(flightToUse[1].Trim());
                planeDataStruct.setPilotLastName(flightToUse[2].Trim());
                planeDataStruct.setPlaneCapacity(int.Parse(flightToUse[3].Trim()));
                planeDataStruct.setStartingLocation(flightToUse[4].Trim());
                planeDataStruct.setDestination(flightToUse[5].Trim());
                planeDataStruct.setDepartureTime(flightToUse[6].Trim());
                planeDataStruct.setArrivialTime(flightToUse[7].Trim());

                // starting image
                pictureBox1.Image = Properties.Resources.plane1;

                //Assign objects with created structs
                currentFlight = new Plane(planeDataStruct);

                //Sets up everything regarding GeoLocation

                ActiveGaugesSetup();
                GeoLocationSetup();
                MeteorologicalSetup();
                StatusUpdateSetup();

            }

            catch (Exception)
            {
                DialogResult res = MessageBox.Show("There was an error getting your flight information, now closing the program", "Flight Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);

            }
        }

        private void MeteorologicalSetup()
        {
            //Meteorological meteorologicalData = new Meteorological(meteorologicalDataStruct);
            meteorologicalDataStruct.setAirPressure("100");
            meteorologicalDataStruct.setAirPressureValues(AirPressureValues.Stable);
            meteorologicalDataStruct.setWeather("Resources\\weatherImages\\0.png");
            meteorologicalDataStruct.setTemperature("Resources\\tempImages\\0.png");
            weatherPictureBox.ImageLocation = meteorologicalDataStruct.getWeather();
            temperaturePictureBox.ImageLocation = meteorologicalDataStruct.getTemperature();
            farrenheitSymbolPictureBox.Image = Image.FromFile("Resources\\farrenheit-resized.png");
            meteorologicalData = new Meteorological(meteorologicalDataStruct);
            //airPressureTimer.Start();
        }

        private void StatusUpdateSetup()
        {
            statusUpdatesDataStruct.setOutDoor(false);
            statusUpdatesDataStruct.setInFlight(false);
            statusUpdatesDataStruct.setLandingGear(false);
            statusUpdatesDataStruct.setAutoPilot(false);
            statusUpdatesDataStruct.setCockpitDoor(false);

            statusUpdatesData = new StatusUpdates(statusUpdatesDataStruct);
        }

        private void GoBack(object sender, EventArgs e) // lock doors button
        {

            LockDoors.Enabled = false;
            if (startingUpSequence)
            {
                lblDefaultMessage.Text = "Pre flight checkup complete";
                lblDefaultMessage.ForeColor = Color.Green;
                btnStartPlane.Enabled = true;
                startingUpSequence = false;
            }
            statusUpdatesDataStruct.setOutDoor(false);

            pictureBox1.Image = Properties.Resources.plan_good;

            // want a delay here 
            lbDoor.Text = "Doors Locked";
            lbDoor.ForeColor = Color.Green;
            AutoPilot.Enabled = true;

        }

        private void GoNext(object sender, EventArgs e) // auto pilot button that pop us 
        {

            // want to set autopilot to true keep doorslocked 
            statusUpdatesData.StatusUpdatesData.setCockpitDoor(true);
            statusUpdatesData.StatusUpdatesData.setLandingGear(true);
            statusUpdatesData.StatusUpdatesData.setInFlight(true);
            statusUpdatesData.StatusUpdatesData.setOutDoor(true);
            AutoPilot.Enabled = false;
            pictureBox1.Image = Properties.Resources.plan_good;

            AutoPilotTimer.Start();


            if (statusUpdatesData.obtainAutoPilotstatus() == true)
            {
                lbAutoPilot.Text = "Auto Pilot Engaged";
                autoPilotBarTimer.Start();
              
                btnLeft45.Enabled = false;
                btnLeft90.Enabled = false;
                btnRight45.Enabled = false;
                btnRight90.Enabled = false;
                lbAutoPilot.ForeColor = Color.Green;
                autopilotProgressBar.Visible = true;
            }
            else if (statusUpdatesData.obtainAutoPilotstatus() == false)
            {
                lbAutoPilot.Text = "Doors Must Be Locked";
            }

            // press again to turn off // cp door status can change after Autopilot is off // disapear if the doors are unlocked 

        }

        private void changeImage()
        {

            // check doors to traverse images
            string doorNum = statusUpdatesData.obtainDoorStatus();


            switch (doorNum)
            {
                case "0":
                    pictureBox1.Image = Properties.Resources.plane1_Bad_door4;
                    break;
                case "1":
                    pictureBox1.Image = Properties.Resources.plane1_Bad_door1;
                    break;
                case "2":
                    pictureBox1.Image = Properties.Resources.plane1_Bad_door2;
                    break;
                case "3":
                    pictureBox1.Image = Properties.Resources.plane1_Bad_door3;
                    break;
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e) // this needs to be here for the images to be alive
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e) // 
        {

        }

        private void btnViewFlightInformation_Click(object sender, EventArgs e)
        {
            flightInformation frm = new flightInformation();
            frm.currentFlight = currentFlight;
            frm.Show();
        }

        private void weatherPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void weatherTimer_Tick(object sender, EventArgs e)
        {
            farrenheitSymbolPictureBox.Image = Image.FromFile("Resources\\farrenheit-resized.png");
            //loop pictures into picturebox from resources folder
            string[] weatherImages = Directory.GetFiles("Resources\\weatherImages");
            string[] tempImages = Directory.GetFiles("Resources\\tempImages");
            weatherPictureBox.Image = Image.FromFile(weatherImages[weatherimageNum]);
            temperaturePictureBox.Image = Image.FromFile(tempImages[tempimageNum]);
            weatherimageNum++;
            tempimageNum++;
            if (weatherimageNum >= weatherImages.Length)
            {
                weatherimageNum = 0;
            }
            if (tempimageNum >= tempImages.Length)
            {
                tempimageNum = 0;
            }
        }

        private void temperaturePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void farrenheitSymbolPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void airPressureTimer_Tick(object sender, EventArgs e)
        {

            txtAirPressure.Enabled = true;
            meteorologicalData.meteorologicalDataStruct.setAirPressure(meteorologicalData.obtainNewAirPressure());
            meteorologicalData.meteorologicalDataStruct.setAirPressureValues(meteorologicalData.obtainNewAirPressureMessage(int.Parse(meteorologicalData.meteorologicalDataStruct.getAirPressure())));
            txtAirPressure.Text = meteorologicalData.meteorologicalDataStruct.getAirPressure().ToString();

            if (meteorologicalData.meteorologicalDataStruct.getAirPressureValues() == AirPressureValues.Stable || meteorologicalData.meteorologicalDataStruct.getAirPressureValues() == AirPressureValues.Normal)
            {
                txtAirPressure.BackColor = Color.Green;
                lbAirPressure.ForeColor = Color.Green;
                lbAirPressure.Text = "Air Pressure: Stable";
                btnAirPressure.Enabled = false;
                btnAirPressure.Visible = false;
            }
            else if (meteorologicalData.meteorologicalDataStruct.getAirPressureValues() == AirPressureValues.Low)
            {
                txtAirPressure.BackColor = Color.Orange;
                lbAirPressure.ForeColor = Color.Orange;
                lbAirPressure.Text = "Air Pressure: Low";
                btnAirPressure.Enabled = true;
                btnAirPressure.Visible = true;
            }
            else if (meteorologicalData.meteorologicalDataStruct.getAirPressureValues() == AirPressureValues.Danger || meteorologicalData.meteorologicalDataStruct.getAirPressureValues() == AirPressureValues.Critical)
            {
                txtAirPressure.BackColor = Color.Red;
                lbAirPressure.ForeColor = Color.Red;
                lbAirPressure.Text = "Air Pressure: Critical";
                btnAirPressure.Enabled = true;
                btnAirPressure.Visible = true;
            }
        }

        private void latitudeLongitudeTimer_Tick(object sender, EventArgs e)
        {
            if (locationData.locationDataStruct.getCompassBearing() == CompassBearing.N || locationData.locationDataStruct.getCompassBearing() == CompassBearing.S)
            {
                txtLongitude.Enabled = false;
                txtLatitude.Enabled = true;
                locationData.locationDataStruct.setCurrLatitude(locationData.obtainNewLatitude());
                txtLatitude.Text = locationData.locationDataStruct.getCurrLatitude().ToString();
            }
            else if (locationData.locationDataStruct.getCompassBearing() == CompassBearing.E || locationData.locationDataStruct.getCompassBearing() == CompassBearing.W)
            {
                txtLongitude.Enabled = true;
                txtLatitude.Enabled = false;
                locationData.locationDataStruct.setCurrLongitude(locationData.obtainNewLongitude());
                txtLongitude.Text = locationData.locationDataStruct.getCurrLongitude();
            }
            else
            {
                txtLongitude.Enabled = true;
                txtLatitude.Enabled = true;
                locationData.locationDataStruct.setCurrLatitude(locationData.obtainNewLatitude());
                txtLatitude.Text = locationData.locationDataStruct.getCurrLatitude().ToString();

                locationData.locationDataStruct.setCurrLongitude(locationData.obtainNewLongitude());
                txtLongitude.Text = locationData.locationDataStruct.getCurrLongitude();
            }
        }

        private void btnLeft45_Click(object sender, EventArgs e)
        {
            turnPlane(locationData.locationDataStruct.getCompassBearing(), "Left", 45);
        }

        private void btnLeft90_Click(object sender, EventArgs e)
        {
            turnPlane(locationData.locationDataStruct.getCompassBearing(), "Left", 90);
        }

        private void btnRight45_Click(object sender, EventArgs e)
        {
            turnPlane(locationData.locationDataStruct.getCompassBearing(), "Right", 45);
        }

        private void btnRight90_Click(object sender, EventArgs e)
        {
            turnPlane(locationData.locationDataStruct.getCompassBearing(), "Right", 90);
        }

        public void turnPlane(CompassBearing currentBearing, string directionToTurn, int angleToTurn)
        {
            locationData.locationDataStruct.setCompassBearing(locationData.calculateNewCompassBearing(currentBearing, directionToTurn, angleToTurn));

            if (angleToTurn == 45)
            {

                turningPlaneTimer.Interval = 3000;
            }
            else
            {
                turningPlaneTimer.Interval = 6000;
            }

            foreach (Button button in grpBoxPlaneTurning.Controls)
            {
                button.Enabled = false;
            }
            lblPlaneIsTurning.Text = "Plane is currently turning...";
            turningPlaneTimer.Start();
        }

        private void turningPlaneTimer_Tick(object sender, EventArgs e)
        {
            turningPlaneTimer.Stop();
            lblPlaneIsTurning.Text = "";
            lblCompassBearing.Text = locationData.locationDataStruct.getCompassBearing().ToString();
            foreach (Button button in grpBoxPlaneTurning.Controls)
            {
                button.Enabled = true;
            }
        }

        private void changingLocationTimer_Tick(object sender, EventArgs e)
        {
            locationData.locationDataStruct.setCurrCountry(locationData.obtainCurrentCountry());

            if (locationData.locationDataStruct.getCurrCountry() == "CAN")
            {
                locationData.locationDataStruct.setCurrProvinceState(locationData.obtainCurrentProvinceState(locationData.locationDataStruct.getCurrCountry()));
                picBoxCountry.ImageLocation = "Resources\\canadaFlag.png";
                lblProvinceStateInfo.Text = locationData.locationDataStruct.getCurrProvinceState().ToString();
            }
            else
            {
                locationData.locationDataStruct.setCurrProvinceState(locationData.obtainCurrentProvinceState(locationData.locationDataStruct.getCurrCountry()));
                picBoxCountry.ImageLocation = "Resources\\usaFlag.png";
                lblProvinceStateInfo.Text = locationData.locationDataStruct.getCurrProvinceState().ToString();
            }
        }

        private void GeoLocationSetup()
        {
            //Setting up default GeoLocation information
            locationDataStruct.setCurrLongitude("0.000000");
            locationDataStruct.setCurrLatitude("0.000000");
            locationDataStruct.setCurrEstimatedArrivalTimeLeft(DateTime.Now.ToString());
            locationDataStruct.setCurrProvinceState(currentFlight.planeData.getStartingLocation());
            if (locationDataStruct.getCurrProvinceState() == "Toronto")
            {
                locationDataStruct.setCurrCountry("CAN");
                picBoxCountry.ImageLocation = "Resources\\canadaFlag.png";
            }
            else
            {
                locationDataStruct.setCurrCountry("USA");
                picBoxCountry.ImageLocation = "Resources\\usaFlag.png";

            }
            locationDataStruct.setCompassBearing(CompassBearing.N);

            //Setting object
            locationData = new GeoLocation(locationDataStruct);

            //Setting default GUI information
            lblCompassBearing.Text = locationData.locationDataStruct.getCompassBearing().ToString();
            lblProvinceStateInfo.Text = locationData.locationDataStruct.getCurrProvinceState().ToString();
            var diffInTimes = DateTime.Parse(planeDataStruct.getDepartureTime()) - DateTime.Parse(planeDataStruct.getArrivalTime());

            locationDataStruct.setCurrEstimatedArrivalTimeLeft(diffInTimes.ToString().Replace("-", ""));
            lblEstimatedTimeLeft.Text = diffInTimes.ToString().Replace("-", "");
            startingTime = DateTime.Parse(currentFlight.planeData.getDepartureTime());
            lblCurrentDateTime.Text = startingTime.Subtract(new TimeSpan(0, 2, 0)).ToString();
        }
        private void ActiveGaugesSetup()
        {
            gaugesData.setPlaneSpeed(0);
            gaugesData.setPlaneAltitude(0);
            gaugesData.setFuelLevel(0);
            gaugesData.setOxygenLevel(0);
            gaugesData.setFirstRefuel(true);

            activeGauges = new ActiveGauges(gaugesData);

            StartUpTimer.Enabled = true;
        }

        private void dateTimeTimer_Tick(object sender, EventArgs e)
        {
            lblCurrentDateTime.Text = startingTime.Subtract(new TimeSpan(0, 2, 0)).ToString();
            startingTime = startingTime.AddSeconds(1);
        }

        private void estimatedTimeTimer_Tick(object sender, EventArgs e)
        {
            locationDataStruct.setCurrEstimatedArrivalTimeLeft(locationData.obtainNewEstimatedTimeUntilArrival(456, locationDataStruct.getCurrEstimatedArrivalTimeLeft()));
            lblEstimatedTimeLeft.Text = locationDataStruct.getCurrEstimatedArrivalTimeLeft().ToString();
        }

        private void aGauge1_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }

        private void aGauge2_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }

        private void aGauge3_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }

        private void aGauge4_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }

        private void SpeedTimer_Tick(object sender, EventArgs e)
        {
            if (gaugesData.getPlaneSpeed() < aGauge1.MaxValue && !gaugesData.getSetUpSpeed())
            {
                gaugesData.setPlaneSpeed(gaugesData.getPlaneSpeed() + (int)aGauge1.MaxValue / 40);
                aGauge1.Value = gaugesData.getPlaneSpeed();
                if (gaugesData.getPlaneSpeed() >= aGauge1.MaxValue)
                {
                    gaugesData.setSetUpSpeed(true);
                }
            }
            else if (gaugesData.getSetUpSpeed())
            {

                gaugesData.setPlaneSpeed(gaugesData.getPlaneSpeed() - (int)aGauge1.MaxValue / 40);
                aGauge1.Value = gaugesData.getPlaneSpeed();
            }

            if (gaugesData.getPlaneAltitude() < aGauge2.MaxValue && !gaugesData.getSetUpAltitude())
            {
                gaugesData.setPlaneAltitude(gaugesData.getPlaneAltitude() + (int)aGauge2.MaxValue / 40);
                aGauge2.Value = gaugesData.getPlaneAltitude();
            }
            else
            {
                gaugesData.setSetUpAltitude(true);
                gaugesData.setPlaneAltitude(gaugesData.getPlaneAltitude() - (int)aGauge2.MaxValue / 40);
                aGauge2.Value = gaugesData.getPlaneAltitude();
            }

            if (gaugesData.getFuelLevel() < aGauge3.MaxValue && !gaugesData.getSetUpFuel())
            {
                gaugesData.setFuelLevel(gaugesData.getFuelLevel() + (int)aGauge3.MaxValue / 40);
                aGauge3.Value = gaugesData.getFuelLevel();
            }
            else
            {
                gaugesData.setSetUpFuel(true);
                if (gaugesData.getFuelLevel() >= 0)
                {
                    gaugesData.setFuelLevel(gaugesData.getFuelLevel() - (int)aGauge3.MaxValue / 40);
                    aGauge3.Value = gaugesData.getFuelLevel();
                }
            }

            if (gaugesData.getOxygenLevel() < aGauge4.MaxValue && !gaugesData.getSetUpOxygen())
            {
                gaugesData.setOxygenLevel(gaugesData.getOxygenLevel() + (int)aGauge4.MaxValue / 40);
                aGauge4.Value = gaugesData.getOxygenLevel();
            }
            else
            {
                gaugesData.setSetUpOxygen(true);
                gaugesData.setOxygenLevel(gaugesData.getOxygenLevel() - (int)aGauge4.MaxValue / 40);
                aGauge4.Value = gaugesData.getOxygenLevel();
            }

            if (gaugesData.getSetUpOxygen() && gaugesData.getOxygenLevel() <= 0)
            {
                FuelLevelButton.Visible = true;
            }
        }

        private void GaugesTimer_Tick(object sender, EventArgs e)
        {
            if (!gaugesData.getFirstRefuel())
            {
                gaugesData.setPlaneSpeed(activeGauges.determineSafeSpeed(gaugesData.getPlaneSpeed(), 50, 801));
                aGauge1.Value = gaugesData.getPlaneSpeed();

                gaugesData.setPlaneAltitude(activeGauges.determineSafeAltitude());
                aGauge2.Value = gaugesData.getPlaneAltitude();

                if (float.Parse(meteorologicalData.meteorologicalDataStruct.getAirPressure()) >= 100)
                {
                    gaugesData.setOxygenLevel(float.Parse(meteorologicalData.meteorologicalDataStruct.getAirPressure()));
                    aGauge4.Value = gaugesData.getOxygenLevel();
                }
                else
                {
                    gaugesData.setOxygenLevel(activeGauges.determineSafeOxygenLevel(float.Parse(meteorologicalData.meteorologicalDataStruct.getAirPressure()), aGauge4.MaxValue));
                    aGauge4.Value = gaugesData.getOxygenLevel();
                }
            }


            if (gaugesData.getFuelLevel() <= 20)
            {
                FuelLevelButton.Enabled = true;
                lblPlaneRefuel.Text = "Fuel Level: Critical";
                lblPlaneRefuel.ForeColor = Color.Red;
            }
            if (gaugesData.getFuelLevel() > 20)
            {
                FuelLevelButton.Enabled = false;


            }
            if (gaugesData.getFuelLevel() >= 50 && gaugesData.getFuelLevel() <= 100)
            {
                lblPlaneRefuel.Text = "Fuel Level: Stable";
                lblPlaneRefuel.ForeColor = Color.Green;
            }
            else if (gaugesData.getFuelLevel() >= 21 && gaugesData.getFuelLevel() <= 49)
            {
                lblPlaneRefuel.Text = "Fuel Level: Low";
                lblPlaneRefuel.ForeColor = Color.Orange;
            }

            if (RefuelTimer.Enabled == false)
            {
                if (gaugesData.getFuelLevel() > 0)
                {
                    gaugesData.setFuelLevel(activeGauges.dedtermineFuelEfficiency(gaugesData.getFuelLevel(), -0.25F));
                    aGauge3.Value = gaugesData.getFuelLevel();
                }
            }
        }

        private void btnAirPressure_Click(object sender, EventArgs e)
        {
            if (airPressureTimer.Enabled)
            {
                airPressureTimer.Stop();
            }
            airPressureUpTimer.Start();
        }

        private void airPressureUpTimer_Tick(object sender, EventArgs e)
        {
            meteorologicalData.meteorologicalDataStruct.setAirPressure(meteorologicalData.buttonGoUpPressure());
            meteorologicalData.meteorologicalDataStruct.setAirPressureValues(meteorologicalData.obtainNewAirPressureMessage(int.Parse(meteorologicalData.meteorologicalDataStruct.getAirPressure())));
            txtAirPressure.Text = meteorologicalData.meteorologicalDataStruct.getAirPressure().ToString();

            if (meteorologicalData.meteorologicalDataStruct.getAirPressureValues() == AirPressureValues.Stable || meteorologicalData.meteorologicalDataStruct.getAirPressureValues() == AirPressureValues.Normal)
            {
                txtAirPressure.BackColor = Color.Green;
                lbAirPressure.ForeColor = Color.Green;
                lbAirPressure.Text = "Air Pressure: Stable";
                btnAirPressure.Enabled = false;
                btnAirPressure.Visible = false;
            }
            else if (meteorologicalData.meteorologicalDataStruct.getAirPressureValues() == AirPressureValues.Low)
            {
                txtAirPressure.BackColor = Color.Orange;
                lbAirPressure.ForeColor = Color.Orange;
                lbAirPressure.Text = "Air Pressure: Low";
                btnAirPressure.Enabled = true;
                btnAirPressure.Visible = true;
            }
            else if (meteorologicalData.meteorologicalDataStruct.getAirPressureValues() == AirPressureValues.Danger || meteorologicalData.meteorologicalDataStruct.getAirPressureValues() == AirPressureValues.Critical)
            {
                txtAirPressure.BackColor = Color.Red;
                lbAirPressure.ForeColor = Color.Red;
                lbAirPressure.Text = "Air Pressure: Critical";
                btnAirPressure.Enabled = true;
                btnAirPressure.Visible = true;
            }


            if (int.Parse(txtAirPressure.Text) >= 100)
            {
                airPressureUpTimer.Stop();
                airPressureTimer.Start();
            }
        }

        private void FuelLevelButton_Click(object sender, EventArgs e)
        {
            if (gaugesData.getFirstRefuel())
            {
                FuelLevelButton.Enabled = false;
            }


            RefuelTimer.Start();
            StartUpTimer.Stop();
        }

        private void RefuelTimer_Tick(object sender, EventArgs e)
        {
            gaugesData.setFuelLevel(activeGauges.dedtermineFuelEfficiency(gaugesData.getFuelLevel(), 5));
            aGauge3.Value = gaugesData.getFuelLevel();



            if (gaugesData.getFuelLevel() >= 100 && gaugesData.getFirstRefuel())
            {
                FuelLevelButton.Enabled = false;
                gaugesData.setFirstRefuel(false);
                RefuelTimer.Stop();
                btnStartPlane.Visible = true;
                lblDefaultMessage.Text = "Lock doors to start";
                lblPlaneRefuel.Text = "Fuel Level: Stable";
                lblPlaneRefuel.ForeColor = Color.Green;
                lbDoor.ForeColor = Color.Red;
                changeImage();
                LockDoors.Visible = true;
                lbDoor.Visible = true;


            }
            else if ((gaugesData.getFuelLevel() >= 100 && !gaugesData.getFirstRefuel()))
            {

                FuelLevelButton.Enabled = false;

                RefuelTimer.Stop();
            }

        }

        private void AutoPilotTimerTick(object sender, EventArgs e)
        {
            if (statusUpdatesDataStruct.getCockpitDoor() == false)
            {
                if (pictureBox1.Image != Properties.Resources.plane1_Bad_CPdoor)
                {
                    AutoPilot.Enabled = false;
                    lbAutoPilot.Text = "Lock Doors";
                    lbDoor.Text = "Doors Unlocked";
                    lbDoor.ForeColor = Color.Red;
                }

                if (statusUpdatesDataStruct.getAutoPilot() == false)
                {
                    lbAutoPilot.Text = "Auto Pilot Disengaged";
                    pictureBox1.Image = Properties.Resources.plane1_Bad_CPdoor;
                    lbAutoPilot.ForeColor = Color.Black;
                    LockDoors.Enabled = true;
                    AutoPilot.Enabled = false;
                    btnLeft45.Enabled = true;
                    btnLeft90.Enabled = true;
                    btnRight45.Enabled = true;
                    btnRight90.Enabled = true;
                    AutoPilotTimer.Stop();
                }
            }

        }

        private void btnStartPlane_Click(object sender, EventArgs e)
        {
            if (lbDoor.Text == "Doors Locked")
            {
                planeTakingOffTimer.Start();
                progressBarTimer.Start();
                lblPercentageLeft.Visible = true;
                lblPercentageLeft.Text = "0%";
                lblDefaultMessage.Text = "Plane is currently taking off...";
                lblPlaneTakeoff.Visible = true;
                planeProgressBar.Visible = true;
                lblDefaultMessage.ForeColor = Color.Orange;
                btnStartPlane.Enabled = false;
            }
            else
            {
                lblDefaultMessage.Text = "Lock doors to start";
                lbDoor.Text = "Doors must be locked";

            }
        }

        private void planeTakingOffTimer_Tick(object sender, EventArgs e)
        {
            //Enabling Buttons
            AutoPilot.Enabled = true;
            AutoPilot.Visible = true;
            lbAutoPilot.Visible = true;
            btnRight45.Enabled = true;
            btnRight90.Enabled = true;
            btnLeft90.Enabled = true;
            btnLeft45.Enabled = true;
            btnStartPlane.Enabled = false;

            btnLeft45.ForeColor = Color.Green;
            btnLeft90.ForeColor = Color.Green;
            btnRight45.ForeColor = Color.Green;
            btnRight90.ForeColor = Color.Green;

            //Setting labels
            lblDefaultMessage.ForeColor = Color.Green;
            lblDefaultMessage.Text = "Plane in motion";
            lbDoor.Text = "Doors Locked";

            //Starting all program timers
            GaugesTimer.Enabled = true;
            weatherTimer.Start();

            airPressureTimer.Start();
            latitudeLongitudeTimer.Start();
            changingLocationTimer.Start();
            //dateTimeTimer.Start();
            estimatedTimeTimer.Start();
            planeTakingOffTimer.Stop();

            

        }

        private void progressBarTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter <= 100)
            {
                planeProgressBar.Value += 1;
                lblPercentageLeft.Text = planeProgressBar.Value.ToString() + "%";
            }
            if (counter == 101)
            {
                lblPlaneTakeoff.Visible = false;
                planeProgressBar.Visible = false;
                lblPercentageLeft.Visible = false;
                progressBarTimer.Stop();
            }
            if(counter >= 0 && counter <= 33)
            {
                lblPercentageLeft.ForeColor = Color.Red;
            }
            if (counter >= 34 && counter <= 67)
            {
                lblPercentageLeft.ForeColor = Color.Orange;
            }
            if (counter >= 68 && counter <= 100)
            {
                lblPercentageLeft.ForeColor = Color.Green;
            }

        }

        private void autoPilotBarTimer_Tick(object sender, EventArgs e)
        {
            autopilotProgressBar.Value -= 1;
            if(autopilotProgressBar.Value == 0)
            {
                autopilotProgressBar.Visible = false;
                autopilotProgressBar.Value = 106;
                autopilotProgressBar.Visible = false;
                autoPilotBarTimer.Stop();
                
            }
        }
    }
}


