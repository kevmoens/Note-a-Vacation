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
        String _Email;
        public String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }
        String _Password;
        public String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }
        List<Trip> _Trips;
        public List<Trip> Trips
        {
            get
            {
                return _Trips;
            }
            set
            {
                _Trips = value;
            }
        }
        List<Trip> _TripHistory;
        public List<Trip> TripHistory
        {
            get
            {
                return _TripHistory;
            }
            set
            {
                _TripHistory = value;
            }
        }
    }

    public class Trip
    {
        String _Name;
        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                Name = value;
            }
        }
        String _LatLongLoc;
        public String LatLongLoc
        {
            get
            {
                return _LatLongLoc;
            }
            set
            {
                _LatLongLoc = value;
            }
        }
        int _Radius;
        public int Radius
        {
            get
            {
                return _Radius;
            }
            set
            {
                _Radius = value;
            }
        }

        DateTime _CheckInDate;
        public DateTime CheckInDate
        {
            get
            {
                return _CheckInDate;
            }
            set
            {
                _CheckInDate = value;
            }
        }

        DateTime _CheckOutDate;
        public DateTime CheckOutDate
        {
            get
            {
                return _CheckOutDate;
            }
            set
            {
                _CheckOutDate = value;
            }
        }
        Double _MinStarRating;
        public Double MinStarRating
        {
            get
            {
                return _MinStarRating;
            }
            set
            {
                _MinStarRating = value;
            }
        }
        int _NumOfAdults;
        public int NumOfAdults
        {
            get
            {
                return _NumOfAdults;
            }
            set
            {
                _NumOfAdults = value;
            }
        }
        int _NumOfChildren;
        public int NumOfChildren
        {
            get
            {
                return _NumOfChildren;
            }
            set
            {
                _NumOfChildren = value;
            }
        }

        Notification _Notifications;
        public Notification Notifications
        {
            get
            {
                return _Notifications;
            }
            set
            {
                _Notifications = value;
            }
        }

        List<HotelData> _Hotel;
        public List<HotelData> Hotel
        {
            get
            {
                return _Hotel;
            }
            set
            {
                _Hotel = value;
            }
        }
    }

    public class Notification
    {
        double _MaxPricePoint;
        public double MaxPricePoint
        {
            get
            {
                return _MaxPricePoint;
            }
            set
            {
                _MaxPricePoint = value;
            }
        }
        double _WarningTrendPoint;
        public double WarningTrendPoint
        {
            get
            {
                return _WarningTrendPoint;
            }
            set
            {
                _WarningTrendPoint = value;
            }
        }

        double _ParadisePricePoint;
        public double ParadisePricePoint
        {
            get
            {
                return _ParadisePricePoint;
            }
            set
            {
                _ParadisePricePoint = value;
            }
        }
    }

    public class HotelData
    {
        String _Name;
        public String Name        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        double _Price;
        public double Price
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = value;
            }
        }
    }
}
