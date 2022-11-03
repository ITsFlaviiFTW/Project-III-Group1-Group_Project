using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_III_Group1_Group_Project
{
    public partial class flightInformation : Form
    {
        public Plane currentFlight { get; set; }
        public flightInformation()
        {
            InitializeComponent();
        }

        private void flightInformation_Load(object sender, EventArgs e)
        {
            txtPlaneName.Text = currentFlight.planeName;
            txtPilotFirstName.Text = currentFlight.pilotFirstName;
            txtPilotLastName.Text = currentFlight.pilotLastName;
            txtPlaneCapacity.Text = currentFlight.planeCapacity.ToString();
            txtFlightStartingLocation.Text = currentFlight.startingLocation;
            txtFlightDestination.Text = currentFlight.destination;
            txtFlightDepatureTime.Text = currentFlight.departureTime;
            txtFlightArrivalTime.Text = currentFlight.arrivalTime;
        }

        private void btnSubmitFlightEdits_Click(object sender, EventArgs e)
        {          
            try
            {
                foreach (Control c in this.Controls)
                {
                    if(c.GetType().ToString() == "System.Windows.Forms.TextBox")
                    {
                        if (c.Text == "")
                        {
                            throw new Exception("There was an error when updating your flight. Please note: Textboxes cannot be empty ");
                        }
                    }                   
                }
                if (!int.TryParse(txtPlaneCapacity.Text, out int planeCapacity))
                {
                    throw new Exception("There was an error when updating your flight. Please note: Capacity must be a whole number");
                }

                currentFlight.planeName = txtPlaneName.Text.Trim();
                currentFlight.pilotFirstName = txtPilotFirstName.Text.Trim();
                currentFlight.pilotLastName = txtPilotLastName.Text.Trim();
                currentFlight.planeCapacity = planeCapacity;
                currentFlight.startingLocation = txtFlightStartingLocation.Text.Trim();
                currentFlight.destination = txtFlightDepatureTime.Text.Trim();
                currentFlight.departureTime = txtFlightDepatureTime.Text.Trim();
                currentFlight.arrivalTime = txtFlightArrivalTime.Text.Trim();
                DialogResult res = MessageBox.Show("Your flight has been updated! Now returning to the main application screen", "Flight Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)             
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
