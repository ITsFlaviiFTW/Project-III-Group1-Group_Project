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
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.aGauge2 = new System.Windows.Forms.AGauge();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnViewFlightInformation = new System.Windows.Forms.Button();
            this.weatherTimer = new System.Windows.Forms.Timer(this.components);
            this.weatherImageList = new System.Windows.Forms.ImageList(this.components);
            this.temperatureImageList = new System.Windows.Forms.ImageList(this.components);
            this.temperaturePictureBox = new System.Windows.Forms.PictureBox();
            this.weatherPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.farrenheitSymbolPictureBox = new System.Windows.Forms.PictureBox();
            this.grpBoxAirPressure = new System.Windows.Forms.GroupBox();
            this.txtAirPressure = new System.Windows.Forms.TextBox();
            this.airPressureTimer = new System.Windows.Forms.Timer(this.components);
            this.latitudeLongitudeTimer = new System.Windows.Forms.Timer(this.components);
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.grpBoxCoordinateDetails = new System.Windows.Forms.GroupBox();
            this.lblPlaneIsTurning = new System.Windows.Forms.Label();
            this.lblCompassBearing = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lblCurrentTimeLeft = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.dateTimeTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
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
            this.SuspendLayout();
            // 
            // aGauge1
            // 
            this.aGauge1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.aGauge1.BaseArcColor = System.Drawing.Color.RosyBrown;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.GaugeAutoSize = false;
            this.aGauge1.Location = new System.Drawing.Point(1436, 18);
            this.aGauge1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.aGauge1.Size = new System.Drawing.Size(308, 277);
            this.aGauge1.TabIndex = 1;
            this.aGauge1.Value = 0F;
            // 
            // aGauge2
            // 
            this.aGauge2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.aGauge2.BaseArcColor = System.Drawing.Color.RosyBrown;
            this.aGauge2.BaseArcRadius = 80;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 270;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.GaugeAutoSize = false;
            this.aGauge2.Location = new System.Drawing.Point(1436, 385);
            this.aGauge2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.aGauge2.ScaleLinesMajorStepValue = 5000F;
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
            this.aGauge2.Size = new System.Drawing.Size(308, 277);
            this.aGauge2.TabIndex = 1;
            this.aGauge2.Text = "aGauge2";
            this.aGauge2.Value = 0F;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1460, 305);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(254, 69);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(1460, 674);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(254, 69);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.TickFrequency = 20;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 912);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 83);
            this.button2.TabIndex = 7;
            this.button2.Text = "GoBack";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GoBack);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(924, 903);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 91);
            this.button1.TabIndex = 9;
            this.button1.Text = "GoNext";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GoNext);
            // 
            // btnViewFlightInformation
            // 
            this.btnViewFlightInformation.Location = new System.Drawing.Point(4, 3);
            this.btnViewFlightInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewFlightInformation.Name = "btnViewFlightInformation";
            this.btnViewFlightInformation.Size = new System.Drawing.Size(183, 91);
            this.btnViewFlightInformation.TabIndex = 11;
            this.btnViewFlightInformation.Text = "View current flight information";
            this.btnViewFlightInformation.UseVisualStyleBackColor = true;
            this.btnViewFlightInformation.Click += new System.EventHandler(this.btnViewFlightInformation_Click);
            // 
            // weatherTimer
            // 
            this.weatherTimer.Enabled = true;
            this.weatherTimer.Interval = 2000;
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
            this.temperaturePictureBox.Location = new System.Drawing.Point(1652, 786);
            this.temperaturePictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.temperaturePictureBox.Name = "temperaturePictureBox";
            this.temperaturePictureBox.Size = new System.Drawing.Size(81, 68);
            this.temperaturePictureBox.TabIndex = 13;
            this.temperaturePictureBox.TabStop = false;
            this.temperaturePictureBox.Click += new System.EventHandler(this.temperaturePictureBox_Click);
            // 
            // weatherPictureBox
            // 
            this.weatherPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.weatherPictureBox.Location = new System.Drawing.Point(1582, 623);
            this.weatherPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.weatherPictureBox.Name = "weatherPictureBox";
            this.weatherPictureBox.Size = new System.Drawing.Size(150, 154);
            this.weatherPictureBox.TabIndex = 12;
            this.weatherPictureBox.TabStop = false;
            this.weatherPictureBox.Click += new System.EventHandler(this.weatherPictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_III_Group1_Group_Project.Properties.Resources.plane1_Bad_CPdoor;
            this.pictureBox1.Location = new System.Drawing.Point(378, 177);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(860, 574);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // farrenheitSymbolPictureBox
            // 
            this.farrenheitSymbolPictureBox.Location = new System.Drawing.Point(1598, 786);
            this.farrenheitSymbolPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.farrenheitSymbolPictureBox.Name = "farrenheitSymbolPictureBox";
            this.farrenheitSymbolPictureBox.Size = new System.Drawing.Size(45, 46);
            this.farrenheitSymbolPictureBox.TabIndex = 14;
            this.farrenheitSymbolPictureBox.TabStop = false;
            this.farrenheitSymbolPictureBox.Click += new System.EventHandler(this.farrenheitSymbolPictureBox_Click);
            // 
            // grpBoxAirPressure
            // 
            this.grpBoxAirPressure.Controls.Add(this.txtAirPressure);
            this.grpBoxAirPressure.Location = new System.Drawing.Point(1398, 623);
            this.grpBoxAirPressure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxAirPressure.Name = "grpBoxAirPressure";
            this.grpBoxAirPressure.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxAirPressure.Size = new System.Drawing.Size(124, 106);
            this.grpBoxAirPressure.TabIndex = 15;
            this.grpBoxAirPressure.TabStop = false;
            this.grpBoxAirPressure.Text = "Air Pressure";
            // 
            // txtAirPressure
            // 
            this.txtAirPressure.Location = new System.Drawing.Point(33, 29);
            this.txtAirPressure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAirPressure.Name = "txtAirPressure";
            this.txtAirPressure.ReadOnly = true;
            this.txtAirPressure.Size = new System.Drawing.Size(66, 26);
            this.txtAirPressure.TabIndex = 0;
            this.txtAirPressure.Text = "100.000";
            // 
            // airPressureTimer
            // 
            this.airPressureTimer.Tick += new System.EventHandler(this.airPressureTimer_Tick);
            // 
            // latitudeLongitudeTimer
            // 
            this.latitudeLongitudeTimer.Tick += new System.EventHandler(this.latitudeLongitudeTimer_Tick);
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.Location = new System.Drawing.Point(10, 34);
            this.lblLatitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(77, 20);
            this.lblLatitude.TabIndex = 12;
            this.lblLatitude.Text = "Latitude: ";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitude.Location = new System.Drawing.Point(10, 78);
            this.lblLongitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(89, 20);
            this.lblLongitude.TabIndex = 13;
            this.lblLongitude.Text = "Longitude: ";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(96, 29);
            this.txtLatitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.ReadOnly = true;
            this.txtLatitude.Size = new System.Drawing.Size(98, 27);
            this.txtLatitude.TabIndex = 14;
            this.txtLatitude.Text = "0.000000";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(96, 78);
            this.txtLongitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.ReadOnly = true;
            this.txtLongitude.Size = new System.Drawing.Size(98, 27);
            this.txtLongitude.TabIndex = 15;
            this.txtLongitude.Text = "0.000000";
            // 
            // grpBoxCoordinateDetails
            // 
            this.grpBoxCoordinateDetails.Controls.Add(this.lblPlaneIsTurning);
            this.grpBoxCoordinateDetails.Controls.Add(this.lblCompassBearing);
            this.grpBoxCoordinateDetails.Controls.Add(this.label1);
            this.grpBoxCoordinateDetails.Controls.Add(this.txtLatitude);
            this.grpBoxCoordinateDetails.Controls.Add(this.txtLongitude);
            this.grpBoxCoordinateDetails.Controls.Add(this.lblLatitude);
            this.grpBoxCoordinateDetails.Controls.Add(this.lblLongitude);
            this.grpBoxCoordinateDetails.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxCoordinateDetails.Location = new System.Drawing.Point(4, 154);
            this.grpBoxCoordinateDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxCoordinateDetails.Name = "grpBoxCoordinateDetails";
            this.grpBoxCoordinateDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxCoordinateDetails.Size = new System.Drawing.Size(249, 220);
            this.grpBoxCoordinateDetails.TabIndex = 16;
            this.grpBoxCoordinateDetails.TabStop = false;
            this.grpBoxCoordinateDetails.Text = "Coordinate Details";
            // 
            // lblPlaneIsTurning
            // 
            this.lblPlaneIsTurning.AutoSize = true;
            this.lblPlaneIsTurning.ForeColor = System.Drawing.Color.Red;
            this.lblPlaneIsTurning.Location = new System.Drawing.Point(10, 185);
            this.lblPlaneIsTurning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaneIsTurning.Name = "lblPlaneIsTurning";
            this.lblPlaneIsTurning.Size = new System.Drawing.Size(0, 20);
            this.lblPlaneIsTurning.TabIndex = 19;
            // 
            // lblCompassBearing
            // 
            this.lblCompassBearing.AutoSize = true;
            this.lblCompassBearing.Location = new System.Drawing.Point(212, 131);
            this.lblCompassBearing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompassBearing.Name = "lblCompassBearing";
            this.lblCompassBearing.Size = new System.Drawing.Size(0, 20);
            this.lblCompassBearing.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Current Compass Bearing: ";
            // 
            // grpBoxPlaneTurning
            // 
            this.grpBoxPlaneTurning.Controls.Add(this.btnRight90);
            this.grpBoxPlaneTurning.Controls.Add(this.btnLeft90);
            this.grpBoxPlaneTurning.Controls.Add(this.btnLeft45);
            this.grpBoxPlaneTurning.Controls.Add(this.btnRight45);
            this.grpBoxPlaneTurning.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxPlaneTurning.Location = new System.Drawing.Point(4, 402);
            this.grpBoxPlaneTurning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxPlaneTurning.Name = "grpBoxPlaneTurning";
            this.grpBoxPlaneTurning.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxPlaneTurning.Size = new System.Drawing.Size(312, 163);
            this.grpBoxPlaneTurning.TabIndex = 17;
            this.grpBoxPlaneTurning.TabStop = false;
            this.grpBoxPlaneTurning.Text = "Plane Turning Control Panel";
            // 
            // btnRight90
            // 
            this.btnRight90.Location = new System.Drawing.Point(159, 98);
            this.btnRight90.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRight90.Name = "btnRight90";
            this.btnRight90.Size = new System.Drawing.Size(136, 52);
            this.btnRight90.TabIndex = 21;
            this.btnRight90.Text = "Turn Right 90°";
            this.btnRight90.UseVisualStyleBackColor = true;
            this.btnRight90.Click += new System.EventHandler(this.btnRight90_Click);
            // 
            // btnLeft90
            // 
            this.btnLeft90.Location = new System.Drawing.Point(15, 98);
            this.btnLeft90.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLeft90.Name = "btnLeft90";
            this.btnLeft90.Size = new System.Drawing.Size(136, 52);
            this.btnLeft90.TabIndex = 20;
            this.btnLeft90.Text = "Turn Left 90°";
            this.btnLeft90.UseVisualStyleBackColor = true;
            this.btnLeft90.Click += new System.EventHandler(this.btnLeft90_Click);
            // 
            // btnLeft45
            // 
            this.btnLeft45.Location = new System.Drawing.Point(15, 37);
            this.btnLeft45.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLeft45.Name = "btnLeft45";
            this.btnLeft45.Size = new System.Drawing.Size(136, 52);
            this.btnLeft45.TabIndex = 18;
            this.btnLeft45.Text = "Turn Left 45°";
            this.btnLeft45.UseVisualStyleBackColor = true;
            this.btnLeft45.Click += new System.EventHandler(this.btnLeft45_Click);
            // 
            // btnRight45
            // 
            this.btnRight45.Location = new System.Drawing.Point(159, 37);
            this.btnRight45.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRight45.Name = "btnRight45";
            this.btnRight45.Size = new System.Drawing.Size(136, 52);
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
            this.grpBoxLocation.Location = new System.Drawing.Point(298, 14);
            this.grpBoxLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxLocation.Name = "grpBoxLocation";
            this.grpBoxLocation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxLocation.Size = new System.Drawing.Size(591, 154);
            this.grpBoxLocation.TabIndex = 18;
            this.grpBoxLocation.TabStop = false;
            this.grpBoxLocation.Text = "Location Details";
            // 
            // picBoxCountry
            // 
            this.picBoxCountry.Location = new System.Drawing.Point(12, 49);
            this.picBoxCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBoxCountry.Name = "picBoxCountry";
            this.picBoxCountry.Size = new System.Drawing.Size(172, 95);
            this.picBoxCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCountry.TabIndex = 22;
            this.picBoxCountry.TabStop = false;
            // 
            // lblProvinceStateInfo
            // 
            this.lblProvinceStateInfo.AutoSize = true;
            this.lblProvinceStateInfo.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvinceStateInfo.Location = new System.Drawing.Point(184, 26);
            this.lblProvinceStateInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvinceStateInfo.Name = "lblProvinceStateInfo";
            this.lblProvinceStateInfo.Size = new System.Drawing.Size(0, 20);
            this.lblProvinceStateInfo.TabIndex = 21;
            // 
            // lblProvinceState
            // 
            this.lblProvinceState.AutoSize = true;
            this.lblProvinceState.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvinceState.Location = new System.Drawing.Point(9, 25);
            this.lblProvinceState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvinceState.Name = "lblProvinceState";
            this.lblProvinceState.Size = new System.Drawing.Size(173, 20);
            this.lblProvinceState.TabIndex = 20;
            this.lblProvinceState.Text = "Currently Flying over: ";
            // 
            // lblFlightTimeRemaining
            // 
            this.lblFlightTimeRemaining.AutoSize = true;
            this.lblFlightTimeRemaining.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightTimeRemaining.Location = new System.Drawing.Point(9, 25);
            this.lblFlightTimeRemaining.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightTimeRemaining.Name = "lblFlightTimeRemaining";
            this.lblFlightTimeRemaining.Size = new System.Drawing.Size(258, 20);
            this.lblFlightTimeRemaining.TabIndex = 19;
            this.lblFlightTimeRemaining.Text = "Estimated Flight Time Remaining: ";
            // 
            // grpBoxTimeDetails
            // 
            this.grpBoxTimeDetails.Controls.Add(this.lblCurrentTimeLeft);
            this.grpBoxTimeDetails.Controls.Add(this.lblTimeLeft);
            this.grpBoxTimeDetails.Controls.Add(this.lblCurrentTime);
            this.grpBoxTimeDetails.Controls.Add(this.lblFlightTimeRemaining);
            this.grpBoxTimeDetails.Location = new System.Drawing.Point(924, 14);
            this.grpBoxTimeDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxTimeDetails.Name = "grpBoxTimeDetails";
            this.grpBoxTimeDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxTimeDetails.Size = new System.Drawing.Size(502, 154);
            this.grpBoxTimeDetails.TabIndex = 20;
            this.grpBoxTimeDetails.TabStop = false;
            this.grpBoxTimeDetails.Text = "Time Details";
            // 
            // lblCurrentTimeLeft
            // 
            this.lblCurrentTimeLeft.AutoSize = true;
            this.lblCurrentTimeLeft.Location = new System.Drawing.Point(262, 60);
            this.lblCurrentTimeLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentTimeLeft.Name = "lblCurrentTimeLeft";
            this.lblCurrentTimeLeft.Size = new System.Drawing.Size(0, 20);
            this.lblCurrentTimeLeft.TabIndex = 22;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(262, 26);
            this.lblTimeLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(0, 20);
            this.lblTimeLeft.TabIndex = 21;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(9, 57);
            this.lblCurrentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(114, 20);
            this.lblCurrentTime.TabIndex = 20;
            this.lblCurrentTime.Text = "Current Time: ";
            // 
            // dateTimeTimer
            // 
            this.dateTimeTimer.Tick += new System.EventHandler(this.dateTimeTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1050);
            this.Controls.Add(this.grpBoxAirPressure);
            this.Controls.Add(this.farrenheitSymbolPictureBox);
            this.Controls.Add(this.temperaturePictureBox);
            this.Controls.Add(this.weatherPictureBox);
            this.Controls.Add(this.grpBoxTimeDetails);
            this.Controls.Add(this.grpBoxLocation);
            this.Controls.Add(this.grpBoxPlaneTurning);
            this.Controls.Add(this.grpBoxCoordinateDetails);
            this.Controls.Add(this.btnViewFlightInformation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.aGauge2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "PlaneModule";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.AGauge aGauge2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Label lblCurrentTimeLeft;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer dateTimeTimer;
    }
}

