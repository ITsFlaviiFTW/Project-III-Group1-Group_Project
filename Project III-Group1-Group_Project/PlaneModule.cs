﻿using System;
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
        
        MeteorologicalData meteorologicalData = new MeteorologicalData();
        string weatherImagePath = "Resources\\weatherID.txt";
        string filePath = "Resources\\flights.txt";
        Random random = new Random();
        public Plane currentFlight { get; set; }
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
            }
            catch(Exception)
            {
                DialogResult res = MessageBox.Show("There was an error getting your flight information, now closing the program", "Flight Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                                       
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

        private void weatherPictureBox_Click(object sender, EventArgs e)
        {
           
        }
        
        private void weatherTimer_Tick(object sender, EventArgs e)
        {
            /*  
              farrenheitSymbolPictureBox.Image = Image.FromFile("Resources\\farrenheit-resized.png");
              weatherPictureBox.Image = weatherImageList.Images[weatherimageNum];
              if (weatherimageNum == weatherImageList.Images.Count - 1) 
              {
                  weatherimageNum = 0;
              }
              else
              {
                  weatherimageNum++;
              }
              temperaturePictureBox.Image = temperatureImageList.Images[tempimageNum];
              if (tempimageNum == temperatureImageList.Images.Count - 1)
              {
                  tempimageNum = 0;
              }
              else
              {
                  tempimageNum++;
              }
            */

        }

        private void temperaturePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void farrenheitSymbolPictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void airPressureGauge_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }
    }
}
