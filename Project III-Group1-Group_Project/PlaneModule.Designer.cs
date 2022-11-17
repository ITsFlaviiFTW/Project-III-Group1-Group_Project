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
            System.Windows.Forms.AGaugeRange aGaugeRange1 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange2 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange3 = new System.Windows.Forms.AGaugeRange();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
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
            this.warningAirPressureLabel = new System.Windows.Forms.Label();
            this.airPressureTrackBar = new System.Windows.Forms.TrackBar();
            this.airPressureGauge = new System.Windows.Forms.AGauge();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperaturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farrenheitSymbolPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPressureTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(973, 198);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(169, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "GoBack";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GoBack);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "GoNext";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GoNext);
            // 
            // btnViewFlightInformation
            // 
            this.btnViewFlightInformation.Location = new System.Drawing.Point(3, 2);
            this.btnViewFlightInformation.Name = "btnViewFlightInformation";
            this.btnViewFlightInformation.Size = new System.Drawing.Size(122, 59);
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
            this.temperaturePictureBox.Location = new System.Drawing.Point(1088, 403);
            this.temperaturePictureBox.Name = "temperaturePictureBox";
            this.temperaturePictureBox.Size = new System.Drawing.Size(54, 44);
            this.temperaturePictureBox.TabIndex = 13;
            this.temperaturePictureBox.TabStop = false;
            this.temperaturePictureBox.Click += new System.EventHandler(this.temperaturePictureBox_Click);
            // 
            // weatherPictureBox
            // 
            this.weatherPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.weatherPictureBox.Location = new System.Drawing.Point(1042, 297);
            this.weatherPictureBox.Name = "weatherPictureBox";
            this.weatherPictureBox.Size = new System.Drawing.Size(100, 100);
            this.weatherPictureBox.TabIndex = 12;
            this.weatherPictureBox.TabStop = false;
            this.weatherPictureBox.Click += new System.EventHandler(this.weatherPictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(252, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // farrenheitSymbolPictureBox
            // 
            this.farrenheitSymbolPictureBox.Location = new System.Drawing.Point(1052, 415);
            this.farrenheitSymbolPictureBox.Name = "farrenheitSymbolPictureBox";
            this.farrenheitSymbolPictureBox.Size = new System.Drawing.Size(30, 30);
            this.farrenheitSymbolPictureBox.TabIndex = 14;
            this.farrenheitSymbolPictureBox.TabStop = false;
            this.farrenheitSymbolPictureBox.Click += new System.EventHandler(this.farrenheitSymbolPictureBox_Click);
            // 
            // warningAirPressureLabel
            // 
            this.warningAirPressureLabel.AutoSize = true;
            this.warningAirPressureLabel.Location = new System.Drawing.Point(919, 491);
            this.warningAirPressureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.warningAirPressureLabel.Name = "warningAirPressureLabel";
            this.warningAirPressureLabel.Size = new System.Drawing.Size(35, 13);
            this.warningAirPressureLabel.TabIndex = 16;
            this.warningAirPressureLabel.Text = "label1";
            // 
            // airPressureTrackBar
            // 
            this.airPressureTrackBar.Location = new System.Drawing.Point(842, 524);
            this.airPressureTrackBar.Maximum = 100;
            this.airPressureTrackBar.Name = "airPressureTrackBar";
            this.airPressureTrackBar.Size = new System.Drawing.Size(169, 45);
            this.airPressureTrackBar.TabIndex = 2;
            this.airPressureTrackBar.TickFrequency = 20;
            this.airPressureTrackBar.Scroll += new System.EventHandler(this.airPressureTrackBar_Scroll);
            // 
            // airPressureGauge
            // 
            this.airPressureGauge.BaseArcColor = System.Drawing.Color.Gray;
            this.airPressureGauge.BaseArcRadius = 80;
            this.airPressureGauge.BaseArcStart = 135;
            this.airPressureGauge.BaseArcSweep = 270;
            this.airPressureGauge.BaseArcWidth = 2;
            this.airPressureGauge.GaugeAutoSize = false;
            aGaugeRange1.Color = System.Drawing.Color.Red;
            aGaugeRange1.EndValue = 25F;
            aGaugeRange1.InnerRadius = 70;
            aGaugeRange1.InRange = false;
            aGaugeRange1.Name = "GaugeRange1";
            aGaugeRange1.OuterRadius = 80;
            aGaugeRange1.StartValue = 0F;
            aGaugeRange2.Color = System.Drawing.Color.Yellow;
            aGaugeRange2.EndValue = 50F;
            aGaugeRange2.InnerRadius = 70;
            aGaugeRange2.InRange = false;
            aGaugeRange2.Name = "GaugeRange2";
            aGaugeRange2.OuterRadius = 80;
            aGaugeRange2.StartValue = 25F;
            aGaugeRange3.Color = System.Drawing.Color.Lime;
            aGaugeRange3.EndValue = 75F;
            aGaugeRange3.InnerRadius = 70;
            aGaugeRange3.InRange = false;
            aGaugeRange3.Name = "GaugeRange3";
            aGaugeRange3.OuterRadius = 80;
            aGaugeRange3.StartValue = 50F;
            this.airPressureGauge.GaugeRanges.Add(aGaugeRange1);
            this.airPressureGauge.GaugeRanges.Add(aGaugeRange2);
            this.airPressureGauge.GaugeRanges.Add(aGaugeRange3);
            this.airPressureGauge.Location = new System.Drawing.Point(842, 337);
            this.airPressureGauge.MaxValue = 75F;
            this.airPressureGauge.MinValue = 0F;
            this.airPressureGauge.Name = "airPressureGauge";
            this.airPressureGauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.airPressureGauge.NeedleColor2 = System.Drawing.Color.DimGray;
            this.airPressureGauge.NeedleRadius = 80;
            this.airPressureGauge.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.airPressureGauge.NeedleWidth = 2;
            this.airPressureGauge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.airPressureGauge.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.airPressureGauge.ScaleLinesInterInnerRadius = 73;
            this.airPressureGauge.ScaleLinesInterOuterRadius = 80;
            this.airPressureGauge.ScaleLinesInterWidth = 1;
            this.airPressureGauge.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.airPressureGauge.ScaleLinesMajorInnerRadius = 70;
            this.airPressureGauge.ScaleLinesMajorOuterRadius = 80;
            this.airPressureGauge.ScaleLinesMajorStepValue = 50F;
            this.airPressureGauge.ScaleLinesMajorWidth = 2;
            this.airPressureGauge.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.airPressureGauge.ScaleLinesMinorInnerRadius = 75;
            this.airPressureGauge.ScaleLinesMinorOuterRadius = 80;
            this.airPressureGauge.ScaleLinesMinorTicks = 9;
            this.airPressureGauge.ScaleLinesMinorWidth = 1;
            this.airPressureGauge.ScaleNumbersColor = System.Drawing.Color.Black;
            this.airPressureGauge.ScaleNumbersFormat = null;
            this.airPressureGauge.ScaleNumbersRadius = 95;
            this.airPressureGauge.ScaleNumbersRotation = 0;
            this.airPressureGauge.ScaleNumbersStartScaleLine = 0;
            this.airPressureGauge.ScaleNumbersStepScaleLines = 1;
            this.airPressureGauge.Size = new System.Drawing.Size(206, 209);
            this.airPressureGauge.TabIndex = 1;
            this.airPressureGauge.Text = "aGauge2";
            this.airPressureGauge.Value = 0F;
            this.airPressureGauge.ValueInRangeChanged += new System.EventHandler<System.Windows.Forms.ValueInRangeChangedEventArgs>(this.airPressureGauge_ValueInRangeChanged);
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
            this.aGauge1.Location = new System.Drawing.Point(957, 12);
            this.aGauge1.MaxValue = 100F;
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
            this.aGauge1.ScaleLinesMajorStepValue = 50F;
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
            this.aGauge1.Size = new System.Drawing.Size(205, 180);
            this.aGauge1.TabIndex = 1;
            this.aGauge1.Value = 0F;
            this.aGauge1.ValueInRangeChanged += new System.EventHandler<System.Windows.Forms.ValueInRangeChangedEventArgs>(this.aGauge1_ValueInRangeChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 567);
            this.Controls.Add(this.airPressureTrackBar);
            this.Controls.Add(this.warningAirPressureLabel);
            this.Controls.Add(this.airPressureGauge);
            this.Controls.Add(this.farrenheitSymbolPictureBox);
            this.Controls.Add(this.temperaturePictureBox);
            this.Controls.Add(this.weatherPictureBox);
            this.Controls.Add(this.btnViewFlightInformation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.aGauge1);
            this.Name = "Form1";
            this.Text = "PlaneModule";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperaturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farrenheitSymbolPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPressureTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.TrackBar trackBar1;
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
        private System.Windows.Forms.Label warningAirPressureLabel;
        public System.Windows.Forms.AGauge airPressureGauge;
        public System.Windows.Forms.TrackBar airPressureTrackBar;
    }
}

