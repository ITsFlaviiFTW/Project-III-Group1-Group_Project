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
    }
}