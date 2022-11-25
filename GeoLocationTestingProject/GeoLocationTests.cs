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
            //Assert
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);

            string longitude = "45.456456";
            //Act
            locationData.setCurrLongitude(longitude);

            //Arrange
            Assert.AreEqual("45.456456", locationData.getCurrLongitude());
        }

        /// <summary>
        /// This test will check that the GeoLocation struct can set and get the latitude of the class
        /// </summary>
        [TestMethod]
        public void setCurrLatitude_uponSettingLatitude_correctLatitudeIsSet()
        {
            //Assert
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);         
            string latitude = "45.456456";

            //Act
            locationData.setCurrLatitude(latitude);

            //Arrange
            Assert.AreEqual("45.456456", locationData.getCurrLatitude());
        }

        /// <summary>
        /// This test will check that the GeoLocation struct can set and get the CompassBearing of the class
        /// </summary>
        [TestMethod]
        public void setCompassBearing_uponSettingCompassBearing_correctCompassBearingIsSet()
        {
            //Assert
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            CompassBearing compassBearing = CompassBearing.NE;
            
            //Act
            locationData.setCompassBearing(compassBearing);

            //Arrange
            Assert.AreEqual(CompassBearing.NE, locationData.getCompassBearing());
        }

        /// <summary>
        /// This test will check that the GeoLocation struct can set and get the Province/State of the class
        /// </summary>
        [TestMethod]
        public void setProvinceState_uponSettingProvinceState_correctProvinceStateIsSet()
        {
            //Assert
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            string state = "Texas";

            //Act
            locationData.setCurrProvinceState(state);

            //Arrange
            Assert.AreEqual("Texas", locationData.getCurrProvinceState());
        }

        /// <summary>
        /// This test will check that the GeoLocation struct can set and get the Province/State of the class
        /// </summary>
        [TestMethod]
        public void setCountry_uponSettingCountry_correctCountryIsSet()
        {
            //Assert
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            string country = "Canada";

            //Act
            locationData.setCurrCountry(country);

            //Arrange
            Assert.AreEqual("Canada", locationData.getCurrCountry());
        }

        /// <summary>
        /// This test will check that the GeoLocation struct can set and get the estimated time of the class
        /// </summary>
        [TestMethod]
        public void setEstimatedTime_uponSettingEstimatedTime_correctEstimatedTimeIsSet()
        {
            //Assert
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            DateTime date = DateTime.Parse("10:00PM");

            //Act
            locationData.setCurrEstimatedArrivalTimeLeft(date.ToString("hh"));

            //Arrange
            Assert.AreEqual("10", locationData.getCurrEstimatedArrivalTimeLeft());
        }

        /// <summary>
        /// This test will check that the obtain new longitude function can properly create a longitude and return it.
        /// Uses a seed for the random so that it can be predicted for the test.
        /// </summary>
        [TestMethod]
        public void obtainNewLongitude_UponCreatingALongitude_CorrectLongitudeIsReturned()
        {
            //Assert
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            string result = "";

            //Act
            result = geo.obtainNewLongitude();
            //Arrange
            Assert.AreEqual("-139.638781", result);
        }

        /// <summary>
        /// This test will check that the obtain new latitude function can properly create a latitude and return it.
        /// Uses a seed for the random so that it can be predicted for the test.
        /// </summary>
        [TestMethod]
        public void obtainNewLatitude_UponCreatingALatitude_CorrectLatitudeIsReturned()
        {
            //Assert
            LocationData locationData = new LocationData();
            GeoLocation geo = new GeoLocation(locationData);
            string result = "";

            //Act
            result = geo.obtainNewLatitude();
            //Arrange
            Assert.AreEqual("68.638781", result);
        }
    }
}