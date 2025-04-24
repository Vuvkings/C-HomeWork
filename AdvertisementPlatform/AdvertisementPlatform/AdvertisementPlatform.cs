using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementPlatform
{
    public class AdvertismentPlatform
    {
        public Dictionary<string, string> advertismentByLocation;
       public List<string> platformsList = new List<string>();
        public AdvertismentPlatform()
        {
            advertismentByLocation = [];
        }


        public void AddPlatform(string advertismentLocation)
        {
            var elements = advertismentLocation.Split(':');

            var locations = elements[1].Split(',');
            for (int i = 0; i < locations.Length; i++) 
            {
                advertismentByLocation.Add(locations[i], elements[0]);
            }
            
        }

        public List<string> GetPlatform(string location)
        {
            
            foreach (var loco in advertismentByLocation)
            {
                if (location == loco.Key) { platformsList.Add(loco.Value); }
      
            }
            return platformsList;
        }

    }
}
