using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
        
        public async Task<string> AddNewProfile()
        {
            WcfMongoService.RequestClient proxy = new WcfMongoService.RequestClient();
            //if (Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Mobile" && !string.IsNullOrEmpty(modNAVDataAccess.gEndPoint)) proxy.Endpoint.Address = new EndpointAddress(new Uri(modNAVDataAccess.gEndPoint.TrimEnd('/') + "/WcfMongo/MongoRequest.svc"));
            if (await LoginExists(Email)) {
                return "Login already exists";
            }

            //deserialize to see if it returns a profile
            //if profile doesn't exist run add else return false
            return await proxy.InsertOneAsync("profile", JsonConvert.SerializeObject(this));
        }
        public static async Task<bool> LoginRequest(string inEmail, string inPassword)
        {
            WcfMongoService.RequestClient proxy = new WcfMongoService.RequestClient();
            //if (Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Mobile" && !string.IsNullOrEmpty(modNAVDataAccess.gEndPoint)) proxy.Endpoint.Address = new EndpointAddress(new Uri(modNAVDataAccess.gEndPoint.TrimEnd('/') + "/WcfMongo/MongoRequest.svc"));
            
            string result = string.Empty;
            result = await proxy.QueryAsync("profile", "{ Email: { $eq: '" + inEmail.ToLower() + "' }, Password: { $eq: '" + inPassword + "' } }");
            
            ElementProfiles p = JsonConvert.DeserializeObject<ElementProfiles>(result);
            if (p == null || p.Elements.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static async Task<bool> LoginExists(string inEmail)
        {
            WcfMongoService.RequestClient proxy = new WcfMongoService.RequestClient();
            //if (Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Mobile" && !string.IsNullOrEmpty(modNAVDataAccess.gEndPoint)) proxy.Endpoint.Address = new EndpointAddress(new Uri(modNAVDataAccess.gEndPoint.TrimEnd('/') + "/WcfMongo/MongoRequest.svc"));

            string result = string.Empty;
            //TODO uncomment and fix next line
            result = await proxy.QueryAsync("profile", "{ Email: { $eq: '" + inEmail.ToLower() + "' } }");


            ElementProfiles p = JsonConvert.DeserializeObject<ElementProfiles>(result);
            if (p == null || p.Elements.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public class Trip
    {
        String _TripName;
        public String TripName
        {
            get
            {
                return _TripName;
            }
            set
            {
                _TripName = value;
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

    public class ElementProfiles
    {
        public List<Profile> Elements;
    }
}
