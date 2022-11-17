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
        GeoLocation locationData;
        public Plane currentFlight { get; set; }
        PlaneData planeDataStruct = new PlaneData();
        LocationData locationDataStruct = new LocationData();
        string filePath = "Resources\\flights.txt";
        Random random = new Random();
        int i = 1;

        public Form1()
        {
            InitializeComponent();
            changeImage(i);
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

                //Assign objects with created structs
                currentFlight = new Plane(planeDataStruct);

                //Sets up everything regarding GeoLocation
                GeoLocationSetup();
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.Message.ToString(), "Flight Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                                       
                Environment.Exit(1);                             
            }
        }
        private void aGauge1_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            aGauge1.Value = trackBar1.Value; // gauge slider functionality 
        }

        private void GoBack(object sender, EventArgs e)
        {
            i--;
            if (i < 1)
            {
                i = 2;
            }
            changeImage(i);

        }

        private void GoNext(object sender, EventArgs e)
        {
            i++;
            if (i > 2)
            {
                i = 1;
            }
            changeImage(i);

        }
        private void changeImage(int num)
        {

            switch (num)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.plane1_Bad_CPdoor;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.plane1;
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

        private void latitudeLongitudeTimer_Tick(object sender, EventArgs e)
        {             
            if(locationData.locationDataStruct.getCompassBearing() == CompassBearing.N || locationData.locationDataStruct.getCompassBearing() == CompassBearing.S)
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

            foreach(Button button in grpBoxPlaneTurning.Controls)
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

            if(locationData.locationDataStruct.getCurrCountry() == "CAN")
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
            locationDataStruct.setCurrEstimatedArrivalTime(DateTime.Now);
            locationDataStruct.setCurrProvinceState(currentFlight.planeData.getStartingLocation());           
            if(locationDataStruct.getCurrProvinceState() == "Toronto")
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

            //Starting needed timers
            latitudeLongitudeTimer.Start();
            changingLocationTimer.Start();
            dateTimeTimer.Start();
       
            //Setting default GUI information
            lblCompassBearing.Text = locationData.locationDataStruct.getCompassBearing().ToString();
            lblProvinceStateInfo.Text = locationData.locationDataStruct.getCurrProvinceState().ToString();
        }

        private void dateTimeTimer_Tick(object sender, EventArgs e)
        {
            locationData.locationDataStruct.setCurrEstimatedArrivalTime(DateTime.Now);
            lblTimeLeft.Text = DateTime.Now.ToString();
            lblCurrentTimeLeft.Text = locationData.locationDataStruct.getCurrEstimatedArrivalTime().ToString();
        }

      
    }
}
