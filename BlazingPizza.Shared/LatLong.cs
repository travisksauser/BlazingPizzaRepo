using Newtonsoft.Json.Linq;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace BlazingPizza
{
    public class LatLong
    {
        public LatLong()
        {
        }

        public LatLong(double latitude, double longitude) : this()
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public static LatLong Interpolate(LatLong start, LatLong end, double proportion)
        {
            // The Earth is flat, right? So no need for spherical interpolation.
            return new LatLong(
                start.Latitude + (end.Latitude - start.Latitude) * proportion,
                start.Longitude + (end.Longitude - start.Longitude) * proportion);
        }

        public static async Task<LatLong> GetdtLatLongAsync(string url)
        {
            HttpClient httpClient = new HttpClient();
            string json = await httpClient.GetStringAsync(url);
            dynamic latlons = JsonConvert.DeserializeObject(json);
            dynamic latlon = latlons[0];
            httpClient.Dispose();
            return new LatLong(Convert.ToDouble(latlon.lat), Convert.ToDouble(latlon.lon));
        }
    }
}
