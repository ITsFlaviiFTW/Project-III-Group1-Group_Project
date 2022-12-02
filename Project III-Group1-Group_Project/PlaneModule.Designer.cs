using System.Windows.Forms;

namespace Project_III_Group1_Group_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LockDoors = new System.Windows.Forms.Button();
            this.AutoPilot = new System.Windows.Forms.Button();
            this.btnViewFlightInformation = new System.Windows.Forms.Button();
            this.weatherTimer = new System.Windows.Forms.Timer(this.components);
            this.weatherImageList = new System.Windows.Forms.ImageList(this.components);
            this.temperatureImageList = new System.Windows.Forms.ImageList(this.components);
            this.temperaturePictureBox = new System.Windows.Forms.PictureBox();
            this.weatherPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.farrenheitSymbolPictureBox = new System.Windows.Forms.PictureBox();
            this.grpBoxAirPressure = new System.Windows.Forms.GroupBox();
            this.btnAirPressure = new System.Windows.Forms.Button();
            this.lbAirPressure = new System.Windows.Forms.Label();
            this.txtAirPressure = new System.Windows.Forms.TextBox();
            this.airPressureTimer = new System.Windows.Forms.Timer(this.components);
            this.latitudeLongitudeTimer = new System.Windows.Forms.Timer(this.components);
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.grpBoxCoordinateDetails = new System.Windows.Forms.GroupBox();
            this.lblCompassBearing = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlaneIsTurning = new System.Windows.Forms.Label();
            this.grpBoxPlaneTurning = new System.Windows.Forms.GroupBox();
            this.btnRight90 = new System.Windows.Forms.Button();
            this.btnLeft90 = new System.Windows.Forms.Button();
            this.btnLeft45 = new System.Windows.Forms.Button();
            this.btnRight45 = new System.Windows.Forms.Button();
            this.turningPlaneTimer = new System.Windows.Forms.Timer(this.components);
            this.changingLocationTimer = new System.Windows.Forms.Timer(this.components);
            this.grpBoxLocation = new System.Windows.Forms.GroupBox();
            this.picBoxCountry = new System.Windows.Forms.PictureBox();
            this.lblProvinceStateInfo = new System.Windows.Forms.Label();
            this.lblProvinceState = new System.Windows.Forms.Label();
            this.lblFlightTimeRemaining = new System.Windows.Forms.Label();
            this.grpBoxTimeDetails = new System.Windows.Forms.GroupBox();
            this.lblCurrentDateTime = new System.Windows.Forms.Label();
            this.lblEstimatedTimeLeft = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.dateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.estimatedTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.StartUpTimer = new System.Windows.Forms.Timer(this.components);
            this.GaugesTimer = new System.Windows.Forms.Timer(this.components);
            this.airPressureUpTimer = new System.Windows.Forms.Timer(this.components);
            this.FuelLevelButton = new System.Windows.Forms.Button();
            this.RefuelTimer = new System.Windows.Forms.Timer(this.components);
            this.lbAutoPilot = new System.Windows.Forms.Label();
            this.lbDoor = new System.Windows.Forms.Label();
            this.AutoPilotTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStartPlane = new System.Windows.Forms.Button();
            this.lblDefaultMessage = new System.Windows.Forms.Label();
            this.planeTakingOffTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.aGauge3 = new System.Windows.Forms.AGauge();
            this.aGauge2 = new System.Windows.Forms.AGauge();
            this.aGauge4 = new System.Windows.Forms.AGauge();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPlaneRefuel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblGreenTriangle = new System.Windows.Forms.Label();
            this.lblUnlockedDoor = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblNotMonitored = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.temperaturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farrenheitSymbolPictureBox)).BeginInit();
            this.grpBoxAirPressure.SuspendLayout();
            this.grpBoxCoordinateDetails.SuspendLayout();
            this.grpBoxPlaneTurning.SuspendLayout();
            this.grpBoxLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCountry)).BeginInit();
            this.grpBoxTimeDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // LockDoors
            // 
            this.LockDoors.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockDoors.Location = new System.Drawing.Point(863, 369);
            this.LockDoors.Name = "LockDoors";
            this.LockDoors.Size = new System.Drawing.Size(178, 58);
            this.LockDoors.TabIndex = 7;
            this.LockDoors.Text = "Lock Doors";
            this.LockDoors.UseVisualStyleBackColor = true;
            this.LockDoors.Visible = false;
            this.LockDoors.Click += new System.EventHandler(this.GoBack);
            // 
            // AutoPilot
            // 
            this.AutoPilot.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoPilot.Location = new System.Drawing.Point(863, 162);
            this.AutoPilot.Name = "AutoPilot";
            this.AutoPilot.Size = new System.Drawing.Size(178, 59);
            this.AutoPilot.TabIndex = 9;
            this.AutoPilot.Text = "Auto Pilot";
            this.AutoPilot.UseVisualStyleBackColor = true;
            this.AutoPilot.Visible = false;
            this.AutoPilot.Click += new System.EventHandler(this.GoNext);
            // 
            // btnViewFlightInformation
            // 
            this.btnViewFlightInformation.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFlightInformation.Location = new System.Drawing.Point(3, 24);
            this.btnViewFlightInformation.Name = "btnViewFlightInformation";
            this.btnViewFlightInformation.Size = new System.Drawing.Size(122, 59);
            this.btnViewFlightInformation.TabIndex = 11;
            this.btnViewFlightInformation.Text = "View current flight information";
            this.btnViewFlightInformation.UseVisualStyleBackColor = true;
            this.btnViewFlightInformation.Click += new System.EventHandler(this.btnViewFlightInformation_Click);
            // 
            // weatherTimer
            // 
            this.weatherTimer.Interval = 20000;
            this.weatherTimer.Tick += new System.EventHandler(this.weatherTimer_Tick);
            // 
            // weatherImageList
            // 
            this.weatherImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("weatherImageList.ImageStream")));
            this.weatherImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.weatherImageList.Images.SetKeyName(0, "sunny.png");
            this.weatherImageList.Images.SetKeyName(1, "cloudy_with_sun.png");
            this.weatherImageList.Images.SetKeyName(2, "cloudy_icon.png");
            this.weatherImageList.Images.SetKeyName(3, "windy_icon.png");
            this.weatherImageList.Images.SetKeyName(4, "rain_icon.png");
            this.weatherImageList.Images.SetKeyName(5, "snow_icon.png");
            this.weatherImageList.Images.SetKeyName(6, "snow_night_icon.png");
            this.weatherImageList.Images.SetKeyName(7, "rain_night_incon.png");
            this.weatherImageList.Images.SetKeyName(8, "windy_night_icon.png");
            this.weatherImageList.Images.SetKeyName(9, "night_icon.png");
            // 
            // temperatureImageList
            // 
            this.temperatureImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("temperatureImageList.ImageStream")));
            this.temperatureImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.temperatureImageList.Images.SetKeyName(0, "sunny temperature.png");
            this.temperatureImageList.Images.SetKeyName(1, "cloudy with sun temperature 2.png");
            this.temperatureImageList.Images.SetKeyName(2, "cloudy temperature 2.png");
            this.temperatureImageList.Images.SetKeyName(3, "windy temperature 2.png");
            this.temperatureImageList.Images.SetKeyName(4, "rainy temperature 2.png");
            this.temperatureImageList.Images.SetKeyName(5, "snowy temperature 2.png");
            this.temperatureImageList.Images.SetKeyName(6, "night snowy temperature.png");
            this.temperatureImageList.Images.SetKeyName(7, "night rainy temperature.png");
            this.temperatureImageList.Images.SetKeyName(8, "night windy temperature.png");
            this.temperatureImageList.Images.SetKeyName(9, "night temperature.png");
            this.temperatureImageList.Images.SetKeyName(10, "sunny temperature 2.png");
            this.temperatureImageList.Images.SetKeyName(11, "cloudy with sun temperature.png");
            this.temperatureImageList.Images.SetKeyName(12, "cloudy temperature.png");
            this.temperatureImageList.Images.SetKeyName(13, "windy temperature.png");
            this.temperatureImageList.Images.SetKeyName(14, "rainy temperature.png");
            this.temperatureImageList.Images.SetKeyName(15, "snowy temperature.png");
            this.temperatureImageList.Images.SetKeyName(16, "night snowy temperature 2.png");
            this.temperatureImageList.Images.SetKeyName(17, "night rainy temperature 2.png");
            this.temperatureImageList.Images.SetKeyName(18, "night windy temperature 2.png");
            this.temperatureImageList.Images.SetKeyName(19, "night temperature 2.png");
            // 
            // temperaturePictureBox
            // 
            this.temperaturePictureBox.Location = new System.Drawing.Point(52, 130);
            this.temperaturePictureBox.Name = "temperaturePictureBox";
            this.temperaturePictureBox.Size = new System.Drawing.Size(54, 44);
            this.temperaturePictureBox.TabIndex = 13;
            this.temperaturePictureBox.TabStop = false;
            this.temperaturePictureBox.Click += new System.EventHandler(this.temperaturePictureBox_Click);
            // 
            // weatherPictureBox
            // 
            this.weatherPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.weatherPictureBox.Location = new System.Drawing.Point(6, 19);
            this.weatherPictureBox.Name = "weatherPictureBox";
            this.weatherPictureBox.Size = new System.Drawing.Size(100, 100);
            this.weatherPictureBox.TabIndex = 12;
            this.weatherPictureBox.TabStop = false;
            this.weatherPictureBox.Click += new System.EventHandler(this.weatherPictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_III_Group1_Group_Project.Properties.Resources.plane1_Bad_door4;
            this.pictureBox1.Location = new System.Drawing.Point(248, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // farrenheitSymbolPictureBox
            // 
            this.farrenheitSymbolPictureBox.Location = new System.Drawing.Point(6, 135);
            this.farrenheitSymbolPictureBox.Name = "farrenheitSymbolPictureBox";
            this.farrenheitSymbolPictureBox.Size = new System.Drawing.Size(30, 30);
            this.farrenheitSymbolPictureBox.TabIndex = 14;
            this.farrenheitSymbolPictureBox.TabStop = false;
            this.farrenheitSymbolPictureBox.Click += new System.EventHandler(this.farrenheitSymbolPictureBox_Click);
            // 
            // grpBoxAirPressure
            // 
            this.grpBoxAirPressure.Controls.Add(this.btnAirPressure);
            this.grpBoxAirPressure.Controls.Add(this.lbAirPressure);
            this.grpBoxAirPressure.Controls.Add(this.txtAirPressure);
            this.grpBoxAirPressure.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAirPressure.Location = new System.Drawing.Point(4, 361);
            this.grpBoxAirPressure.Name = "grpBoxAirPressure";
            this.grpBoxAirPressure.Size = new System.Drawing.Size(152, 136);
            this.grpBoxAirPressure.TabIndex = 15;
            this.grpBoxAirPressure.TabStop = false;
            this.grpBoxAirPressure.Text = "Air Pressure";
            // 
            // btnAirPressure
            // 
            this.btnAirPressure.ForeColor = System.Drawing.Color.Green;
            this.btnAirPressure.Location = new System.Drawing.Point(25, 83);
            this.btnAirPressure.Name = "btnAirPressure";
            this.btnAirPressure.Size = new System.Drawing.Size(102, 35);
            this.btnAirPressure.TabIndex = 2;
            this.btnAirPressure.Text = "Pressurize";
            this.btnAirPressure.UseVisualStyleBackColor = true;
            this.btnAirPressure.Visible = false;
            this.btnAirPressure.Click += new System.EventHandler(this.btnAirPressure_Click);
            // 
            // lbAirPressure
            // 
            this.lbAirPressure.AutoSize = true;
            this.lbAirPressure.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAirPressure.ForeColor = System.Drawing.Color.Green;
            this.lbAirPressure.Location = new System.Drawing.Point(7, 64);
            this.lbAirPressure.Name = "lbAirPressure";
            this.lbAirPressure.Size = new System.Drawing.Size(128, 16);
            this.lbAirPressure.TabIndex = 1;
            this.lbAirPressure.Text = "Air Pressure: Stable";
            // 
            // txtAirPressure
            // 
            this.txtAirPressure.BackColor = System.Drawing.Color.Green;
            this.txtAirPressure.Location = new System.Drawing.Point(22, 19);
            this.txtAirPressure.Name = "txtAirPressure";
            this.txtAirPressure.ReadOnly = true;
            this.txtAirPressure.Size = new System.Drawing.Size(45, 25);
            this.txtAirPressure.TabIndex = 0;
            this.txtAirPressure.Text = "100";
            // 
            // airPressureTimer
            // 
            this.airPressureTimer.Interval = 500;
            this.airPressureTimer.Tick += new System.EventHandler(this.airPressureTimer_Tick);
            // 
            // latitudeLongitudeTimer
            // 
            this.latitudeLongitudeTimer.Tick += new System.EventHandler(this.latitudeLongitudeTimer_Tick);
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.Location = new System.Drawing.Point(7, 22);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(58, 15);
            this.lblLatitude.TabIndex = 12;
            this.lblLatitude.Text = "Latitude: ";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitude.Location = new System.Drawing.Point(7, 46);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(68, 15);
            this.lblLongitude.TabIndex = 13;
            this.lblLongitude.Text = "Longitude: ";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitude.Location = new System.Drawing.Point(87, 17);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.ReadOnly = true;
            this.txtLatitude.Size = new System.Drawing.Size(77, 23);
            this.txtLatitude.TabIndex = 14;
            this.txtLatitude.Text = "0.000000";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitude.Location = new System.Drawing.Point(87, 46);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.ReadOnly = true;
            this.txtLongitude.Size = new System.Drawing.Size(77, 23);
            this.txtLongitude.TabIndex = 15;
            this.txtLongitude.Text = "0.000000";
            // 
            // grpBoxCoordinateDetails
            // 
            this.grpBoxCoordinateDetails.Controls.Add(this.lblCompassBearing);
            this.grpBoxCoordinateDetails.Controls.Add(this.label1);
            this.grpBoxCoordinateDetails.Controls.Add(this.txtLatitude);
            this.grpBoxCoordinateDetails.Controls.Add(this.txtLongitude);
            this.grpBoxCoordinateDetails.Controls.Add(this.lblLatitude);
            this.grpBoxCoordinateDetails.Controls.Add(this.lblLongitude);
            this.grpBoxCoordinateDetails.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxCoordinateDetails.Location = new System.Drawing.Point(3, 100);
            this.grpBoxCoordinateDetails.Name = "grpBoxCoordinateDetails";
            this.grpBoxCoordinateDetails.Size = new System.Drawing.Size(208, 99);
            this.grpBoxCoordinateDetails.TabIndex = 16;
            this.grpBoxCoordinateDetails.TabStop = false;
            this.grpBoxCoordinateDetails.Text = "Coordinate Details";
            // 
            // lblCompassBearing
            // 
            this.lblCompassBearing.AutoSize = true;
            this.lblCompassBearing.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompassBearing.ForeColor = System.Drawing.Color.Green;
            this.lblCompassBearing.Location = new System.Drawing.Point(176, 72);
            this.lblCompassBearing.Name = "lblCompassBearing";
            this.lblCompassBearing.Size = new System.Drawing.Size(0, 16);
            this.lblCompassBearing.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Current Compass Bearing: ";
            // 
            // lblPlaneIsTurning
            // 
            this.lblPlaneIsTurning.AutoSize = true;
            this.lblPlaneIsTurning.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneIsTurning.ForeColor = System.Drawing.Color.Red;
            this.lblPlaneIsTurning.Location = new System.Drawing.Point(10, 309);
            this.lblPlaneIsTurning.Name = "lblPlaneIsTurning";
            this.lblPlaneIsTurning.Size = new System.Drawing.Size(0, 19);
            this.lblPlaneIsTurning.TabIndex = 19;
            // 
            // grpBoxPlaneTurning
            // 
            this.grpBoxPlaneTurning.Controls.Add(this.btnRight90);
            this.grpBoxPlaneTurning.Controls.Add(this.btnLeft90);
            this.grpBoxPlaneTurning.Controls.Add(this.btnLeft45);
            this.grpBoxPlaneTurning.Controls.Add(this.btnRight45);
            this.grpBoxPlaneTurning.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxPlaneTurning.Location = new System.Drawing.Point(4, 205);
            this.grpBoxPlaneTurning.Name = "grpBoxPlaneTurning";
            this.grpBoxPlaneTurning.Size = new System.Drawing.Size(208, 101);
            this.grpBoxPlaneTurning.TabIndex = 17;
            this.grpBoxPlaneTurning.TabStop = false;
            this.grpBoxPlaneTurning.Text = "Plane Turning Control Panel";
            // 
            // btnRight90
            // 
            this.btnRight90.Enabled = false;
            this.btnRight90.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight90.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRight90.Location = new System.Drawing.Point(106, 64);
            this.btnRight90.Name = "btnRight90";
            this.btnRight90.Size = new System.Drawing.Size(91, 34);
            this.btnRight90.TabIndex = 21;
            this.btnRight90.Text = "Turn Right 90°";
            this.btnRight90.UseVisualStyleBackColor = true;
            this.btnRight90.Click += new System.EventHandler(this.btnRight90_Click);
            // 
            // btnLeft90
            // 
            this.btnLeft90.Enabled = false;
            this.btnLeft90.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft90.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLeft90.Location = new System.Drawing.Point(10, 64);
            this.btnLeft90.Name = "btnLeft90";
            this.btnLeft90.Size = new System.Drawing.Size(91, 34);
            this.btnLeft90.TabIndex = 20;
            this.btnLeft90.Text = "Turn Left 90°";
            this.btnLeft90.UseVisualStyleBackColor = true;
            this.btnLeft90.Click += new System.EventHandler(this.btnLeft90_Click);
            // 
            // btnLeft45
            // 
            this.btnLeft45.Enabled = false;
            this.btnLeft45.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft45.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLeft45.Location = new System.Drawing.Point(10, 24);
            this.btnLeft45.Name = "btnLeft45";
            this.btnLeft45.Size = new System.Drawing.Size(91, 34);
            this.btnLeft45.TabIndex = 18;
            this.btnLeft45.Text = "Turn Left 45°";
            this.btnLeft45.UseVisualStyleBackColor = true;
            this.btnLeft45.Click += new System.EventHandler(this.btnLeft45_Click);
            // 
            // btnRight45
            // 
            this.btnRight45.Enabled = false;
            this.btnRight45.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight45.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRight45.Location = new System.Drawing.Point(106, 24);
            this.btnRight45.Name = "btnRight45";
            this.btnRight45.Size = new System.Drawing.Size(91, 34);
            this.btnRight45.TabIndex = 19;
            this.btnRight45.Text = "Turn Right 45°";
            this.btnRight45.UseVisualStyleBackColor = true;
            this.btnRight45.Click += new System.EventHandler(this.btnRight45_Click);
            // 
            // turningPlaneTimer
            // 
            this.turningPlaneTimer.Tick += new System.EventHandler(this.turningPlaneTimer_Tick);
            // 
            // changingLocationTimer
            // 
            this.changingLocationTimer.Interval = 30000;
            this.changingLocationTimer.Tick += new System.EventHandler(this.changingLocationTimer_Tick);
            // 
            // grpBoxLocation
            // 
            this.grpBoxLocation.Controls.Add(this.picBoxCountry);
            this.grpBoxLocation.Controls.Add(this.lblProvinceStateInfo);
            this.grpBoxLocation.Controls.Add(this.lblProvinceState);
            this.grpBoxLocation.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxLocation.Location = new System.Drawing.Point(131, 2);
            this.grpBoxLocation.Name = "grpBoxLocation";
            this.grpBoxLocation.Size = new System.Drawing.Size(394, 100);
            this.grpBoxLocation.TabIndex = 18;
            this.grpBoxLocation.TabStop = false;
            this.grpBoxLocation.Text = "Location Details";
            // 
            // picBoxCountry
            // 
            this.picBoxCountry.Location = new System.Drawing.Point(8, 32);
            this.picBoxCountry.Name = "picBoxCountry";
            this.picBoxCountry.Size = new System.Drawing.Size(115, 62);
            this.picBoxCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCountry.TabIndex = 22;
            this.picBoxCountry.TabStop = false;
            // 
            // lblProvinceStateInfo
            // 
            this.lblProvinceStateInfo.AutoSize = true;
            this.lblProvinceStateInfo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvinceStateInfo.Location = new System.Drawing.Point(143, 17);
            this.lblProvinceStateInfo.Name = "lblProvinceStateInfo";
            this.lblProvinceStateInfo.Size = new System.Drawing.Size(0, 15);
            this.lblProvinceStateInfo.TabIndex = 21;
            // 
            // lblProvinceState
            // 
            this.lblProvinceState.AutoSize = true;
            this.lblProvinceState.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvinceState.Location = new System.Drawing.Point(6, 16);
            this.lblProvinceState.Name = "lblProvinceState";
            this.lblProvinceState.Size = new System.Drawing.Size(131, 15);
            this.lblProvinceState.TabIndex = 20;
            this.lblProvinceState.Text = "Currently Flying over: ";
            // 
            // lblFlightTimeRemaining
            // 
            this.lblFlightTimeRemaining.AutoSize = true;
            this.lblFlightTimeRemaining.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightTimeRemaining.Location = new System.Drawing.Point(6, 17);
            this.lblFlightTimeRemaining.Name = "lblFlightTimeRemaining";
            this.lblFlightTimeRemaining.Size = new System.Drawing.Size(197, 15);
            this.lblFlightTimeRemaining.TabIndex = 19;
            this.lblFlightTimeRemaining.Text = "Estimated Flight Time Remaining: ";
            // 
            // grpBoxTimeDetails
            // 
            this.grpBoxTimeDetails.Controls.Add(this.lblCurrentDateTime);
            this.grpBoxTimeDetails.Controls.Add(this.lblEstimatedTimeLeft);
            this.grpBoxTimeDetails.Controls.Add(this.lblCurrentTime);
            this.grpBoxTimeDetails.Controls.Add(this.lblFlightTimeRemaining);
            this.grpBoxTimeDetails.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTimeDetails.Location = new System.Drawing.Point(531, 2);
            this.grpBoxTimeDetails.Name = "grpBoxTimeDetails";
            this.grpBoxTimeDetails.Size = new System.Drawing.Size(335, 100);
            this.grpBoxTimeDetails.TabIndex = 20;
            this.grpBoxTimeDetails.TabStop = false;
            this.grpBoxTimeDetails.Text = "Time Details";
            // 
            // lblCurrentDateTime
            // 
            this.lblCurrentDateTime.AutoSize = true;
            this.lblCurrentDateTime.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDateTime.Location = new System.Drawing.Point(175, 39);
            this.lblCurrentDateTime.Name = "lblCurrentDateTime";
            this.lblCurrentDateTime.Size = new System.Drawing.Size(0, 15);
            this.lblCurrentDateTime.TabIndex = 22;
            // 
            // lblEstimatedTimeLeft
            // 
            this.lblEstimatedTimeLeft.AutoSize = true;
            this.lblEstimatedTimeLeft.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimatedTimeLeft.Location = new System.Drawing.Point(209, 17);
            this.lblEstimatedTimeLeft.Name = "lblEstimatedTimeLeft";
            this.lblEstimatedTimeLeft.Size = new System.Drawing.Size(0, 15);
            this.lblEstimatedTimeLeft.TabIndex = 21;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(6, 37);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(86, 15);
            this.lblCurrentTime.TabIndex = 20;
            this.lblCurrentTime.Text = "Current Time: ";
            // 
            // dateTimeTimer
            // 
            this.dateTimeTimer.Interval = 1000;
            this.dateTimeTimer.Tick += new System.EventHandler(this.dateTimeTimer_Tick);
            // 
            // estimatedTimeTimer
            // 
            this.estimatedTimeTimer.Interval = 17000;
            this.estimatedTimeTimer.Tick += new System.EventHandler(this.estimatedTimeTimer_Tick);
            // 
            // StartUpTimer
            // 
            this.StartUpTimer.Enabled = true;
            this.StartUpTimer.Interval = 10;
            this.StartUpTimer.Tick += new System.EventHandler(this.SpeedTimer_Tick);
            // 
            // GaugesTimer
            // 
            this.GaugesTimer.Tick += new System.EventHandler(this.GaugesTimer_Tick);
            // 
            // airPressureUpTimer
            // 
            this.airPressureUpTimer.Tick += new System.EventHandler(this.airPressureUpTimer_Tick);
            // 
            // FuelLevelButton
            // 
            this.FuelLevelButton.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelLevelButton.Location = new System.Drawing.Point(863, 261);
            this.FuelLevelButton.Margin = new System.Windows.Forms.Padding(2);
            this.FuelLevelButton.Name = "FuelLevelButton";
            this.FuelLevelButton.Size = new System.Drawing.Size(178, 58);
            this.FuelLevelButton.TabIndex = 21;
            this.FuelLevelButton.Text = "Refuel";
            this.FuelLevelButton.UseVisualStyleBackColor = true;
            this.FuelLevelButton.Visible = false;
            this.FuelLevelButton.Click += new System.EventHandler(this.FuelLevelButton_Click);
            // 
            // RefuelTimer
            // 
            this.RefuelTimer.Tick += new System.EventHandler(this.RefuelTimer_Tick);
            // 
            // lbAutoPilot
            // 
            this.lbAutoPilot.AutoSize = true;
            this.lbAutoPilot.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutoPilot.Location = new System.Drawing.Point(868, 220);
            this.lbAutoPilot.Name = "lbAutoPilot";
            this.lbAutoPilot.Size = new System.Drawing.Size(161, 19);
            this.lbAutoPilot.TabIndex = 22;
            this.lbAutoPilot.Text = "Auto Pilot Disengeged";
            this.lbAutoPilot.Visible = false;
            // 
            // lbDoor
            // 
            this.lbDoor.AutoSize = true;
            this.lbDoor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoor.Location = new System.Drawing.Point(888, 430);
            this.lbDoor.Name = "lbDoor";
            this.lbDoor.Size = new System.Drawing.Size(120, 19);
            this.lbDoor.TabIndex = 23;
            this.lbDoor.Text = "Doors Unlocked";
            this.lbDoor.Visible = false;
            // 
            // AutoPilotTimer
            // 
            this.AutoPilotTimer.Interval = 10000;
            this.AutoPilotTimer.Tick += new System.EventHandler(this.AutoPilotTimerTick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Speed (Knots)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Altitude (feet)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "% of Fuel Remaining";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(689, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "% of Oxygen Remaining";
            // 
            // btnStartPlane
            // 
            this.btnStartPlane.Enabled = false;
            this.btnStartPlane.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartPlane.Location = new System.Drawing.Point(52, 71);
            this.btnStartPlane.Name = "btnStartPlane";
            this.btnStartPlane.Size = new System.Drawing.Size(133, 59);
            this.btnStartPlane.TabIndex = 28;
            this.btnStartPlane.Text = "Start Plane";
            this.btnStartPlane.UseVisualStyleBackColor = true;
            this.btnStartPlane.Click += new System.EventHandler(this.btnStartPlane_Click);
            // 
            // lblDefaultMessage
            // 
            this.lblDefaultMessage.AutoSize = true;
            this.lblDefaultMessage.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultMessage.ForeColor = System.Drawing.Color.Red;
            this.lblDefaultMessage.Location = new System.Drawing.Point(15, 34);
            this.lblDefaultMessage.Name = "lblDefaultMessage";
            this.lblDefaultMessage.Size = new System.Drawing.Size(216, 25);
            this.lblDefaultMessage.TabIndex = 29;
            this.lblDefaultMessage.Text = "Please refuel the plane";
            // 
            // planeTakingOffTimer
            // 
            this.planeTakingOffTimer.Interval = 8000;
            this.planeTakingOffTimer.Tick += new System.EventHandler(this.planeTakingOffTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.weatherPictureBox);
            this.groupBox1.Controls.Add(this.farrenheitSymbolPictureBox);
            this.groupBox1.Controls.Add(this.temperaturePictureBox);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(924, 514);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 180);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weather Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aGauge1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.aGauge3);
            this.groupBox2.Controls.Add(this.aGauge2);
            this.groupBox2.Controls.Add(this.aGauge4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 503);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(891, 250);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gauges";
            // 
            // aGauge1
            // 
            this.aGauge1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.aGauge1.BaseArcColor = System.Drawing.Color.RosyBrown;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Center = new System.Drawing.Point(105, 100);
            this.aGauge1.GaugeAutoSize = true;
            this.aGauge1.Location = new System.Drawing.Point(6, 48);
            this.aGauge1.MaxValue = 800F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 100F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(220, 188);
            this.aGauge1.TabIndex = 1;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            this.aGauge1.ValueInRangeChanged += new System.EventHandler<System.Windows.Forms.ValueInRangeChangedEventArgs>(this.aGauge1_ValueInRangeChanged);
            // 
            // aGauge3
            // 
            this.aGauge3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.aGauge3.BaseArcColor = System.Drawing.Color.RosyBrown;
            this.aGauge3.BaseArcRadius = 80;
            this.aGauge3.BaseArcStart = 135;
            this.aGauge3.BaseArcSweep = 270;
            this.aGauge3.BaseArcWidth = 2;
            this.aGauge3.Center = new System.Drawing.Point(103, 100);
            this.aGauge3.GaugeAutoSize = true;
            this.aGauge3.Location = new System.Drawing.Point(452, 48);
            this.aGauge3.MaxValue = 100F;
            this.aGauge3.MinValue = 0F;
            this.aGauge3.Name = "aGauge3";
            this.aGauge3.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge3.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge3.NeedleRadius = 80;
            this.aGauge3.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge3.NeedleWidth = 2;
            this.aGauge3.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesInterInnerRadius = 73;
            this.aGauge3.ScaleLinesInterOuterRadius = 80;
            this.aGauge3.ScaleLinesInterWidth = 1;
            this.aGauge3.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesMajorInnerRadius = 70;
            this.aGauge3.ScaleLinesMajorOuterRadius = 80;
            this.aGauge3.ScaleLinesMajorStepValue = 20F;
            this.aGauge3.ScaleLinesMajorWidth = 2;
            this.aGauge3.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge3.ScaleLinesMinorInnerRadius = 75;
            this.aGauge3.ScaleLinesMinorOuterRadius = 80;
            this.aGauge3.ScaleLinesMinorTicks = 9;
            this.aGauge3.ScaleLinesMinorWidth = 1;
            this.aGauge3.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleNumbersFormat = null;
            this.aGauge3.ScaleNumbersRadius = 95;
            this.aGauge3.ScaleNumbersRotation = 0;
            this.aGauge3.ScaleNumbersStartScaleLine = 0;
            this.aGauge3.ScaleNumbersStepScaleLines = 1;
            this.aGauge3.Size = new System.Drawing.Size(205, 188);
            this.aGauge3.TabIndex = 1;
            this.aGauge3.Text = "aGauge3";
            this.aGauge3.Value = 0F;
            this.aGauge3.ValueInRangeChanged += new System.EventHandler<System.Windows.Forms.ValueInRangeChangedEventArgs>(this.aGauge3_ValueInRangeChanged);
            // 
            // aGauge2
            // 
            this.aGauge2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.aGauge2.BaseArcColor = System.Drawing.Color.RosyBrown;
            this.aGauge2.BaseArcRadius = 80;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 270;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Center = new System.Drawing.Point(108, 110);
            this.aGauge2.GaugeAutoSize = true;
            this.aGauge2.Location = new System.Drawing.Point(230, 48);
            this.aGauge2.Margin = new System.Windows.Forms.Padding(1);
            this.aGauge2.MaxValue = 42000F;
            this.aGauge2.MinValue = 0F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge2.NeedleRadius = 80;
            this.aGauge2.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge2.NeedleWidth = 2;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesInterInnerRadius = 73;
            this.aGauge2.ScaleLinesInterOuterRadius = 80;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMajorInnerRadius = 70;
            this.aGauge2.ScaleLinesMajorOuterRadius = 80;
            this.aGauge2.ScaleLinesMajorStepValue = 4000F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge2.ScaleLinesMinorInnerRadius = 75;
            this.aGauge2.ScaleLinesMinorOuterRadius = 80;
            this.aGauge2.ScaleLinesMinorTicks = 9;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 95;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 0;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(218, 188);
            this.aGauge2.TabIndex = 1;
            this.aGauge2.Text = "aGauge2";
            this.aGauge2.Value = 0F;
            this.aGauge2.ValueInRangeChanged += new System.EventHandler<System.Windows.Forms.ValueInRangeChangedEventArgs>(this.aGauge2_ValueInRangeChanged);
            // 
            // aGauge4
            // 
            this.aGauge4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.aGauge4.BaseArcColor = System.Drawing.Color.RosyBrown;
            this.aGauge4.BaseArcRadius = 80;
            this.aGauge4.BaseArcStart = 135;
            this.aGauge4.BaseArcSweep = 270;
            this.aGauge4.BaseArcWidth = 2;
            this.aGauge4.GaugeAutoSize = true;
            this.aGauge4.Location = new System.Drawing.Point(663, 49);
            this.aGauge4.MaxValue = 100F;
            this.aGauge4.MinValue = 0F;
            this.aGauge4.Name = "aGauge4";
            this.aGauge4.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge4.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge4.NeedleRadius = 80;
            this.aGauge4.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge4.NeedleWidth = 2;
            this.aGauge4.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleLinesInterInnerRadius = 73;
            this.aGauge4.ScaleLinesInterOuterRadius = 80;
            this.aGauge4.ScaleLinesInterWidth = 1;
            this.aGauge4.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleLinesMajorInnerRadius = 70;
            this.aGauge4.ScaleLinesMajorOuterRadius = 80;
            this.aGauge4.ScaleLinesMajorStepValue = 20F;
            this.aGauge4.ScaleLinesMajorWidth = 2;
            this.aGauge4.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge4.ScaleLinesMinorInnerRadius = 75;
            this.aGauge4.ScaleLinesMinorOuterRadius = 80;
            this.aGauge4.ScaleLinesMinorTicks = 9;
            this.aGauge4.ScaleLinesMinorWidth = 1;
            this.aGauge4.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleNumbersFormat = null;
            this.aGauge4.ScaleNumbersRadius = 95;
            this.aGauge4.ScaleNumbersRotation = 0;
            this.aGauge4.ScaleNumbersStartScaleLine = 0;
            this.aGauge4.ScaleNumbersStepScaleLines = 1;
            this.aGauge4.Size = new System.Drawing.Size(220, 187);
            this.aGauge4.TabIndex = 1;
            this.aGauge4.Text = "aGauge4";
            this.aGauge4.Value = 0F;
            this.aGauge4.ValueInRangeChanged += new System.EventHandler<System.Windows.Forms.ValueInRangeChangedEventArgs>(this.aGauge4_ValueInRangeChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStartPlane);
            this.groupBox3.Controls.Add(this.lblDefaultMessage);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(872, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 152);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plane Info";
            // 
            // lblPlaneRefuel
            // 
            this.lblPlaneRefuel.AutoSize = true;
            this.lblPlaneRefuel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneRefuel.Location = new System.Drawing.Point(888, 321);
            this.lblPlaneRefuel.Name = "lblPlaneRefuel";
            this.lblPlaneRefuel.Size = new System.Drawing.Size(0, 19);
            this.lblPlaneRefuel.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(248, 485);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 23);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(399, 485);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 23);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // lblGreenTriangle
            // 
            this.lblGreenTriangle.AutoSize = true;
            this.lblGreenTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreenTriangle.Location = new System.Drawing.Point(285, 487);
            this.lblGreenTriangle.Name = "lblGreenTriangle";
            this.lblGreenTriangle.Size = new System.Drawing.Size(108, 18);
            this.lblGreenTriangle.TabIndex = 27;
            this.lblGreenTriangle.Text = "= Locked Door";
            // 
            // lblUnlockedDoor
            // 
            this.lblUnlockedDoor.AutoSize = true;
            this.lblUnlockedDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnlockedDoor.Location = new System.Drawing.Point(436, 487);
            this.lblUnlockedDoor.Name = "lblUnlockedDoor";
            this.lblUnlockedDoor.Size = new System.Drawing.Size(122, 18);
            this.lblUnlockedDoor.TabIndex = 28;
            this.lblUnlockedDoor.Text = "= Unlocked Door";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(564, 485);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 23);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // lblNotMonitored
            // 
            this.lblNotMonitored.AutoSize = true;
            this.lblNotMonitored.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotMonitored.Location = new System.Drawing.Point(601, 487);
            this.lblNotMonitored.Name = "lblNotMonitored";
            this.lblNotMonitored.Size = new System.Drawing.Size(190, 18);
            this.lblNotMonitored.TabIndex = 30;
            this.lblNotMonitored.Text = "= Door not being monitored";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 801);
            this.Controls.Add(this.lblPlaneIsTurning);
            this.Controls.Add(this.lblNotMonitored);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblUnlockedDoor);
            this.Controls.Add(this.lblGreenTriangle);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblPlaneRefuel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbDoor);
            this.Controls.Add(this.lbAutoPilot);
            this.Controls.Add(this.grpBoxAirPressure);
            this.Controls.Add(this.grpBoxTimeDetails);
            this.Controls.Add(this.grpBoxLocation);
            this.Controls.Add(this.FuelLevelButton);
            this.Controls.Add(this.grpBoxPlaneTurning);
            this.Controls.Add(this.grpBoxCoordinateDetails);
            this.Controls.Add(this.btnViewFlightInformation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AutoPilot);
            this.Controls.Add(this.LockDoors);
            this.Name = "Form1";
            this.Text = "PlaneModule";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.temperaturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farrenheitSymbolPictureBox)).EndInit();
            this.grpBoxAirPressure.ResumeLayout(false);
            this.grpBoxAirPressure.PerformLayout();
            this.grpBoxCoordinateDetails.ResumeLayout(false);
            this.grpBoxCoordinateDetails.PerformLayout();
            this.grpBoxPlaneTurning.ResumeLayout(false);
            this.grpBoxLocation.ResumeLayout(false);
            this.grpBoxLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCountry)).EndInit();
            this.grpBoxTimeDetails.ResumeLayout(false);
            this.grpBoxTimeDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.AGauge aGauge2;
        private System.Windows.Forms.AGauge aGauge3;
        private System.Windows.Forms.AGauge aGauge4;
        private System.Windows.Forms.Button LockDoors;
        private System.Windows.Forms.Button AutoPilot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewFlightInformation;
        private System.Windows.Forms.PictureBox weatherPictureBox;
        private System.Windows.Forms.Timer weatherTimer;
        private System.Windows.Forms.ImageList weatherImageList;
        private System.Windows.Forms.PictureBox temperaturePictureBox;
        private System.Windows.Forms.ImageList temperatureImageList;
        private System.Windows.Forms.PictureBox farrenheitSymbolPictureBox;
        private System.Windows.Forms.GroupBox grpBoxAirPressure;
        private System.Windows.Forms.TextBox txtAirPressure;
        private System.Windows.Forms.Timer airPressureTimer;
        private System.Windows.Forms.Timer latitudeLongitudeTimer;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.GroupBox grpBoxCoordinateDetails;
        private System.Windows.Forms.GroupBox grpBoxPlaneTurning;
        private System.Windows.Forms.Button btnRight90;
        private System.Windows.Forms.Button btnLeft90;
        private System.Windows.Forms.Button btnLeft45;
        private System.Windows.Forms.Button btnRight45;
        private System.Windows.Forms.Label lblCompassBearing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlaneIsTurning;
        private System.Windows.Forms.Timer turningPlaneTimer;
        private System.Windows.Forms.Timer changingLocationTimer;
        private System.Windows.Forms.GroupBox grpBoxLocation;
        private System.Windows.Forms.Label lblProvinceStateInfo;
        private System.Windows.Forms.Label lblProvinceState;
        private System.Windows.Forms.PictureBox picBoxCountry;
        private System.Windows.Forms.Label lblFlightTimeRemaining;
        private System.Windows.Forms.GroupBox grpBoxTimeDetails;
        private System.Windows.Forms.Label lblCurrentDateTime;
        private System.Windows.Forms.Label lblEstimatedTimeLeft;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer dateTimeTimer;
        private System.Windows.Forms.Timer estimatedTimeTimer;
        private Timer StartUpTimer;
        private Button btnAirPressure;
        private Label lbAirPressure;
        private Timer GaugesTimer;
        private Timer airPressureUpTimer;
        private Button FuelLevelButton;
        private Timer RefuelTimer;
        private Label lbAutoPilot;
        private Label lbDoor;
        private Timer AutoPilotTimer;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnStartPlane;
        private Label lblDefaultMessage;
        private Timer planeTakingOffTimer;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblPlaneRefuel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblGreenTriangle;
        private Label lblUnlockedDoor;
        private PictureBox pictureBox4;
        private Label lblNotMonitored;
    }
}

