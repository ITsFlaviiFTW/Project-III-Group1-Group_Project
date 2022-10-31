using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_III_Group1_Group_Project
{
    public partial class Form1 : Form
    {
        int i = 1;
        public Form1()
        {
            InitializeComponent();
            changeImage(i);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // pre-existing flight information here
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

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

    }
}
