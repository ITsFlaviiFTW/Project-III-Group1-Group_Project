using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Project_III_Group1_Group_Project
{

    public partial class Form1 : Form
    {
        Meteorological meteorologicalData;
        MeteorologicalData meteorologicalDataStruct = new MeteorologicalData();
        
        string filePath = "Resources\\flights.txt";
        Random random = new Random();
        public Plane currentFlight { get; set; }
        public
        int i = 1;
        int weatherimageNum = 0;
        int tempimageNum = 0;
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
                currentFlight = new Plane(flightToUse[0], flightToUse[1], flightToUse[2], int.Parse(flightToUse[3]), flightToUse[4], flightToUse[5], flightToUse[6], flightToUse[7]);
                MeteorologicalSetup();
            }
            catch (Exception)
            {
                DialogResult res = MessageBox.Show("There was an error getting your flight information, now closing the program", "Flight Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        private void MeteorologicalSetup()
        {
            meteorologicalDataStruct.setAirPressure("100");
            meteorologicalDataStruct.setAirPressureValues(AirPressureValues.Stable);
            meteorologicalDataStruct.setWeather("Resources\\weatherImages\\0.png");
            meteorologicalDataStruct.setTemperature("Resources\\tempImages\\0.png");
            weatherPictureBox.ImageLocation = meteorologicalDataStruct.getWeather();
            temperaturePictureBox.ImageLocation = meteorologicalDataStruct.getTemperature();
            farrenheitSymbolPictureBox.Image = Image.FromFile("Resources\\farrenheit-resized.png");
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
            Meteorological meteorologicalData = new Meteorological(meteorologicalDataStruct);
            txtAirPressure.Enabled = true;
            meteorologicalData.meteorologicalDataStruct.setAirPressure(meteorologicalData.obtainNewAirPressure());
            meteorologicalData.meteorologicalDataStruct.setAirPressureValues(meteorologicalData.obtainNewAirPressureMessage(int.Parse(meteorologicalData.meteorologicalDataStruct.getAirPressure())));
            txtAirPressure.Text = meteorologicalData.meteorologicalDataStruct.getAirPressure().ToString();

            if (meteorologicalData.meteorologicalDataStruct.getAirPressureValues() == AirPressureValues.Stable || meteorologicalData.meteorologicalDataStruct.getAirPressureValues() == AirPressureValues.Normal)
            {
                txtAirPressure.BackColor = Color.Green;
                lbAirPressure.Text = "Air Pressure: Stable";
                btnAirPressure.Enabled = false;
                btnAirPressure.Visible = false;
            }
            else if (meteorologicalData.meteorologicalDataStruct.getAirPressureValues() == AirPressureValues.Low)
            {
                txtAirPressure.BackColor = Color.Yellow;
                lbAirPressure.Text = "Air Pressure: Low";
                btnAirPressure.Enabled = true;
                btnAirPressure.Visible = true;
            }
            else if (meteorologicalData.meteorologicalDataStruct.getAirPressureValues() == AirPressureValues.Danger || meteorologicalData.meteorologicalDataStruct.getAirPressureValues() == AirPressureValues.Critical)
            {
                txtAirPressure.BackColor = Color.Red;
                lbAirPressure.Text = "Air Pressure: Critical";
                btnAirPressure.Enabled = true;
                btnAirPressure.Visible = true;
            }
        }

    }
}

