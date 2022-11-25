namespace GeoLocationTestingProject
{
    [TestClass]
    public class GeoLocationTests
    {
        /// <summary>
        /// This test will check that the GeoLocation struct can set and get the longitude of the class
        /// </summary>
        [TestMethod]
        public void setCurrLongitude_uponSettingLongitude_correctLongitudeIsSet()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);

            string longitude = "45.456456";
            //Act
            locationData.setCurrLongitude(longitude);

            //Assert
            Assert.AreEqual("45.456456", locationData.getCurrLongitude());
        }

        /// <summary>
        /// This test will check that the GeoLocation struct can set and get the latitude of the class
        /// </summary>
        [TestMethod]
        public void setCurrLatitude_uponSettingLatitude_correctLatitudeIsSet()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);         
            string latitude = "45.456456";

            //Act
            locationData.setCurrLatitude(latitude);

            //Assert
            Assert.AreEqual("45.456456", locationData.getCurrLatitude());
        }

        /// <summary>
        /// This test will check that the GeoLocation struct can set and get the CompassBearing of the class
        /// </summary>
        [TestMethod]
        public void setCompassBearing_uponSettingCompassBearing_correctCompassBearingIsSet()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.NE;
            
            //Act
            locationData.setCompassBearing(compassBearing);

            //Assert
            Assert.AreEqual(CompassBearing.NE, locationData.getCompassBearing());
        }

        /// <summary>
        /// This test will check that the GeoLocation struct can set and get the Province/State of the class
        /// </summary>
        [TestMethod]
        public void setProvinceState_uponSettingProvinceState_correctProvinceStateIsSet()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            string state = "Texas";

            //Act
            locationData.setCurrProvinceState(state);

            //Assert
            Assert.AreEqual("Texas", locationData.getCurrProvinceState());
        }

        /// <summary>
        /// This test will check that the GeoLocation struct can set and get the Province/State of the class
        /// </summary>
        [TestMethod]
        public void setCountry_uponSettingCountry_correctCountryIsSet()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            string country = "Canada";

            //Act
            locationData.setCurrCountry(country);

            //Assert
            Assert.AreEqual("Canada", locationData.getCurrCountry());
        }

        /// <summary>
        /// This test will check that the GeoLocation struct can set and get the estimated time of the class
        /// </summary>
        [TestMethod]
        public void setEstimatedTime_uponSettingEstimatedTime_correctEstimatedTimeIsSet()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            DateTime date = DateTime.Parse("10:00PM");

            //Act
            locationData.setCurrEstimatedArrivalTimeLeft(date.ToString("hh"));

            //Assert
            Assert.AreEqual("10", locationData.getCurrEstimatedArrivalTimeLeft());
        }

        /// <summary>
        /// This test will check that the obtain new longitude function can properly create a longitude and return it.
        /// Uses a seed for the random so that it can be predicted for the test.
        /// </summary>
        [TestMethod]
        public void obtainNewLongitude_UponCreatingALongitude_CorrectLongitudeIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            string result = "";

            //Act
            result = geo.obtainNewLongitude();

            //Assert
            Assert.AreEqual("-139.638781", result);
        }

        /// <summary>
        /// This test will check that the obtain new latitude function can properly create a latitude and return it.
        /// Uses a seed for the random so that it can be predicted for the test.
        /// </summary>
        [TestMethod]
        public void obtainNewLatitude_UponCreatingALatitude_CorrectLatitudeIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            string result = "";

            //Act
            result = geo.obtainNewLatitude();

            //Assert
            Assert.AreEqual("68.638781", result);              
        }

        /// <summary>
        /// This test will ensure that the geolocation class can create a new estimated time of arrical and
        /// can return it back correctly.
        /// </summary>
        [TestMethod]
        public void obtainNewEstimatedTimeOfArrival_UponCreatingANewEstimatedTimeOfArrival_CorrectEstimatedTimeOfArrivalIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            int planeSpeed = 300;
            string currentTime = "10:00";
            string result = "";

            //Act
            result = geo.obtainNewEstimatedTimeUntilArrival(planeSpeed, currentTime);

            //Assert
            Assert.AreEqual("09:54:16", result);
        }

        /// <summary>
        /// This test will ensure that the obtain new country function can properly obtain a new country, and can return it  
        /// </summary>
        [TestMethod]
        public void obtainNewCountry_UponCreatingANewCountry_CorrectCountryIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);        
            string result = "";

            //Act
            result = geo.obtainCurrentCountry();

            //Assert
            Assert.AreEqual("USA", result);
        }

        /// <summary>
        /// This test will ensure that the obtain new country function can properly obtain a new state, and can return it  
        /// </summary>
        [TestMethod]
        public void obtainNewState_UponCreatingANeweState_CorrectStateIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            string result = "", country = "USA";

            //Act
            result = geo.obtainCurrentProvinceState(country);

            //Assert
            Assert.AreEqual("Pennsylvania", result);
        }

        /// <summary>
        /// This test will ensure that the obtain new country function can properly obtain a new province, and can return it  
        /// </summary>
        [TestMethod]
        public void obtainNewProvince_UponCreatingANewProvince_CorrectProvinceIsReturned()
        {
            //Assert
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            string result = "", country = "CAN";

            //Act
            result = geo.obtainCurrentProvinceState(country);

            //Assert
            Assert.AreEqual("Prince Edward Island", result);
        }

        /*The next set of tests will be testing every possible outcome of my calculateCompassBearing function
         They are all very similar tests with only 1-2 things changed*/
      
        [TestMethod]
        public void obtainNewCompassBearingFromN_UponCreatingNewCompassBearing_NEIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.N;
            string directionToTurn = "Right";
            int angleToTurn = 45;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.NE);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromN_UponCreatingNewCompassBearing_EIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.N;
            string directionToTurn = "Right";
            int angleToTurn = 90;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.E);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromN_UponCreatingNewCompassBearing_NWIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.N;
            string directionToTurn = "Left";
            int angleToTurn = 45;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.NW);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromN_UponCreatingNewCompassBearing_WIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.N;
            string directionToTurn = "Left";
            int angleToTurn = 90;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.W);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromNE_UponCreatingNewCompassBearing_EIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.NE;
            string directionToTurn = "Right";
            int angleToTurn = 45;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.E);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromNE_UponCreatingNewCompassBearing_SEIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.NE;
            string directionToTurn = "Right";
            int angleToTurn = 90;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.SE);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromNE_UponCreatingNewCompassBearing_NIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.NE;
            string directionToTurn = "Left";
            int angleToTurn = 45;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.N);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromNE_UponCreatingNewCompassBearing_WIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.NE;
            string directionToTurn = "Left";
            int angleToTurn = 90;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.NW);
        }


        [TestMethod]
        public void obtainNewCompassBearingFromE_UponCreatingNewCompassBearing_SEIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.E;
            string directionToTurn = "Right";
            int angleToTurn = 45;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.SE);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromE_UponCreatingNewCompassBearing_SIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.E;
            string directionToTurn = "Right";
            int angleToTurn = 90;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.S);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromE_UponCreatingNewCompassBearing_NEIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.E;
            string directionToTurn = "Left";
            int angleToTurn = 45;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.NE);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromE_UponCreatingNewCompassBearing_NIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.E;
            string directionToTurn = "Left";
            int angleToTurn = 90;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.N);
        }


        [TestMethod]
        public void obtainNewCompassBearingFromSE_UponCreatingNewCompassBearing_SIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.SE;
            string directionToTurn = "Right";
            int angleToTurn = 45;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.S);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromSE_UponCreatingNewCompassBearing_SWIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.SE;
            string directionToTurn = "Right";
            int angleToTurn = 90;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.SW);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromSE_UponCreatingNewCompassBearing_EIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.SE;
            string directionToTurn = "Left";
            int angleToTurn = 45;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.E);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromSE_UponCreatingNewCompassBearing_NEIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.SE;
            string directionToTurn = "Left";
            int angleToTurn = 90;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.NE);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromS_UponCreatingNewCompassBearing_SWIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.S;
            string directionToTurn = "Right";
            int angleToTurn = 45;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.SW);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromS_UponCreatingNewCompassBearing_WIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.S;
            string directionToTurn = "Right";
            int angleToTurn = 90;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.W);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromS_UponCreatingNewCompassBearing_SEIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.S;
            string directionToTurn = "Left";
            int angleToTurn = 45;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.SE);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromS_UponCreatingNewCompassBearing_EIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.S;
            string directionToTurn = "Left";
            int angleToTurn = 90;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.E);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromSW_UponCreatingNewCompassBearing_WIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.SW;
            string directionToTurn = "Right";
            int angleToTurn = 45;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.W);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromSW_UponCreatingNewCompassBearing_NWIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.SW;
            string directionToTurn = "Right";
            int angleToTurn = 90;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.NW);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromSW_UponCreatingNewCompassBearing_SIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.SW;
            string directionToTurn = "Left";
            int angleToTurn = 45;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.S);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromSW_UponCreatingNewCompassBearing_SEIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.SW;
            string directionToTurn = "Left";
            int angleToTurn = 90;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.SE);
        }


        [TestMethod]
        public void obtainNewCompassBearingFromW_UponCreatingNewCompassBearing_NWIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.W;
            string directionToTurn = "Right";
            int angleToTurn = 45;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.NW);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromW_UponCreatingNewCompassBearing_NIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.W;
            string directionToTurn = "Right";
            int angleToTurn = 90;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.N);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromW_UponCreatingNewCompassBearing_SWIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.W;
            string directionToTurn = "Left";
            int angleToTurn = 45;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.SW);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromW_UponCreatingNewCompassBearing_SIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.W;
            string directionToTurn = "Left";
            int angleToTurn = 90;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.S);
        }


        [TestMethod]
        public void obtainNewCompassBearingFromNW_UponCreatingNewCompassBearing_NIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.NW;
            string directionToTurn = "Right";
            int angleToTurn = 45;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.N);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromNW_UponCreatingNewCompassBearing_NEIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.NW;
            string directionToTurn = "Right";
            int angleToTurn = 90;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.NE);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromNW_UponCreatingNewCompassBearing_WIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.NW;
            string directionToTurn = "Left";
            int angleToTurn = 45;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.W);
        }

        [TestMethod]
        public void obtainNewCompassBearingFromNW_UponCreatingNewCompassBearing_SWIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.NW;
            string directionToTurn = "Left";
            int angleToTurn = 90;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.SW);
        }

        [TestMethod]
        public void obtainNewCompassBearing_UponCreatingNewCompassBearing_DefaultIsReturned()
        {
            //Arrange
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.usedForTestingDefault;
            string directionToTurn = "Left";
            int angleToTurn = 90;

            //Act
            CompassBearing newBearing = geo.calculateNewCompassBearing(compassBearing, directionToTurn, angleToTurn);

            //Assert
            Assert.AreEqual(newBearing, CompassBearing.N);
        }















    }
}