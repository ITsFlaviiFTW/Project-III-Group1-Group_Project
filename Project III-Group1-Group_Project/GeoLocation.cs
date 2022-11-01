using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_III_Group1_Group_Project
{
    public class GeoLocation
    {
        private string currLatitude { get; set; }
        private string currLongitude { get; set; }


        public override string ToString()
        {
            return currLatitude + "U+002C" + currLongitude;
        }
    }
}
