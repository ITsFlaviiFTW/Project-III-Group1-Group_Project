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

        /// <summary>
        /// This test will ensure that the calculate new compass bearing can obtain a new compass bearing and properly return it 
        /// </summary>
        [TestMethod]
        public void obtainNewCompassBearing_UponCreatingNewCompassBearing_CorrectBearingIsReturned()
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

    }
}