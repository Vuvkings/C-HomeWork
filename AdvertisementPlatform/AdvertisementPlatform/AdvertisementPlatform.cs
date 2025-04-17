using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementPlatform
{
    public class AdvertismentPlatform
    {
        private Dictionary<string, List<string>> advertismentByLocation;
        public AdvertismentPlatform()
        {
            advertismentByLocation = new();
        }
        public void AddPlatform(string advertismentLocation)
        {
            var elements = "Яндекс.Директ:/ru/svrd/pervik".Split(':');

            var locations = elements[1].Split('/');
        }
        public List<string> GetPlatform(string location)
        {
            return new List<string>();
        }

    }
}
