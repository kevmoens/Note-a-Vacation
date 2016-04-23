using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVDataAccess
{
    public class Profile
    {
        String _FirstName;
        public String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }
        String _LastName;
        public String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }
        //email
        //password
        //trips[]
        //historytrips[]
    }

    public class Trip
    {
        //name
        //location (latitude, longitude)
        //radius
        //checkin date
        //checkout date
        //min star rating
        //number of adults
        //number of children
        //notification settings
        //trends[]
        //hotelsinradius[]
    }
}
