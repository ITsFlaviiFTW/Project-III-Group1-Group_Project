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
            txtPlaneName.Text = currentFlight.planeData.getPlaneName();
            txtPilotFirstName.Text = currentFlight.planeData.getPilotFirstName();
            txtPilotLastName.Text = currentFlight.planeData.getPilotLastName();
            txtPlaneCapacity.Text = currentFlight.planeData.getPlaneCapacity().ToString();
            txtFlightStartingLocation.Text = currentFlight.planeData.getStartingLocation();
            txtFlightDestination.Text = currentFlight.planeData.getDestination();
            txtFlightDepatureTime.Text = currentFlight.planeData.getDepartureTime();
            txtFlightArrivalTime.Text = currentFlight.planeData.getArrivalTime();
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

                currentFlight.planeData.setPlaneName(txtPlaneName.Text.Trim());
                currentFlight.planeData.setPilotFirstName(txtPilotFirstName.Text.Trim()); 
                currentFlight.planeData.setPilotLastName(txtPilotLastName.Text.Trim()); 
                currentFlight.planeData.setPlaneCapacity(int.Parse(txtPlaneCapacity.Text.Trim())); 
                currentFlight.planeData.setStartingLocation(txtFlightStartingLocation.Text.Trim()); 
                currentFlight.planeData.setDestination(txtFlightDestination.Text.Trim()); 
                currentFlight.planeData.setDepartureTime(txtFlightDepatureTime.Text.Trim()); 
                currentFlight.planeData.setArrivialTime(txtFlightArrivalTime.Text.Trim());                     
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
