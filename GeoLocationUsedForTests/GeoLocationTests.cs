namespace GeoLocationUsedForTests
{
    public class GeoLocationTests
    {
        public enum CompassBearing
        {
            N,
            NE,
            E,
            SE,
            S,
            SW,
            W,
            NW
        }
        public struct LocationData
        {
            private string currLatitude;
            private string currLongitude;
            private CompassBearing currBearing;
            private string currProvinceState;
            private string currCountry;
            private string currEstimatedArrivalTimeLeft;

            public void setCurrLatitude(string currLatitude)
            {
                this.currLatitude = currLatitude;
            }
            public string getCurrLatitude()
            {
                return this.currLatitude;
            }

            public void setCurrLongitude(string currLongitude)
            {
                this.currLongitude = currLongitude;
            }
            public string getCurrLongitude()
            {
                return this.currLongitude;
            }

            public void setCompassBearing(CompassBearing compassBearing)
            {
                this.currBearing = compassBearing;
            }
            public CompassBearing getCompassBearing()
            {
                return this.currBearing;
            }

            public void setCurrProvinceState(string currProvinceState)
            {
                this.currProvinceState = currProvinceState;
            }
            public string getCurrProvinceState()
            {
                return this.currProvinceState;
            }

            public void setCurrCountry(string currCountry)
            {
                this.currCountry = currCountry;
            }
            public string getCurrCountry()
            {
                return this.currCountry;
            }


            public void setCurrEstimatedArrivalTimeLeft(string time)
            {
                this.currEstimatedArrivalTimeLeft = time;
            }
            public string getCurrEstimatedArrivalTimeLeft()
            {
                return this.currEstimatedArrivalTimeLeft;
            }
        }
        public class GeoLocation
        {
            public LocationData locationDataStruct;
            public GeoLocation(LocationData locationData)
            {
                this.locationDataStruct.setCurrLongitude(locationData.getCurrLongitude());
                this.locationDataStruct.setCurrLatitude(locationData.getCurrLatitude());
                this.locationDataStruct.setCompassBearing(locationData.getCompassBearing());
                this.locationDataStruct.setCurrProvinceState(locationData.getCurrProvinceState());
                this.locationDataStruct.setCurrCountry(locationData.getCurrCountry());
                this.locationDataStruct.setCurrEstimatedArrivalTimeLeft(locationData.getCurrEstimatedArrivalTimeLeft());
            }

            public string obtainNewLongitude()
            {
                if (!File.Exists("Resources\\longitudes.txt"))
                {
                    throw new Exception("Longitudes File does not exist");
                }
                else
                {
                    Random random = new Random();
                    string decimalPoint = "", wholeNumber = "", filePath = "Resources\\longitudes.txt";
                    string[] allLines = File.ReadAllLines(filePath);

                    wholeNumber = allLines[random.Next(allLines.Length)];
                    decimalPoint = random.Next(0, 1000000).ToString("D6");
                    return wholeNumber + "." + decimalPoint;
                }
            }

            public string obtainNewLatitude()
            {
                if (!File.Exists("Resources\\latitudes.txt"))
                {
                    throw new Exception("Latitudes File does not exist");
                }
                else
                {
                    Random random = new Random();
                    string decimalPoint = "", wholeNumber = "", filePath = "Resources\\latitudes.txt";
                    string[] allLines = File.ReadAllLines(filePath);

                    wholeNumber = allLines[random.Next(allLines.Length)];
                    decimalPoint = random.Next(0, 1000000).ToString("D6");
                    return wholeNumber + "." + decimalPoint;
                }
            }

            public string obtainNewEstimatedTimeUntilArrival(int planeSpeed, string currentEstimatedTime)
            {
                TimeSpan curr = TimeSpan.Parse(currentEstimatedTime);
                if (!File.Exists("Resources\\updatingEstimatedTime.txt"))
                {
                    throw new Exception("Time File does not exist");
                }
                else
                {
                    Random random = new Random();
                    string line = "", filePath = "Resources\\updatingEstimatedTime.txt";
                    string[] allLines = File.ReadAllLines(filePath);
                    line = allLines[random.Next(allLines.Length)];
                    switch (int.Parse(line))
                    {
                        case 1:
                            curr = curr.Add(TimeSpan.FromMinutes(random.Next(1, 6)));
                            curr = curr.Subtract(TimeSpan.FromSeconds(random.Next(1, 10)));
                            break;
                        case 2:
                            curr = curr.Subtract(TimeSpan.FromMinutes(random.Next(10, 16)));
                            curr = curr.Add(TimeSpan.FromSeconds(random.Next(15, 21)));
                            break;
                        case 3:
                            curr = curr.Subtract(TimeSpan.FromMinutes(random.Next(5, 8)));
                            curr = curr.Add(TimeSpan.FromSeconds(random.Next(20, 26)));
                            break;
                    }
                    if (planeSpeed >= 0 && planeSpeed <= 299)
                    {
                        curr = curr.Add(TimeSpan.FromMinutes(20));
                        curr = curr.Add(TimeSpan.FromSeconds(30));
                    }
                    else if (planeSpeed >= 300 && planeSpeed <= 599)
                    {
                        curr = curr.Subtract(TimeSpan.FromSeconds(5));
                    }
                    else
                    {
                        curr = curr.Subtract(TimeSpan.FromMinutes(30));
                        curr = curr.Subtract(TimeSpan.FromSeconds(30));
                    }
                    return curr.ToString();
                }
            }

            public string obtainCurrentCountry()
            {
                Random random = new Random();
                string currCountry = "";

                if (random.Next(1, 3) == 1)
                {
                    currCountry = "CAN";
                }
                else
                {
                    currCountry = "USA";
                }

                return currCountry;
            }

            public string obtainCurrentProvinceState(string currCountry)
            {
                Random rand = new Random();
                string[] allLines;
                string result = "";
                if (currCountry == "CAN")
                {
                    allLines = File.ReadAllLines("Resources\\Provinces.txt");
                    result = allLines[rand.Next(allLines.Length)];
                }
                else
                {
                    allLines = File.ReadAllLines("Resources\\States.txt");
                    result = allLines[rand.Next(allLines.Length)];
                }
                return result;
            }


            public CompassBearing calculateNewCompassBearing(CompassBearing currentBearing, string directionToTurn, int angleToTurn)
            {
                CompassBearing newBearing = CompassBearing.N;
                switch (currentBearing)
                {
                    case CompassBearing.N:
                        if (directionToTurn == "Right" && angleToTurn == 45) { newBearing = CompassBearing.NE; }
                        else if (directionToTurn == "Right" && angleToTurn == 90) { newBearing = CompassBearing.E; }
                        else if (directionToTurn == "Left" && angleToTurn == 45) { newBearing = CompassBearing.NW; }
                        else if (directionToTurn == "Left" && angleToTurn == 90) { newBearing = CompassBearing.W; }
                        break;
                    case CompassBearing.NE:
                        if (directionToTurn == "Right" && angleToTurn == 45) { newBearing = CompassBearing.E; }
                        else if (directionToTurn == "Right" && angleToTurn == 90) { newBearing = CompassBearing.SE; }
                        else if (directionToTurn == "Left" && angleToTurn == 45) { newBearing = CompassBearing.N; }
                        else if (directionToTurn == "Left" && angleToTurn == 90) { newBearing = CompassBearing.NW; }
                        break;
                    case CompassBearing.E:
                        if (directionToTurn == "Right" && angleToTurn == 45) { newBearing = CompassBearing.SE; }
                        else if (directionToTurn == "Right" && angleToTurn == 90) { newBearing = CompassBearing.S; }
                        else if (directionToTurn == "Left" && angleToTurn == 45) { newBearing = CompassBearing.NE; }
                        else if (directionToTurn == "Left" && angleToTurn == 90) { newBearing = CompassBearing.N; }
                        break;
                    case CompassBearing.SE:
                        if (directionToTurn == "Right" && angleToTurn == 45) { newBearing = CompassBearing.S; }
                        else if (directionToTurn == "Right" && angleToTurn == 90) { newBearing = CompassBearing.SW; }
                        else if (directionToTurn == "Left" && angleToTurn == 45) { newBearing = CompassBearing.E; }
                        else if (directionToTurn == "Left" && angleToTurn == 90) { newBearing = CompassBearing.NE; }
                        break;
                    case CompassBearing.S:
                        if (directionToTurn == "Right" && angleToTurn == 45) { newBearing = CompassBearing.SW; }
                        else if (directionToTurn == "Right" && angleToTurn == 90) { newBearing = CompassBearing.W; }
                        else if (directionToTurn == "Left" && angleToTurn == 45) { newBearing = CompassBearing.SE; }
                        else if (directionToTurn == "Left" && angleToTurn == 90) { newBearing = CompassBearing.E; }
                        break;
                    case CompassBearing.SW:
                        if (directionToTurn == "Right" && angleToTurn == 45) { newBearing = CompassBearing.W; }
                        else if (directionToTurn == "Right" && angleToTurn == 90) { newBearing = CompassBearing.NW; }
                        else if (directionToTurn == "Left" && angleToTurn == 45) { newBearing = CompassBearing.S; }
                        else if (directionToTurn == "Left" && angleToTurn == 90) { newBearing = CompassBearing.SE; }
                        break;
                    case CompassBearing.W:
                        if (directionToTurn == "Right" && angleToTurn == 45) { newBearing = CompassBearing.NW; }
                        else if (directionToTurn == "Right" && angleToTurn == 90) { newBearing = CompassBearing.N; }
                        else if (directionToTurn == "Left" && angleToTurn == 45) { newBearing = CompassBearing.SW; }
                        else if (directionToTurn == "Left" && angleToTurn == 90) { newBearing = CompassBearing.S; }
                        break;
                    case CompassBearing.NW:
                        if (directionToTurn == "Right" && angleToTurn == 45) { newBearing = CompassBearing.N; }
                        else if (directionToTurn == "Right" && angleToTurn == 90) { newBearing = CompassBearing.NE; }
                        else if (directionToTurn == "Left" && angleToTurn == 45) { newBearing = CompassBearing.W; }
                        else if (directionToTurn == "Left" && angleToTurn == 90) { newBearing = CompassBearing.SW; }
                        break;
                    default:
                        newBearing = CompassBearing.N;
                        break;
                }
                return newBearing;
            }
        }
    }
}